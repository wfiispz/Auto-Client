namespace AutoClientApplication {
    partial class AutoClientForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.resultsTextBox = new System.Windows.Forms.RichTextBox();
            this.topButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMonitor = new System.Windows.Forms.Button();
            this.monitorsGridView = new System.Windows.Forms.DataGridView();
            this.MonitorIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SaveMonitorFile = new System.Windows.Forms.Button();
            this.OpenMonitorFile = new System.Windows.Forms.Button();
            this.clearMonitorsButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.loadMonitorsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.TextBox();
            this.clearLogsButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rateValueLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.top10Machines = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Measurements = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top10Machines)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsTextBox.Location = new System.Drawing.Point(12, 767);
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.Size = new System.Drawing.Size(798, 152);
            this.resultsTextBox.TabIndex = 1;
            this.resultsTextBox.Text = "";
            // 
            // topButton
            // 
            this.topButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.topButton.Location = new System.Drawing.Point(251, 54);
            this.topButton.Name = "topButton";
            this.topButton.Size = new System.Drawing.Size(248, 24);
            this.topButton.TabIndex = 3;
            this.topButton.Text = "Show Top10 Overload Machines";
            this.topButton.UseVisualStyleBackColor = true;
            this.topButton.Click += new System.EventHandler(this.TopButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 748);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(33, 13);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Logs:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(28, 15);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(173, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start Application";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(298, 15);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(201, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop Application";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.addMonitor);
            this.panel1.Controls.Add(this.monitorsGridView);
            this.panel1.Controls.Add(this.SaveMonitorFile);
            this.panel1.Controls.Add(this.OpenMonitorFile);
            this.panel1.Controls.Add(this.clearMonitorsButton);
            this.panel1.Controls.Add(this.restartButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.loadMonitorsButton);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.directoryLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 368);
            this.panel1.TabIndex = 7;
            // 
            // addMonitor
            // 
            this.addMonitor.Location = new System.Drawing.Point(479, 189);
            this.addMonitor.Name = "addMonitor";
            this.addMonitor.Size = new System.Drawing.Size(116, 23);
            this.addMonitor.TabIndex = 40;
            this.addMonitor.Text = "Add new monitor";
            this.addMonitor.UseVisualStyleBackColor = true;
            this.addMonitor.Click += new System.EventHandler(this.AddMonitor_Click);
            // 
            // monitorsGridView
            // 
            this.monitorsGridView.AllowUserToAddRows = false;
            this.monitorsGridView.AllowUserToDeleteRows = false;
            this.monitorsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monitorsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.monitorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonitorIndex,
            this.MonitorAddress,
            this.MonitorDelete});
            this.monitorsGridView.Location = new System.Drawing.Point(10, 218);
            this.monitorsGridView.Name = "monitorsGridView";
            this.monitorsGridView.RowTemplate.Height = 40;
            this.monitorsGridView.Size = new System.Drawing.Size(772, 134);
            this.monitorsGridView.TabIndex = 39;
            this.monitorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MonitorsGridView_CellContentClick_1);
            // 
            // MonitorIndex
            // 
            this.MonitorIndex.HeaderText = "Index";
            this.MonitorIndex.Name = "MonitorIndex";
            this.MonitorIndex.ReadOnly = true;
            this.MonitorIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MonitorIndex.Width = 60;
            // 
            // MonitorAddress
            // 
            this.MonitorAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MonitorAddress.HeaderText = "Monitor Address";
            this.MonitorAddress.Name = "MonitorAddress";
            this.MonitorAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MonitorAddress.Width = 599;
            // 
            // MonitorDelete
            // 
            this.MonitorDelete.HeaderText = "Delete";
            this.MonitorDelete.Name = "MonitorDelete";
            this.MonitorDelete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MonitorDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.MonitorDelete.Width = 50;
            // 
            // SaveMonitorFile
            // 
            this.SaveMonitorFile.Location = new System.Drawing.Point(222, 189);
            this.SaveMonitorFile.Name = "SaveMonitorFile";
            this.SaveMonitorFile.Size = new System.Drawing.Size(196, 23);
            this.SaveMonitorFile.TabIndex = 37;
            this.SaveMonitorFile.Text = "Save monitors to different file";
            this.SaveMonitorFile.UseVisualStyleBackColor = true;
            this.SaveMonitorFile.Click += new System.EventHandler(this.SaveMonitorFile_Click_1);
            // 
            // OpenMonitorFile
            // 
            this.OpenMonitorFile.Location = new System.Drawing.Point(418, 120);
            this.OpenMonitorFile.Name = "OpenMonitorFile";
            this.OpenMonitorFile.Size = new System.Drawing.Size(260, 23);
            this.OpenMonitorFile.TabIndex = 36;
            this.OpenMonitorFile.Text = "Open different monitor file";
            this.OpenMonitorFile.UseVisualStyleBackColor = true;
            this.OpenMonitorFile.Click += new System.EventHandler(this.OpenMonitorFile_Click);
            // 
            // clearMonitorsButton
            // 
            this.clearMonitorsButton.Location = new System.Drawing.Point(666, 189);
            this.clearMonitorsButton.Name = "clearMonitorsButton";
            this.clearMonitorsButton.Size = new System.Drawing.Size(116, 23);
            this.clearMonitorsButton.TabIndex = 35;
            this.clearMonitorsButton.Text = "Clear monitors";
            this.clearMonitorsButton.UseVisualStyleBackColor = true;
            this.clearMonitorsButton.Click += new System.EventHandler(this.ClearMonitorsButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(590, 15);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(192, 23);
            this.restartButton.TabIndex = 34;
            this.restartButton.Text = "Restart Application";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Monitors addresses:";
            // 
            // loadMonitorsButton
            // 
            this.loadMonitorsButton.Location = new System.Drawing.Point(94, 120);
            this.loadMonitorsButton.Name = "loadMonitorsButton";
            this.loadMonitorsButton.Size = new System.Drawing.Size(249, 23);
            this.loadMonitorsButton.TabIndex = 31;
            this.loadMonitorsButton.Text = "Load monitors from directory";
            this.loadMonitorsButton.UseVisualStyleBackColor = true;
            this.loadMonitorsButton.Click += new System.EventHandler(this.LoadMonitorsFileButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Directory of monitor file:";
            // 
            // directoryLabel
            // 
            this.directoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.directoryLabel.Location = new System.Drawing.Point(138, 66);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(644, 20);
            this.directoryLabel.TabIndex = 30;
            this.directoryLabel.Text = "directory";
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.Location = new System.Drawing.Point(735, 738);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogsButton.TabIndex = 8;
            this.clearLogsButton.Text = "Clear Logs";
            this.clearLogsButton.UseVisualStyleBackColor = true;
            this.clearLogsButton.Click += new System.EventHandler(this.ClearLogsButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(94, 3);
            this.trackBar1.Maximum = 21600;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(626, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Top refresh rate:";
            // 
            // rateValueLabel
            // 
            this.rateValueLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rateValueLabel.AutoSize = true;
            this.rateValueLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rateValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rateValueLabel.Location = new System.Drawing.Point(721, 13);
            this.rateValueLabel.Name = "rateValueLabel";
            this.rateValueLabel.Size = new System.Drawing.Size(32, 15);
            this.rateValueLabel.TabIndex = 37;
            this.rateValueLabel.Text = "Rate";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.top10Machines);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.topButton);
            this.panel2.Controls.Add(this.rateValueLabel);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Location = new System.Drawing.Point(12, 386);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 332);
            this.panel2.TabIndex = 38;
            // 
            // top10Machines
            // 
            this.top10Machines.AllowUserToAddRows = false;
            this.top10Machines.AllowUserToDeleteRows = false;
            this.top10Machines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top10Machines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.top10Machines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.Id,
            this.Description,
            this.Measurements,
            this.Value});
            this.top10Machines.Location = new System.Drawing.Point(10, 96);
            this.top10Machines.Name = "top10Machines";
            this.top10Machines.RowTemplate.Height = 40;
            this.top10Machines.Size = new System.Drawing.Size(772, 229);
            this.top10Machines.TabIndex = 38;
            // 
            // Index
            // 
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Index.Width = 50;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Id.Width = 69;
            // 
            // Description
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.DefaultCellStyle = dataGridViewCellStyle2;
            this.Description.FillWeight = 120F;
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 400;
            // 
            // Measurements
            // 
            this.Measurements.HeaderText = "Measurements";
            this.Measurements.Name = "Measurements";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 110;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "NewMonitorFile";
            // 
            // AutoClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 931);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clearLogsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.resultsTextBox);
            this.MaximumSize = new System.Drawing.Size(838, 970);
            this.MinimumSize = new System.Drawing.Size(837, 970);
            this.Name = "AutoClientForm";
            this.Text = "AutoClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.top10Machines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultsTextBox;
        private System.Windows.Forms.Button topButton;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clearLogsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox directoryLabel;
        private System.Windows.Forms.Button loadMonitorsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button clearMonitorsButton;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rateValueLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView top10Machines;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Measurements;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Button OpenMonitorFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveMonitorFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView monitorsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorAddress;
        private System.Windows.Forms.DataGridViewButtonColumn MonitorDelete;
        private System.Windows.Forms.Button addMonitor;
    }
}

