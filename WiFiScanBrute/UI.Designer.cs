namespace WiFiScanBrute
{
    partial class UI
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
            this.dataGridView_networks = new System.Windows.Forms.DataGridView();
            this.SSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AuthAlgo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignalQuality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_scan = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_status = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_networks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_networks
            // 
            this.dataGridView_networks.AllowUserToAddRows = false;
            this.dataGridView_networks.AllowUserToDeleteRows = false;
            this.dataGridView_networks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_networks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_networks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SSID,
            this.AuthAlgo,
            this.SignalQuality});
            this.dataGridView_networks.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_networks.MultiSelect = false;
            this.dataGridView_networks.Name = "dataGridView_networks";
            this.dataGridView_networks.RowHeadersVisible = false;
            this.dataGridView_networks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_networks.Size = new System.Drawing.Size(507, 404);
            this.dataGridView_networks.TabIndex = 0;
            // 
            // SSID
            // 
            this.SSID.HeaderText = "SSID";
            this.SSID.Name = "SSID";
            this.SSID.ReadOnly = true;
            this.SSID.Width = 300;
            // 
            // AuthAlgo
            // 
            this.AuthAlgo.HeaderText = "AuthType";
            this.AuthAlgo.Name = "AuthAlgo";
            this.AuthAlgo.ReadOnly = true;
            // 
            // SignalQuality
            // 
            this.SignalQuality.HeaderText = "SignalQuality";
            this.SignalQuality.Name = "SignalQuality";
            // 
            // button_scan
            // 
            this.button_scan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_scan.Location = new System.Drawing.Point(525, 12);
            this.button_scan.Name = "button_scan";
            this.button_scan.Size = new System.Drawing.Size(232, 23);
            this.button_scan.TabIndex = 1;
            this.button_scan.Text = "Сканировать";
            this.button_scan.UseVisualStyleBackColor = true;
            this.button_scan.Click += new System.EventHandler(this.button_scan_Click);
            // 
            // button_connect
            // 
            this.button_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_connect.Location = new System.Drawing.Point(525, 91);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(232, 23);
            this.button_connect.TabIndex = 2;
            this.button_connect.Text = "Подключиться";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // textBox_password
            // 
            this.textBox_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_password.Location = new System.Drawing.Point(526, 63);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(231, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(525, 153);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(43, 13);
            this.label_status.TabIndex = 4;
            this.label_status.Text = "Status: ";
            // 
            // button_disconnect
            // 
            this.button_disconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_disconnect.Location = new System.Drawing.Point(525, 120);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(232, 23);
            this.button_disconnect.TabIndex = 5;
            this.button_disconnect.Text = "Отключиться";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.button_scan);
            this.Controls.Add(this.dataGridView_networks);
            this.Name = "UI";
            this.Text = "WiFi Scan Brute";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_networks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_networks;
        private System.Windows.Forms.Button button_scan;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AuthAlgo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignalQuality;
        private System.Windows.Forms.Label label1;
    }
}

