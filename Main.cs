using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPinControl
{
    public partial class Main : Form
    {
        const int LinesToControl = 12;
        SerialPort port = new SerialPort();
        private Queue<byte> incomingData = new Queue<byte>();

        delegate void AppendTextDelegate(string text);

        static string ByteArrayToHexString(byte[] bytes)
        {
            char[] c = new char[bytes.Length * 3];
            int b;
            for (int i = 0; i < bytes.Length; i++)
            {
                b = bytes[i] >> 4;
                c[i * 3] = (char)(55 + b + (((b - 10) >> 31) & -7));
                b = bytes[i] & 0xF;
                c[i * 3 + 1] = (char)(55 + b + (((b - 10) >> 31) & -7));
                c[i * 3 + 2] = ' ';
            }
            return new string(c);
        }
        private void sendPinState()
        {
            if (port.IsOpen)
            {
                byte[] data = new byte[LinesToControl];

                data[0] = Convert.ToByte((true == cbLine2.Checked) ? 255 : 0);
                data[1] = Convert.ToByte((true == cbLine3.Checked) ? 255 : 0);
                data[2] = Convert.ToByte((true == cbLine4.Checked) ? 255 : 0);
                data[3] = Convert.ToByte((true == cbLine5.Checked) ? 255 : 0);
                data[4] = Convert.ToByte((true == cbLine6.Checked) ? 255 : 0);
                data[5] = Convert.ToByte((true == cbLine7.Checked) ? 255 : 0);
                data[6] = Convert.ToByte((true == cbLine8.Checked) ? 255 : 0);
                data[7] = Convert.ToByte((true == cbLine9.Checked) ? 255 : 0);
                data[8] = Convert.ToByte((true == cbLine10.Checked) ? 255 : 0);
                data[9] = Convert.ToByte((true == cbLine11.Checked) ? 255 : 0);
                data[10] = Convert.ToByte((true == cbLine12.Checked) ? 255 : 0);
                data[11] = Convert.ToByte((true == cbLine13.Checked) ? 255 : 0);
                // currently unused analog lines
                //data[12] = Convert.ToByte((true == cbLineA0.Checked)?255:0);
                //data[13] = Convert.ToByte((true == cbLineA1.Checked)?255:0);
                //data[14] = Convert.ToByte((true == cbLineA2.Checked)?255:0);
                //data[15] = Convert.ToByte((true == cbLineA3.Checked)?255:0);
                //data[16] = Convert.ToByte((true == cbLineA4.Checked)?255:0);
                //data[17] = Convert.ToByte((true == cbLineA5.Checked)?255:0);

                port.Write(data, 0, data.Length);
                /*
                string tmp = "";
                foreach (byte d in data)
                {
                    tmp += d + " ";
                }
                MessageBox.Show(tmp);
                */
            }
        }

        private void AppendIncomingText(string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (this.txtIncoming.InvokeRequired)
            {
                AppendTextDelegate d = new AppendTextDelegate(AppendIncomingText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                txtIncoming.AppendText(text);
            }
        }

        private void processIncomingData()
        {
            // Determine if we have a "packet" in the queue
            if (incomingData.Count >= LinesToControl)
            {
                byte[] data = incomingData.ToArray();
                string hex = ByteArrayToHexString(data);
                AppendIncomingText(hex + "\r\n");
            }
        }

        public Main()
        {
            InitializeComponent();
            port.DataReceived += port_DataReceived;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> dictCharBits = new Dictionary<string, int>();
            Dictionary<string, int> dictParity = new Dictionary<string, int>();
            Dictionary<string, int> dictStopBits = new Dictionary<string, int>();


            // Get a list of serial port names. 
            string[] ports = SerialPort.GetPortNames();
            cmbSerialPorts.DataSource = ports;
            cmbBaud.SelectedIndex = 7;

            for (int v = 5; v < 9; ++v)
            {
                dictCharBits.Add(v.ToString(), v);
            }
            cmbCharBits.DataSource = new BindingSource(dictCharBits, null);
            cmbCharBits.DisplayMember = "Key";
            cmbCharBits.ValueMember = "Value";
            cmbCharBits.SelectedIndex = 3;

            foreach (Parity v in Enum.GetValues(typeof(Parity)))
            {
                dictParity.Add(v.ToString(), (int)v);
            }
            cmbParity.DataSource = new BindingSource(dictParity, null);
            cmbParity.DisplayMember = "Key";
            cmbParity.ValueMember = "Value";
            cmbParity.SelectedIndex = 0;

            foreach (StopBits v in Enum.GetValues(typeof(StopBits)))
            {
                dictStopBits.Add(v.ToString(), (int)v);
            }
            cmbStopBits.DataSource = new BindingSource(dictStopBits, null);
            cmbStopBits.DisplayMember = "Key";
            cmbStopBits.ValueMember = "Value";
            cmbStopBits.SelectedIndex = 1;

        }

        void port_DataReceived(object s, SerialDataReceivedEventArgs e)
        {
            byte[] data = new byte[port.BytesToRead];
            port.Read(data, 0, data.Length);
            data.ToList().ForEach(b => incomingData.Enqueue(b));
            processIncomingData();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            if (cmbSerialPorts.SelectedIndex >= 0)
            {
                if (!port.IsOpen)
                {
                    port.PortName = cmbSerialPorts.SelectedItem.ToString();
                    port.BaudRate = Convert.ToInt32(cmbBaud.SelectedItem.ToString());
                    port.DataBits = (int)cmbCharBits.SelectedValue;
                    port.Parity = (Parity)cmbParity.SelectedValue;
                    port.StopBits = (StopBits)cmbStopBits.SelectedValue;
                    port.Open();
                    cmdConnect.Text = "Disconnect";
                    sendPinState();
                }
                else
                {
                    port.Close();
                    cmdConnect.Text = "Connect";
                }
            }
        }


        private void cbLine_CheckedChanged(object sender, EventArgs e)
        {
            sendPinState();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtIncoming_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
