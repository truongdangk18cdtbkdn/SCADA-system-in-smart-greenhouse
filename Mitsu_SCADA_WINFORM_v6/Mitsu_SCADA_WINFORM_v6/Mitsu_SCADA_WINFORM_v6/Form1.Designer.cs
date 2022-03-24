namespace Mitsu_SCADA_WINFORM_v6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnData = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnGreenhouse2 = new System.Windows.Forms.Button();
            this.btnGreenhouse1 = new System.Windows.Forms.Button();
            this.btnSystemSetting = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.timerWatchdog = new System.Windows.Forms.Timer(this.components);
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panelTop.Controls.Add(this.btnLoginLogout);
            this.panelTop.Controls.Add(this.btnData);
            this.panelTop.Controls.Add(this.btnConnect);
            this.panelTop.Controls.Add(this.btnDisconnect);
            this.panelTop.Controls.Add(this.btnGreenhouse2);
            this.panelTop.Controls.Add(this.btnGreenhouse1);
            this.panelTop.Controls.Add(this.btnSystemSetting);
            this.panelTop.Controls.Add(this.btnHomePage);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1598, 42);
            this.panelTop.TabIndex = 2;
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnData.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnData.FlatAppearance.BorderSize = 0;
            this.btnData.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Image = ((System.Drawing.Image)(resources.GetObject("btnData.Image")));
            this.btnData.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnData.Location = new System.Drawing.Point(722, 0);
            this.btnData.Margin = new System.Windows.Forms.Padding(0);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(192, 42);
            this.btnData.TabIndex = 12;
            this.btnData.Text = "Parameter Data";
            this.btnData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnConnect.Location = new System.Drawing.Point(1285, 0);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(140, 42);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDisconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisconnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Image = ((System.Drawing.Image)(resources.GetObject("btnDisconnect.Image")));
            this.btnDisconnect.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnDisconnect.Location = new System.Drawing.Point(1425, 0);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(0);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(173, 42);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "DISCONNECT";
            this.btnDisconnect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnGreenhouse2
            // 
            this.btnGreenhouse2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGreenhouse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGreenhouse2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreenhouse2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGreenhouse2.FlatAppearance.BorderSize = 0;
            this.btnGreenhouse2.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenhouse2.ForeColor = System.Drawing.Color.White;
            this.btnGreenhouse2.Image = ((System.Drawing.Image)(resources.GetObject("btnGreenhouse2.Image")));
            this.btnGreenhouse2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGreenhouse2.Location = new System.Drawing.Point(527, 0);
            this.btnGreenhouse2.Margin = new System.Windows.Forms.Padding(0);
            this.btnGreenhouse2.Name = "btnGreenhouse2";
            this.btnGreenhouse2.Size = new System.Drawing.Size(195, 42);
            this.btnGreenhouse2.TabIndex = 8;
            this.btnGreenhouse2.Text = "Greenhouse [2]";
            this.btnGreenhouse2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenhouse2.UseVisualStyleBackColor = false;
            this.btnGreenhouse2.Click += new System.EventHandler(this.btnGreenhouse2_Click);
            // 
            // btnGreenhouse1
            // 
            this.btnGreenhouse1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGreenhouse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGreenhouse1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreenhouse1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGreenhouse1.FlatAppearance.BorderSize = 0;
            this.btnGreenhouse1.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreenhouse1.ForeColor = System.Drawing.Color.White;
            this.btnGreenhouse1.Image = ((System.Drawing.Image)(resources.GetObject("btnGreenhouse1.Image")));
            this.btnGreenhouse1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnGreenhouse1.Location = new System.Drawing.Point(332, 0);
            this.btnGreenhouse1.Margin = new System.Windows.Forms.Padding(0);
            this.btnGreenhouse1.Name = "btnGreenhouse1";
            this.btnGreenhouse1.Size = new System.Drawing.Size(195, 42);
            this.btnGreenhouse1.TabIndex = 7;
            this.btnGreenhouse1.Text = "Greenhouse [1]";
            this.btnGreenhouse1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGreenhouse1.UseVisualStyleBackColor = false;
            this.btnGreenhouse1.Click += new System.EventHandler(this.btnGreenhouse1_Click);
            // 
            // btnSystemSetting
            // 
            this.btnSystemSetting.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnSystemSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSystemSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSystemSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSystemSetting.FlatAppearance.BorderSize = 0;
            this.btnSystemSetting.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemSetting.ForeColor = System.Drawing.Color.White;
            this.btnSystemSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSystemSetting.Image")));
            this.btnSystemSetting.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSystemSetting.Location = new System.Drawing.Point(150, 0);
            this.btnSystemSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSystemSetting.Name = "btnSystemSetting";
            this.btnSystemSetting.Size = new System.Drawing.Size(182, 42);
            this.btnSystemSetting.TabIndex = 6;
            this.btnSystemSetting.Text = "System Setting";
            this.btnSystemSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSystemSetting.UseVisualStyleBackColor = false;
            // 
            // btnHomePage
            // 
            this.btnHomePage.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHomePage.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHomePage.FlatAppearance.BorderSize = 0;
            this.btnHomePage.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.ForeColor = System.Drawing.Color.White;
            this.btnHomePage.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.Image")));
            this.btnHomePage.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnHomePage.Location = new System.Drawing.Point(0, 0);
            this.btnHomePage.Margin = new System.Windows.Forms.Padding(0);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(150, 42);
            this.btnHomePage.TabIndex = 5;
            this.btnHomePage.Text = "Home Page";
            this.btnHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHomePage.UseVisualStyleBackColor = false;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 40);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1598, 759);
            this.mainPanel.TabIndex = 3;
            // 
            // timerWatchdog
            // 
            this.timerWatchdog.Enabled = true;
            this.timerWatchdog.Interval = 2000;
            this.timerWatchdog.Tick += new System.EventHandler(this.timerWatchdog_Tick);
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLoginLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoginLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoginLogout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoginLogout.FlatAppearance.BorderSize = 0;
            this.btnLoginLogout.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginLogout.ForeColor = System.Drawing.Color.White;
            this.btnLoginLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLoginLogout.Image")));
            this.btnLoginLogout.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnLoginLogout.Location = new System.Drawing.Point(914, 0);
            this.btnLoginLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(181, 42);
            this.btnLoginLogout.TabIndex = 13;
            this.btnLoginLogout.Text = "Login/Logout";
            this.btnLoginLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoginLogout.UseVisualStyleBackColor = false;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1598, 852);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "Form1";
            this.Text = "SMART GREENHOUSE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Button btnGreenhouse2;
        public System.Windows.Forms.Button btnGreenhouse1;
        public System.Windows.Forms.Button btnSystemSetting;
        public System.Windows.Forms.Button btnHomePage;
        public System.Windows.Forms.Button btnDisconnect;
        public System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.Timer timerWatchdog;
        public System.Windows.Forms.Button btnData;
        public System.Windows.Forms.Button btnLoginLogout;
    }
}

