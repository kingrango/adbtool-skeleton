namespace ADBTOOL
{
    partial class Form1
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
            this.buttonCheckDevice = new System.Windows.Forms.Button();
            this.buttonRebootFastboot = new System.Windows.Forms.Button();
            this.buttonUnlockBootloader = new System.Windows.Forms.Button();
            this.buttonReadInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheckDevice
            // 
            this.buttonCheckDevice.Location = new System.Drawing.Point(57, 87);
            this.buttonCheckDevice.Name = "buttonCheckDevice";
            this.buttonCheckDevice.Size = new System.Drawing.Size(113, 23);
            this.buttonCheckDevice.TabIndex = 0;
            this.buttonCheckDevice.Text = "Check Devices";
            this.buttonCheckDevice.UseVisualStyleBackColor = true;
            this.buttonCheckDevice.Click += new System.EventHandler(this.buttonCheckDevice_Click);
            // 
            // buttonRebootFastboot
            // 
            this.buttonRebootFastboot.Location = new System.Drawing.Point(57, 132);
            this.buttonRebootFastboot.Name = "buttonRebootFastboot";
            this.buttonRebootFastboot.Size = new System.Drawing.Size(113, 23);
            this.buttonRebootFastboot.TabIndex = 1;
            this.buttonRebootFastboot.Text = "Reboot FastBoot";
            this.buttonRebootFastboot.UseVisualStyleBackColor = true;
            this.buttonRebootFastboot.Click += new System.EventHandler(this.buttonRebootFastboot_Click);
            // 
            // buttonUnlockBootloader
            // 
            this.buttonUnlockBootloader.Location = new System.Drawing.Point(57, 175);
            this.buttonUnlockBootloader.Name = "buttonUnlockBootloader";
            this.buttonUnlockBootloader.Size = new System.Drawing.Size(113, 23);
            this.buttonUnlockBootloader.TabIndex = 2;
            this.buttonUnlockBootloader.Text = "Unlock Bootloader";
            this.buttonUnlockBootloader.UseVisualStyleBackColor = true;
            this.buttonUnlockBootloader.Click += new System.EventHandler(this.buttonUnlockBootloader_Click);
            // 
            // buttonReadInfo
            // 
            this.buttonReadInfo.Location = new System.Drawing.Point(57, 216);
            this.buttonReadInfo.Name = "buttonReadInfo";
            this.buttonReadInfo.Size = new System.Drawing.Size(113, 23);
            this.buttonReadInfo.TabIndex = 3;
            this.buttonReadInfo.Text = "Device Info";
            this.buttonReadInfo.UseVisualStyleBackColor = true;
            this.buttonReadInfo.Click += new System.EventHandler(this.buttonReadInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxConsole);
            this.groupBox1.Location = new System.Drawing.Point(309, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 395);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logs";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(6, 19);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(318, 370);
            this.textBoxConsole.TabIndex = 0;
            this.textBoxConsole.TextChanged += new System.EventHandler(this.textBoxConsole_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReadInfo);
            this.Controls.Add(this.buttonUnlockBootloader);
            this.Controls.Add(this.buttonRebootFastboot);
            this.Controls.Add(this.buttonCheckDevice);
            this.Name = "Form1";
            this.Text = "Rango ADB Tool V1.0.0.0 [ experimental research design ]";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckDevice;
        private System.Windows.Forms.Button buttonRebootFastboot;
        private System.Windows.Forms.Button buttonUnlockBootloader;
        private System.Windows.Forms.Button buttonReadInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxConsole;
    }
}

