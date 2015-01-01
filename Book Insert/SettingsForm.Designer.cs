namespace BookInsert
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbRFIDSerial = new System.Windows.Forms.ComboBox();
            this.cbCodeSerial = new System.Windows.Forms.ComboBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.apikeyText = new System.Windows.Forms.TextBox();
            this.btnSubmitSetting = new System.Windows.Forms.Button();
            this.btnCancleSetting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbRFIDSerial
            // 
            this.cbRFIDSerial.FormattingEnabled = true;
            this.cbRFIDSerial.Location = new System.Drawing.Point(144, 21);
            this.cbRFIDSerial.Margin = new System.Windows.Forms.Padding(5);
            this.cbRFIDSerial.Name = "cbRFIDSerial";
            this.cbRFIDSerial.Size = new System.Drawing.Size(199, 29);
            this.cbRFIDSerial.TabIndex = 0;
            // 
            // cbCodeSerial
            // 
            this.cbCodeSerial.FormattingEnabled = true;
            this.cbCodeSerial.Location = new System.Drawing.Point(144, 67);
            this.cbCodeSerial.Margin = new System.Windows.Forms.Padding(5);
            this.cbCodeSerial.Name = "cbCodeSerial";
            this.cbCodeSerial.Size = new System.Drawing.Size(199, 29);
            this.cbCodeSerial.TabIndex = 1;
            // 
            // urlText
            // 
            this.urlText.Location = new System.Drawing.Point(24, 161);
            this.urlText.Margin = new System.Windows.Forms.Padding(5);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(319, 29);
            this.urlText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "RFID串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "扫描头串口";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据库API地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "数据库API Key";
            // 
            // apikeyText
            // 
            this.apikeyText.Location = new System.Drawing.Point(24, 230);
            this.apikeyText.Name = "apikeyText";
            this.apikeyText.Size = new System.Drawing.Size(319, 29);
            this.apikeyText.TabIndex = 7;
            // 
            // btnSubmitSetting
            // 
            this.btnSubmitSetting.Location = new System.Drawing.Point(163, 278);
            this.btnSubmitSetting.Name = "btnSubmitSetting";
            this.btnSubmitSetting.Size = new System.Drawing.Size(87, 42);
            this.btnSubmitSetting.TabIndex = 8;
            this.btnSubmitSetting.Text = "确定";
            this.btnSubmitSetting.UseVisualStyleBackColor = true;
            this.btnSubmitSetting.Click += new System.EventHandler(this.btnSubmitSetting_Click);
            // 
            // btnCancleSetting
            // 
            this.btnCancleSetting.Location = new System.Drawing.Point(256, 278);
            this.btnCancleSetting.Name = "btnCancleSetting";
            this.btnCancleSetting.Size = new System.Drawing.Size(87, 42);
            this.btnCancleSetting.TabIndex = 9;
            this.btnCancleSetting.Text = "取消";
            this.btnCancleSetting.UseVisualStyleBackColor = true;
            this.btnCancleSetting.Click += new System.EventHandler(this.btnCancleSetting_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 332);
            this.Controls.Add(this.btnCancleSetting);
            this.Controls.Add(this.btnSubmitSetting);
            this.Controls.Add(this.apikeyText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.cbCodeSerial);
            this.Controls.Add(this.cbRFIDSerial);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SettingsForm";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRFIDSerial;
        private System.Windows.Forms.ComboBox cbCodeSerial;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox apikeyText;
        private System.Windows.Forms.Button btnSubmitSetting;
        private System.Windows.Forms.Button btnCancleSetting;
    }
}