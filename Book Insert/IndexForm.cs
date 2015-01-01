using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLibrary;

namespace BookInsert
{
    public partial class IndexForm : Form
    {

        private string RFIDSerial;
        private string codeSerial;
        private string apiUrl;
        private string apiKey;

        public IndexForm()
        {
            InitializeComponent();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.Show();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            IniFile ini = new IniFile("config.ini");
            this.RFIDSerial = ini.IniReadValue("COM", "RFID");
            this.codeSerial = ini.IniReadValue("COM", "codeReader");
            this.apiUrl = ini.IniReadValue("API", "URL");
            this.apiKey = ini.IniReadValue("API", "API Key");

            if(RFIDSerial.Length == 0 || codeSerial.Length == 0 || apiUrl.Length == 0 || apiKey.Length == 0)
            {
                SettingsForm frm = new SettingsForm();
                frm.Show();
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
