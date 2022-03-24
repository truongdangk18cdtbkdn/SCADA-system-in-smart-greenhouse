namespace Mitsu_SCADA_WINFORM_v6
{
    partial class CSDL
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
            this.grbSQLServer = new System.Windows.Forms.GroupBox();
            this.btnSaveDataName = new System.Windows.Forms.Button();
            this.btnEditDataName = new System.Windows.Forms.Button();
            this.tbxDBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.grbSQLServer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSQLServer
            // 
            this.grbSQLServer.BackColor = System.Drawing.Color.Gray;
            this.grbSQLServer.Controls.Add(this.btnSaveDataName);
            this.grbSQLServer.Controls.Add(this.btnEditDataName);
            this.grbSQLServer.Controls.Add(this.tbxDBName);
            this.grbSQLServer.Controls.Add(this.label1);
            this.grbSQLServer.Location = new System.Drawing.Point(12, 12);
            this.grbSQLServer.Name = "grbSQLServer";
            this.grbSQLServer.Size = new System.Drawing.Size(366, 125);
            this.grbSQLServer.TabIndex = 0;
            this.grbSQLServer.TabStop = false;
            this.grbSQLServer.Text = "SQL Server";
            // 
            // btnSaveDataName
            // 
            this.btnSaveDataName.Enabled = false;
            this.btnSaveDataName.Location = new System.Drawing.Point(130, 80);
            this.btnSaveDataName.Name = "btnSaveDataName";
            this.btnSaveDataName.Size = new System.Drawing.Size(86, 31);
            this.btnSaveDataName.TabIndex = 3;
            this.btnSaveDataName.Text = "Save";
            this.btnSaveDataName.UseVisualStyleBackColor = true;
            this.btnSaveDataName.Click += new System.EventHandler(this.btnSaveDataName_Click);
            // 
            // btnEditDataName
            // 
            this.btnEditDataName.Location = new System.Drawing.Point(38, 80);
            this.btnEditDataName.Name = "btnEditDataName";
            this.btnEditDataName.Size = new System.Drawing.Size(86, 31);
            this.btnEditDataName.TabIndex = 2;
            this.btnEditDataName.Text = "Edit";
            this.btnEditDataName.UseVisualStyleBackColor = true;
            this.btnEditDataName.Click += new System.EventHandler(this.btnEditDataName_Click);
            // 
            // tbxDBName
            // 
            this.tbxDBName.Enabled = false;
            this.tbxDBName.Location = new System.Drawing.Point(38, 50);
            this.tbxDBName.Name = "tbxDBName";
            this.tbxDBName.Size = new System.Drawing.Size(259, 24);
            this.tbxDBName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Name:";
            // 
            // btnShowData
            // 
            this.btnShowData.Location = new System.Drawing.Point(12, 143);
            this.btnShowData.Name = "btnShowData";
            this.btnShowData.Size = new System.Drawing.Size(124, 31);
            this.btnShowData.TabIndex = 4;
            this.btnShowData.Text = "Show Data";
            this.btnShowData.UseVisualStyleBackColor = true;
            this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 183);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1511, 558);
            this.dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(607, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 24);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(754, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 24);
            this.textBox3.TabIndex = 7;
            // 
            // CSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1584, 847);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowData);
            this.Controls.Add(this.grbSQLServer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Name = "CSDL";
            this.Text = "Data Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CSDL_Load);
            this.grbSQLServer.ResumeLayout(false);
            this.grbSQLServer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSQLServer;
        private System.Windows.Forms.Button btnSaveDataName;
        private System.Windows.Forms.Button btnEditDataName;
        private System.Windows.Forms.TextBox tbxDBName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}