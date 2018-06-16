namespace FrequencySynthesisFS2Controller
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbSerialPort = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbSerialPort = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbSilence = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.btnFreq = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbFreq = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbAlarm7 = new System.Windows.Forms.PictureBox();
            this.pbAlarm6 = new System.Windows.Forms.PictureBox();
            this.pbAlarm5 = new System.Windows.Forms.PictureBox();
            this.pbAlarm4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbAlarm3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbAlarm2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbAlarm1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSweep = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbSweep = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbStop = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbStart = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbSerialPort);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.cbSerialPort);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(23, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 77);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "통신";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(311, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "통신상태";
            // 
            // pbSerialPort
            // 
            this.pbSerialPort.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbSerialPort.InitialImage = null;
            this.pbSerialPort.Location = new System.Drawing.Point(333, 28);
            this.pbSerialPort.Name = "pbSerialPort";
            this.pbSerialPort.Size = new System.Drawing.Size(16, 16);
            this.pbSerialPort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSerialPort.TabIndex = 4;
            this.pbSerialPort.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(396, 28);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(163, 28);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "OPEN";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbSerialPort
            // 
            this.cbSerialPort.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSerialPort.FormattingEnabled = true;
            this.cbSerialPort.Location = new System.Drawing.Point(15, 30);
            this.cbSerialPort.Name = "cbSerialPort";
            this.cbSerialPort.Size = new System.Drawing.Size(130, 31);
            this.cbSerialPort.TabIndex = 1;
            this.cbSerialPort.SelectedIndexChanged += new System.EventHandler(this.cbSerialPort_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(121, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(301, 37);
            this.label7.TabIndex = 15;
            this.label7.Text = "주파수 합성 모듈 (FS2)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbSilence);
            this.groupBox6.Controls.Add(this.rbNormal);
            this.groupBox6.Controls.Add(this.btnFreq);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.tbFreq);
            this.groupBox6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox6.Location = new System.Drawing.Point(264, 155);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(281, 134);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "FREQ. SELECT";
            // 
            // rbSilence
            // 
            this.rbSilence.AutoSize = true;
            this.rbSilence.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSilence.Location = new System.Drawing.Point(18, 103);
            this.rbSilence.Name = "rbSilence";
            this.rbSilence.Size = new System.Drawing.Size(80, 23);
            this.rbSilence.TabIndex = 20;
            this.rbSilence.TabStop = true;
            this.rbSilence.Text = "SILENCE";
            this.rbSilence.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNormal.Location = new System.Drawing.Point(18, 77);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(86, 23);
            this.rbNormal.TabIndex = 19;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "NORMAL";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // btnFreq
            // 
            this.btnFreq.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFreq.Location = new System.Drawing.Point(155, 28);
            this.btnFreq.Name = "btnFreq";
            this.btnFreq.Size = new System.Drawing.Size(120, 98);
            this.btnFreq.TabIndex = 12;
            this.btnFreq.Text = "SEND";
            this.btnFreq.UseVisualStyleBackColor = true;
            this.btnFreq.Click += new System.EventHandler(this.btnFreq_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 19);
            this.label13.TabIndex = 18;
            this.label13.Text = "No.";
            // 
            // tbFreq
            // 
            this.tbFreq.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFreq.Location = new System.Drawing.Point(15, 28);
            this.tbFreq.Name = "tbFreq";
            this.tbFreq.Size = new System.Drawing.Size(107, 36);
            this.tbFreq.TabIndex = 0;
            this.tbFreq.Text = "0";
            this.tbFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbFreq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFreq_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbTemp);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(23, 521);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 75);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TEMP";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(172, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 19);
            this.label12.TabIndex = 18;
            this.label12.Text = "°C";
            // 
            // tbTemp
            // 
            this.tbTemp.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTemp.Location = new System.Drawing.Point(42, 28);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.ReadOnly = true;
            this.tbTemp.Size = new System.Drawing.Size(124, 36);
            this.tbTemp.TabIndex = 0;
            this.tbTemp.Text = "0.0";
            this.tbTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.pbAlarm7);
            this.groupBox2.Controls.Add(this.pbAlarm6);
            this.groupBox2.Controls.Add(this.pbAlarm5);
            this.groupBox2.Controls.Add(this.pbAlarm4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.pbAlarm3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.pbAlarm2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pbAlarm1);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(23, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 360);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ALARM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 19);
            this.label9.TabIndex = 15;
            this.label9.Text = "WARM UP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "+6.6V OVER CURRENT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "+5 OVER CURRENT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "+15V OVER CURRENT";
            // 
            // pbAlarm7
            // 
            this.pbAlarm7.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm7.Location = new System.Drawing.Point(15, 250);
            this.pbAlarm7.Name = "pbAlarm7";
            this.pbAlarm7.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm7.TabIndex = 9;
            this.pbAlarm7.TabStop = false;
            // 
            // pbAlarm6
            // 
            this.pbAlarm6.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm6.Location = new System.Drawing.Point(15, 215);
            this.pbAlarm6.Name = "pbAlarm6";
            this.pbAlarm6.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm6.TabIndex = 8;
            this.pbAlarm6.TabStop = false;
            // 
            // pbAlarm5
            // 
            this.pbAlarm5.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm5.Location = new System.Drawing.Point(15, 180);
            this.pbAlarm5.Name = "pbAlarm5";
            this.pbAlarm5.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm5.TabIndex = 7;
            this.pbAlarm5.TabStop = false;
            // 
            // pbAlarm4
            // 
            this.pbAlarm4.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm4.Location = new System.Drawing.Point(15, 145);
            this.pbAlarm4.Name = "pbAlarm4";
            this.pbAlarm4.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm4.TabIndex = 6;
            this.pbAlarm4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "PLL";
            // 
            // pbAlarm3
            // 
            this.pbAlarm3.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm3.Location = new System.Drawing.Point(15, 110);
            this.pbAlarm3.Name = "pbAlarm3";
            this.pbAlarm3.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm3.TabIndex = 4;
            this.pbAlarm3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tx Power";
            // 
            // pbAlarm2
            // 
            this.pbAlarm2.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm2.Location = new System.Drawing.Point(15, 75);
            this.pbAlarm2.Name = "pbAlarm2";
            this.pbAlarm2.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm2.TabIndex = 2;
            this.pbAlarm2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "LO 2";
            // 
            // pbAlarm1
            // 
            this.pbAlarm1.Image = global::FrequencySynthesisFS2Controller.Properties.Resources.black_small;
            this.pbAlarm1.Location = new System.Drawing.Point(15, 40);
            this.pbAlarm1.Name = "pbAlarm1";
            this.pbAlarm1.Size = new System.Drawing.Size(16, 16);
            this.pbAlarm1.TabIndex = 0;
            this.pbAlarm1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSweep);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.tbSweep);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.tbStop);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.tbStart);
            this.groupBox4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox4.Location = new System.Drawing.Point(23, 602);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(522, 101);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SWEEP";
            // 
            // btnSweep
            // 
            this.btnSweep.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSweep.Location = new System.Drawing.Point(396, 51);
            this.btnSweep.Name = "btnSweep";
            this.btnSweep.Size = new System.Drawing.Size(120, 36);
            this.btnSweep.TabIndex = 12;
            this.btnSweep.Text = "SEND";
            this.btnSweep.UseVisualStyleBackColor = true;
            this.btnSweep.Click += new System.EventHandler(this.btnSweep_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(278, 29);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 19);
            this.label21.TabIndex = 30;
            this.label21.Text = "SWEEP No.";
            // 
            // tbSweep
            // 
            this.tbSweep.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSweep.Location = new System.Drawing.Point(263, 51);
            this.tbSweep.Name = "tbSweep";
            this.tbSweep.Size = new System.Drawing.Size(115, 36);
            this.tbSweep.TabIndex = 28;
            this.tbSweep.Text = "0";
            this.tbSweep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSweep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSweep_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(176, 29);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 19);
            this.label22.TabIndex = 27;
            this.label22.Text = "STOP";
            // 
            // tbStop
            // 
            this.tbStop.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStop.Location = new System.Drawing.Point(139, 51);
            this.tbStop.Name = "tbStop";
            this.tbStop.Size = new System.Drawing.Size(115, 36);
            this.tbStop.TabIndex = 25;
            this.tbStop.Text = "0";
            this.tbStop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStop_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(49, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 19);
            this.label23.TabIndex = 24;
            this.label23.Text = "START";
            // 
            // tbStart
            // 
            this.tbStart.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStart.Location = new System.Drawing.Point(15, 51);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(115, 36);
            this.tbStart.TabIndex = 19;
            this.tbStart.Text = "0";
            this.tbStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStart_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 722);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "MainForm";
            this.Text = "주파수 합성 모듈 (FS2)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSerialPort)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAlarm1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSerialPort;
        private System.Windows.Forms.PictureBox pbSerialPort;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbAlarm7;
        private System.Windows.Forms.PictureBox pbAlarm6;
        private System.Windows.Forms.PictureBox pbAlarm5;
        private System.Windows.Forms.PictureBox pbAlarm4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbAlarm3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbAlarm2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbAlarm1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbFreq;
        private System.Windows.Forms.Button btnFreq;
        private System.Windows.Forms.RadioButton rbSilence;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSweep;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbSweep;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbStop;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbStart;
    }
}

