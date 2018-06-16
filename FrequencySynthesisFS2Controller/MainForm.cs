using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace FrequencySynthesisFS2Controller
{
    public partial class MainForm : Form
    {
        private SerialPort _SerialPort;
        private SerialPort SerialPort
        {
            get
            {
                if (_SerialPort == null)
                {
                    _SerialPort = new SerialPort();
                    _SerialPort.BaudRate = 115200;
                    _SerialPort.DataBits = 8;
                    _SerialPort.Parity = Parity.None;
                    _SerialPort.Handshake = Handshake.None;
                    _SerialPort.StopBits = StopBits.One;
                }
                return _SerialPort;
            }
        }
        private Boolean IsOpen
        {
            set
            {
                if (value)
                {
                    ResumeStatusPolling();

                    pbSerialPort.Image = Properties.Resources.green_small;
                    cbSerialPort.Enabled = false;
                    btnConnect.Text = "CLOSE";
                    btnFreq.Enabled = true;
                    btnSweep.Enabled = true;
                }
                else
                {
                    PauseStatusPolling();

                    pbSerialPort.Image = Properties.Resources.red_small;
                    cbSerialPort.Enabled = true;
                    btnConnect.Text = "OPEN";
                    btnFreq.Enabled = false;
                    btnSweep.Enabled = false;

                    Alarms.ForEach(alarm => alarm.Image = Properties.Resources.black_small);
                    tbTemp.Text = "0.0";
                }
            }
            get
            {
                return SerialPort.IsOpen;
            }
        }

        private static string Caption = "주파수 합성 모듈 (FS1)";
        private static List<PictureBox> Alarms = new List<PictureBox>();
        private static int NumAlarm = 7;

        private static ManualResetEvent ResponseReceivedEvent = new ManualResetEvent(false);
        private static object RequestLock = new object();
        private static int ResponseTimeout = 1000; // 1 seconds
        private int ResponseReceived = 0;
        private byte[] ResponseFrameBuffer;
        private bool ResponseFrameStarted = false;
        private bool ResponseFrameEnded = false;

        private static ManualResetEvent ConnectedEvent = new ManualResetEvent(false);
        private static Thread StatusPollingThread;
        private static int StatusPollingDelay = 1000; // 1 seconds

        private delegate void UpdateTemperature(Int16 value);

        public MainForm()
        {
            InitializeComponent();

            StatusPollingThread = new Thread(new ThreadStart(PollStatus));
            StatusPollingThread.IsBackground = true;
            StatusPollingThread.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitSerialPort();
            InitAlarm();
            InitFrequency();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsOpen)
            {
                SerialPort.Close();
            }
        }

        private void InitSerialPort()
        {
            cbSerialPort.Items.Clear();
            cbSerialPort.Items.Add(" SELECT PORT");
            foreach (string portName in SerialPort.GetPortNames())
            {
                cbSerialPort.Items.Add(portName);
            }
            cbSerialPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSerialPort.SelectedIndex = 0;
        }

        private void InitAlarm()
        {
            Alarms.Add(pbAlarm1);
            Alarms.Add(pbAlarm2);
            Alarms.Add(pbAlarm3);
            Alarms.Add(pbAlarm4);
            Alarms.Add(pbAlarm5);
            Alarms.Add(pbAlarm6);
            Alarms.Add(pbAlarm7);
        }

        private void UpdateStatus(RequestResult status)
        {
            for (int i = 0; i < NumAlarm; i++)
            {
                Alarms[i].Invoke(new Action(() => Alarms[i].Image = status.Alams[i] ?
                    Properties.Resources.green_small : Properties.Resources.red_small));
            }

            tbTemp.Invoke(new Action(() => tbTemp.Text = status.Temperature.ToString()));

        }

        private void InitFrequency()
        {
            rbNormal.Select();
        }

        // Event handlers for serial port connection group      
        private void cbSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SerialPort.PortName = cbSerialPort.Text;
            IsOpen = SerialPort.IsOpen; // should be always false here
            if (cbSerialPort.SelectedIndex == 0)
            {
                pbSerialPort.Image = Properties.Resources.black_small;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cbSerialPort.SelectedIndex == 0)
            {
                return;
            }

            if (!IsOpen)
            {
                try
                {
                    SerialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("연결에 실패했습니다, 다시 시도해 주세요.\n" +
                        ex.Message,
                        Caption,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                SerialPort.Close();
            }

            IsOpen = SerialPort.IsOpen;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (IsOpen)
            {
                SerialPort.Close();
            }
            this.Close();
        }

        // Event handlers for frequency select group
        private void tbFreq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnFreq_Click(object sender, EventArgs e)
        {
            string valueError;
            byte[] data;
            if (!ValidateFrequencyValue(out data, out valueError))
            {
                MessageBox.Show("유효하지 않은 값입니다, 다시 시도해 주세요.\n" +
                    valueError,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            RequestResult reqResult;
            Request request = new Request(CommandType.FrequencyRequest, data);
            bool result = SendRequest(request, out reqResult);
            if (!result)
            {
                MessageBox.Show("Frequency 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidateFrequencyValue(out byte[] data, out string error)
        {
            int value = Convert.ToInt32(tbFreq.Text);
            if (value < 0 || value > 255)
            {
                error = "오류: 0.0 ~ 255 사이의 값을 넣어 주세요.";
                data = new byte[0];
                return false;
            }

            error = "";
            data = new byte[] {
                Convert.ToByte(value),
                rbNormal.Checked ? (byte) ModeType.Normal : (byte) ModeType.Silence
            };
            return true;
        }

        // Event handlers for sweep group
        private void tbStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tbStop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void tbSweep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) ||
                e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnSweep_Click(object sender, EventArgs e)
        {
            string valueError;
            byte[] data;
            if (!ValidateSweepValue(out data, out valueError))
            {
                MessageBox.Show("유효하지 않은 값입니다, 다시 시도해 주세요.\n" +
                    valueError,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            RequestResult reqResult;
            Request request = new Request(CommandType.SweepRequest, data);
            bool result = SendRequest(request, out reqResult);
            if (!result)
            {
                MessageBox.Show("Sweep 값을 설정하지 못했습니다, 다시 시도해 주세요.\n" +
                    reqResult.ErrorMessage,
                    Caption,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

            // Test code
            //bool result = SendRequestTest(request,
            //    CommandType.SweepResponse,
            //    ResultState.Ok,
            //    new byte[6] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
            //    out reqResult);
        }

        private bool ValidateSweepValue(out byte[] data, out string error)
        {
            int start = Convert.ToInt32(tbStart.Text);
            int stop = Convert.ToInt32(tbStop.Text);
            int sweep = Convert.ToInt32(tbSweep.Text);

            if (start < 0 || start > 65535 ||
                stop < 0 || stop > 65535 ||
                sweep < 0 || sweep > 65535)
            {
                error = "오류: 0 ~ 65535 사이의 값을 넣어 주세요.";
                data = new byte[0];
                return false;
            }

            error = "";
            data = new byte[6];
            BitConverter.GetBytes(Convert.ToUInt16(start)).CopyTo(data, 0);
            BitConverter.GetBytes(Convert.ToUInt16(stop)).CopyTo(data, 2);
            BitConverter.GetBytes(Convert.ToUInt16(sweep)).CopyTo(data, 4);
            return true;
        }

        private RequestResult GetCurrentStatus()
        {
            Request request = new Request(CommandType.StatusRequest);
            RequestResult reqResult;
            bool result = SendRequest(request, out reqResult);

            return result ? reqResult : null;
        }

        private void PollStatus()
        {
            while (ConnectedEvent.WaitOne())
            {
                RequestResult result = GetCurrentStatus();
                if (result != null)
                {
                    UpdateStatus(result);
                }
                Thread.Sleep(StatusPollingDelay);
            }
        }

        private void PauseStatusPolling()
        {
            ConnectedEvent.Reset();
        }

        private void ResumeStatusPolling()
        {
            ConnectedEvent.Set();
        }

        private bool SendRequest(Request request, out RequestResult reqResult)
        {
            lock (RequestLock)
            {
                bool result = false;
                ResponseReceivedEvent.Reset();

                // Restore variables to default to handle the new request
                ResponseFrameBuffer = new byte[FrameConstants.MessageBufferLength];
                ResponseReceived = 0;
                ResponseFrameStarted = false;
                ResponseFrameEnded = false;

                SerialPort.DiscardOutBuffer();
                SerialPort.DiscardInBuffer();
                SerialPort.DataReceived += Port_DataReceived;

                SerialPort.Write(request.FrameBuffer, 0, request.FrameLength);

                // Block main form until it gets response
                ResponseReceivedEvent.WaitOne(ResponseTimeout);
                SerialPort.DataReceived -= Port_DataReceived;

                // Handle response if valid resonse received or
                // just return false when timed out
                if (ResponseFrameEnded)
                {
                    ResponseReceivedEvent.Set();
                    byte[] responseFrame = new byte[ResponseReceived]; // Trim trailing nulls
                    Array.Copy(ResponseFrameBuffer, responseFrame, ResponseReceived);
                    result = request.GetResult(responseFrame, out reqResult);
                }
                else
                {
                    reqResult = new RequestResult();
                    reqResult.ErrorMessage = "오류: 응답을 받지 못했습니다";
                }
                return result;
            }
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (SerialPort.BytesToRead > 0 && !ResponseFrameEnded)
            {
                byte read = (byte)SerialPort.ReadByte();
                if (read == FrameConstants.StartCode)
                {
                    ResponseFrameStarted = true;
                }
                else if (read == FrameConstants.EndCode)
                {
                    // Release main form when receiving response complete
                    ResponseFrameEnded = true;
                }
                else if (ResponseFrameStarted &&
                    ResponseReceived < FrameConstants.MessageBufferLength)
                {
                    ResponseFrameBuffer[ResponseReceived++] = read;
                }
            }
        }

        private bool SendRequestTest(Request request,
                                     CommandType testResponseCommand,
                                     ResultState testResultState,
                                     byte[] testResponseData,
                                     out RequestResult reqResult)
        {
            bool result = false;

            // build response message
            byte[] responseMessage = new byte[request.Message.Length];
            responseMessage[0] = (byte) testResponseCommand;
            responseMessage[1] = (byte) testResultState;
            testResponseData.CopyTo(responseMessage, 2);
            ushort checksum = Request.ComputeChecksum(responseMessage);

            // do stuffing
            byte[] original = new byte[responseMessage.Length + 2];
            responseMessage.CopyTo(original, 0);
            BitConverter.GetBytes(checksum).CopyTo(original, responseMessage.Length);
            byte[] stuffed = Request.Stuff(original);

            // process response message
            result = request.GetResult(stuffed, out reqResult);
            return result;
        }
    }
}
