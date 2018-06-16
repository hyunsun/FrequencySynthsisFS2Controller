using System;
using System.Collections.Generic;
using System.Linq;

namespace FrequencySynthesisFS2Controller
{
    public enum CommandType : byte
    {
        StatusRequest = 0x11,
        FrequencyRequest = 0x12,
        SweepRequest = 0x14,

        StatusResponse = 0x91, //test: 0x71 q
        FrequencyResponse = 0x92,
        SweepResponse = 0x94
    }

    public enum ModeType : byte
    {
        Silence = 0x00, 
        Normal = 0x01
    }

    public enum ResultState : byte
    {
        Ok = 0x00, //test: 0x67 g
        InvalidRequest = 0xFF, //test: 0x68 h
        ModeError = 0xFE //test: 0x69 i
    }

    class RequestResult
    {
        public string ErrorMessage;
        public List<bool> Alams = new List<bool>();
        public double Temperature;
    }

    class FrameConstants
    {
        public const byte StartCode = 0x7E; //test: 0x61 a
        public const byte EndCode = 0x7F; //test: 0x66 f
        public static byte[] StatusReqData = { 0xAA, 0xBB, 0xCC };

        public static ushort[] CRCTable = {
            0x0000, 0x1021, 0x2042, 0x3063, 0x4084, 0x50A5, 0x60C6, 0x70E7,
            0x8108, 0x9129, 0xA14A, 0xB16B, 0xC18C, 0xD1AD, 0xE1CE, 0xF1EF,
            0x1231, 0x0210, 0x3273, 0x2252, 0x52B5, 0x4294, 0x72F7, 0x62D6,
            0x9339, 0x8318, 0xB37B, 0xA35A, 0xD3BD, 0xC39C, 0xF3FF, 0xE3DE,
            0x2462, 0x3443, 0x0420, 0x1401, 0x64E6, 0x74C7, 0x44A4, 0x5485,
            0xA56A, 0xB54B, 0x8528, 0x9509, 0xE5EE, 0xF5CF, 0xC5AC, 0xD58D,
            0x3653, 0x2672, 0x1611, 0x0630, 0x76D7, 0x66F6, 0x5695, 0x46B4,
            0xB75B, 0xA77A, 0x9719, 0x8738, 0xF7DF, 0xE7FE, 0xD79D, 0xC7BC,
            0x48C4, 0x58E5, 0x6886, 0x78A7, 0x0840, 0x1861, 0x2802, 0x3823,
            0xC9CC, 0xD9ED, 0xE98E, 0xF9AF, 0x8948, 0x9969, 0xA90A, 0xB92B,
            0x5AF5, 0x4AD4, 0x7AB7, 0x6A96, 0x1A71, 0x0A50, 0x3A33, 0x2A12,
            0xDBFD, 0xCBDC, 0xFBBF, 0xEB9E, 0x9B79, 0x8B58, 0xBB3B, 0xAB1A,
            0x6CA6, 0x7C87, 0x4CE4, 0x5CC5, 0x2C22, 0x3C03, 0x0C60, 0x1C41,
            0xEDAE, 0xFD8F, 0xCDEC, 0xDDCD, 0xAD2A, 0xBD0B, 0x8D68, 0x9D49,
            0x7E97, 0x6EB6, 0x5ED5, 0x4EF4, 0x3E13, 0x2E32, 0x1E51, 0x0E70,
            0xFF9F, 0xEFBE, 0xDFDD, 0xCFFC, 0xBF1B, 0xAF3A, 0x9F59, 0x8F78,
            0x9188, 0x81A9, 0xB1CA, 0xA1EB, 0xD10C, 0xC12D, 0xF14E, 0xE16F,
            0x1080, 0x00A1, 0x30C2, 0x20E3, 0x5004, 0x4025, 0x7046, 0x6067,
            0x83B9, 0x9398, 0xA3FB, 0xB3DA, 0xC33D, 0xD31C, 0xE37F, 0xF35E,
            0x02B1, 0x1290, 0x22F3, 0x32D2, 0x4235, 0x5214, 0x6277, 0x7256,
            0xB5EA, 0xA5CB, 0x95A8, 0x8589, 0xF56E, 0xE54F, 0xD52C, 0xC50D,
            0x34E2, 0x24C3, 0x14A0, 0x0481, 0x7466, 0x6447, 0x5424, 0x4405,
            0xA7DB, 0xB7FA, 0x8799, 0x97B8, 0xE75F, 0xF77E, 0xC71D, 0xD73C,
            0x26D3, 0x36F2, 0x0691, 0x16B0, 0x6657, 0x7676, 0x4615, 0x5634,
            0xD94C, 0xC96D, 0xF90E, 0xE92F, 0x99C8, 0x89E9, 0xB98A, 0xA9AB,
            0x5844, 0x4865, 0x7806, 0x6827, 0x18C0, 0x08E1, 0x3882, 0x28A3,
            0xCB7D, 0xDB5C, 0xEB3F, 0xFB1E, 0x8BF9, 0x9BD8, 0xABBB, 0xBB9A,
            0x4A75, 0x5A54, 0x6A37, 0x7A16, 0x0AF1, 0x1AD0, 0x2AB3, 0x3A92,
            0xFD2E, 0xED0F, 0xDD6C, 0xCD4D, 0xBDAA, 0xAD8B, 0x9DE8, 0x8DC9,
            0x7C26, 0x6C07, 0x5C64, 0x4C45, 0x3CA2, 0x2C83, 0x1CE0, 0x0CC1,
            0xEF1F, 0xFF3E, 0xCF5D, 0xDF7C, 0xAF9B, 0xBFBA, 0x8FD9, 0x9FF8,
            0x6E17, 0x7E36, 0x4E55, 0x5E74, 0x2E93, 0x3EB2, 0x0ED1, 0x1EF0
        };

        public const int MessageBufferLength = 18; // max frame length with stuffing
        public const byte FS2Mode = 0x02;
        public const byte CommandDifference = 0x80; //test: 0x70;
        public const byte StuffKey = 0x7D;
        public static byte[] StuffChars = { 0x7D, 0x7E, 0x7F };
        public const byte XorKey = 0x20;
    }

    class Request : FrameConstants
    {
        public byte[] Message;
        public ushort Checksum;
        public byte[] FrameBuffer;
        public int FrameLength;

        public byte ResponseCommand;
        public byte[] ResponseData;

        public Request(CommandType command, byte[] data = null)
        {
            if (command == CommandType.StatusRequest)
            {
                data = StatusReqData;
            }

            Message = new byte[data.Length + 2];
            Message[0] = (byte)command;
            Message[1] = FS2Mode;
            data.CopyTo(Message, 2);

            Checksum = ComputeChecksum(Message);
            ResponseCommand = (byte)(command + CommandDifference);
            ResponseData = data;
            CreateRequestFrame();
        }

        public void CreateRequestFrame()
        {
            // Perform character stuffing for message and CRC
            byte[] original = new byte[Message.Length + 2];            
            Message.CopyTo(original, 0);
            BitConverter.GetBytes(Checksum).CopyTo(original, Message.Length);
            byte[] stuffed = Stuff(original);

            FrameLength = stuffed.Length + 2;
            FrameBuffer = new byte[FrameLength];

            FrameBuffer[0] = StartCode;
            stuffed.CopyTo(FrameBuffer, 1);
            FrameBuffer[FrameLength -1] = EndCode;
        }

        public bool GetResult(byte[] responseBuffer, out RequestResult result)
        {
            byte[] response = Strip(responseBuffer);

            // Get crc value
            int length = response.Length - 2;
            ushort crc = BitConverter.ToUInt16(response, length);

            // Get message
            byte[] responseMessage = new byte[length];
            Array.Copy(response, responseMessage, length);

            // Get command, result state, and data
            byte command = responseMessage[0];
            ResultState resultState = (ResultState)responseMessage[1];
            length = responseMessage.Length - 2;
            byte[] data = new byte[length];
            Array.Copy(responseMessage, 2, data, 0, length);

            // Get request result
            result = new RequestResult();
            if (resultState == ResultState.ModeError)
            {
                result.ErrorMessage = "오류: 요청에 실패했습니다(error code: 0xFE)";
                return false;
            }
            if (resultState == ResultState.InvalidRequest)
            {
                result.ErrorMessage = "오류: 요청에 실패했습니다(error code: 0xFF)";
                return false;
            }
            if (ComputeChecksum(responseMessage) != crc)
            {
                result.ErrorMessage = "오류: 응답 메시지의 데이터가 손상됐습니다(checksum error)";
                return false;
            }
            if (command != ResponseCommand)
            {
                result.ErrorMessage = "오류: 요청과 응답이 상이합니다(command not match)";
                return false;
            }
            if (command != (byte)CommandType.StatusResponse &&
                !ResponseData.SequenceEqual(data))
            {
                result.ErrorMessage = "요류: 요청 값과 응답 값이 상이합니다(value not match)";
                return false;
            }

            if (command == (byte)CommandType.StatusResponse)
            {
                byte digitalAlarm = data[0];
                for (int i = 0; i <= 2; i++)
                {
                    result.Alams.Add((digitalAlarm & 1 << i) != 0);
                }

                byte powerAlarm = data[1];
                for (int i = 0; i <= 3; i++)
                {
                    result.Alams.Add((powerAlarm & 1 << i) != 0);
                }

                result.Temperature = BitConverter.ToInt16(data, 2) * 0.1;
            }
            return true;
        }

        public static ushort ComputeChecksum(byte[] buffer)
        {
            if (buffer == null) throw new ArgumentNullException();
            ushort crc = 0;
            for (int i = 0; i < buffer.Length; ++i)
            {
                crc = (ushort)((crc << 8) ^ CRCTable[((crc >> 8) & 0xff) ^ buffer[i]]);
            }
            return crc;
        }

        public static byte[] Stuff(byte[] data)
        {
            int length = data.Length + data.Count(d => StuffChars.Contains(d));
            byte[] stuffed = new byte[length];

            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (StuffChars.Contains(data[i]))
                {
                    stuffed[index++] = StuffKey;
                    stuffed[index++] = (byte)(data[i] ^ XorKey);
                }
                else
                {
                    stuffed[index++] = data[i];
                }
            }
            return stuffed;
        }

        public static byte[] Strip(byte[] data)
        {
            int length = data.Length - data.Count(d => d == StuffKey);
            byte[] original = new byte[length];

            int index = 0;
            bool encrypted = false;
            for (int i = 0; i < data.Length; i++)
            {
                if (encrypted)
                {
                    original[index++] = (byte)(data[i] ^ XorKey);
                    encrypted = false;
                }
                else if (data[i] == StuffKey)
                {
                    encrypted = true;
                }
                else
                {
                    original[index++] = data[i];
                }
            }
            return original;
        }
    }
}
