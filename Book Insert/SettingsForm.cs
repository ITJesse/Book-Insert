using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using ToolsLibrary;

namespace BookInsert
{
    public partial class SettingsForm : Form
    {
        private string RFIDSerial;
        private string codeSerial;
        private string apiUrl;
        private string apiKey;

        private SerialPort SerialPort = new SerialPort(); 

        public SettingsForm(string RFIDSerial, string codeSerial, string apiUrl, string apiKey)
        {
            this.RFIDSerial = RFIDSerial;
            this.codeSerial = codeSerial;
            this.apiUrl = apiUrl;
            this.apiKey = apiKey;
            InitializeComponent();
        }

        public SettingsForm()
        {
            this.RFIDSerial = "";
            this.codeSerial = "";
            this.apiUrl = "";
            this.apiKey = "";
            InitializeComponent();
        }

        private void btnSubmitSetting_Click(object sender, EventArgs e)
        {
            this.RFIDSerial = cbRFIDSerial.Text;
            this.codeSerial = cbCodeSerial.Text;
            this.apiUrl = urlText.Text;
            this.apiKey = apikeyText.Text;

            IniFile ini = new IniFile("config.ini");
            uint err = ini.IniWriteValue("COM", "RFID", this.RFIDSerial);
            MessageBox.Show(err.ToString(), "Error");
            
            ini.IniWriteValue("COM", "codeReader", this.codeSerial);
            ini.IniWriteValue("API", "URL", this.apiUrl);
            ini.IniWriteValue("API", "API Key", this.apiKey);

            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //检查是否含有串口
            string[] str = SerialPort.GetPortNames();
            if (str.Length == 0)
            {
                MessageBox.Show("本机没有串口！", "Error");
                Application.Exit();
                return;
            }

            //添加串口项目
            foreach (string s in SerialPort.GetPortNames())
            {
                //获取有多少个COM口
                cbRFIDSerial.Items.Add(s);
                cbCodeSerial.Items.Add(s);
            }

            //串口设置默认选择项
            cbRFIDSerial.SelectedIndex = cbRFIDSerial.Items.IndexOf(RFIDSerial);
            cbCodeSerial.SelectedIndex = cbCodeSerial.Items.IndexOf(codeSerial);

        }

        private void btnCancleSetting_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
