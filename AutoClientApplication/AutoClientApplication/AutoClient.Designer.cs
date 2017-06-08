namespace AutoClientApplication {
    partial class AutoClient {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.logsTextBox = new System.Windows.Forms.RichTextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addMonitor = new System.Windows.Forms.Button();
            this.monitorsGridView = new System.Windows.Forms.DataGridView();
            this.MonitorIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonitorPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.refreshRateTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.rateValueLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveTopButton = new System.Windows.Forms.Button();
            this.numberOfTopLabel = new System.Windows.Forms.Label();
            this.numberOfTopElementsTrackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.lastUpdateTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.top10Machines = new System.Windows.Forms.DataGridView();
            this.TopIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopHost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopMetric = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopBiggestValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopMaxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopProcentageValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveLogsButton = new System.Windows.Forms.Button();
            this.logsWindowsTextBox = new System.Windows.Forms.RichTextBox();
            this.LogsWindow = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateTrackBar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTopElementsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10Machines)).BeginInit();
            this.SuspendLayout();
            // 
            // logsTextBox
            // 
            this.logsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logsTextBox.Location = new System.Drawing.Point(15, 757);
            this.logsTextBox.Name = "logsTextBox";
            this.logsTextBox.ReadOnly = true;
            this.logsTextBox.Size = new System.Drawing.Size(798, 0);
            this.logsTextBox.TabIndex = 1;
            this.logsTextBox.Text = "";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(12, 738);
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
            this.panel1.Size = new System.Drawing.Size(799, 334);
            this.panel1.TabIndex = 7;
            // 
            // addMonitor
            // 
            this.addMonitor.Location = new System.Drawing.Point(479, 156);
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
            this.MonitorUser,
            this.MonitorPassword,
            this.MonitorDelete});
            this.monitorsGridView.Location = new System.Drawing.Point(18, 185);
            this.monitorsGridView.Name = "monitorsGridView";
            this.monitorsGridView.RowTemplate.Height = 40;
            this.monitorsGridView.Size = new System.Drawing.Size(772, 142);
            this.monitorsGridView.TabIndex = 39;
            this.monitorsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MonitorsGridView_CellContentClick_1);
            // 
            // MonitorIndex
            // 
            this.MonitorIndex.HeaderText = "Index";
            this.MonitorIndex.Name = "MonitorIndex";
            this.MonitorIndex.ReadOnly = true;
            this.MonitorIndex.Width = 60;
            // 
            // MonitorAddress
            // 
            this.MonitorAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MonitorAddress.HeaderText = "Monitor Address";
            this.MonitorAddress.Name = "MonitorAddress";
            this.MonitorAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MonitorAddress.Width = 399;
            // 
            // MonitorUser
            // 
            this.MonitorUser.HeaderText = "User";
            this.MonitorUser.Name = "MonitorUser";
            // 
            // MonitorPassword
            // 
            this.MonitorPassword.HeaderText = "Password";
            this.MonitorPassword.Name = "MonitorPassword";
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
            this.SaveMonitorFile.Location = new System.Drawing.Point(213, 156);
            this.SaveMonitorFile.Name = "SaveMonitorFile";
            this.SaveMonitorFile.Size = new System.Drawing.Size(196, 23);
            this.SaveMonitorFile.TabIndex = 37;
            this.SaveMonitorFile.Text = "Save monitors to different file";
            this.SaveMonitorFile.UseVisualStyleBackColor = true;
            this.SaveMonitorFile.Click += new System.EventHandler(this.SaveMonitorFile_Click_1);
            // 
            // OpenMonitorFile
            // 
            this.OpenMonitorFile.Location = new System.Drawing.Point(418, 111);
            this.OpenMonitorFile.Name = "OpenMonitorFile";
            this.OpenMonitorFile.Size = new System.Drawing.Size(260, 23);
            this.OpenMonitorFile.TabIndex = 36;
            this.OpenMonitorFile.Text = "Open different monitor file";
            this.OpenMonitorFile.UseVisualStyleBackColor = true;
            this.OpenMonitorFile.Click += new System.EventHandler(this.OpenMonitorFile_Click);
            // 
            // clearMonitorsButton
            // 
            this.clearMonitorsButton.Location = new System.Drawing.Point(649, 156);
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
            this.restartButton.Text = "Assign Default Values";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Monitors addresses:";
            // 
            // loadMonitorsButton
            // 
            this.loadMonitorsButton.Location = new System.Drawing.Point(99, 111);
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
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Directory of monitor file:";
            // 
            // directoryLabel
            // 
            this.directoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.directoryLabel.Location = new System.Drawing.Point(138, 53);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(644, 20);
            this.directoryLabel.TabIndex = 30;
            this.directoryLabel.Text = "directory";
            // 
            // clearLogsButton
            // 
            this.clearLogsButton.Location = new System.Drawing.Point(721, 633);
            this.clearLogsButton.Name = "clearLogsButton";
            this.clearLogsButton.Size = new System.Drawing.Size(75, 23);
            this.clearLogsButton.TabIndex = 8;
            this.clearLogsButton.Text = "Clear Logs";
            this.clearLogsButton.UseVisualStyleBackColor = true;
            this.clearLogsButton.Click += new System.EventHandler(this.ClearLogsButton_Click);
            // 
            // refreshRateTrackBar
            // 
            this.refreshRateTrackBar.Location = new System.Drawing.Point(99, 5);
            this.refreshRateTrackBar.Maximum = 21600;
            this.refreshRateTrackBar.Minimum = 10;
            this.refreshRateTrackBar.Name = "refreshRateTrackBar";
            this.refreshRateTrackBar.Size = new System.Drawing.Size(639, 45);
            this.refreshRateTrackBar.TabIndex = 9;
            this.refreshRateTrackBar.Value = 60;
            this.refreshRateTrackBar.Scroll += new System.EventHandler(this.RefreshRateTackBarOnValueChange);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 5);
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
            this.rateValueLabel.Location = new System.Drawing.Point(744, 5);
            this.rateValueLabel.Name = "rateValueLabel";
            this.rateValueLabel.Size = new System.Drawing.Size(27, 15);
            this.rateValueLabel.TabIndex = 37;
            this.rateValueLabel.Text = "rate";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.SaveTopButton);
            this.panel2.Controls.Add(this.numberOfTopLabel);
            this.panel2.Controls.Add(this.numberOfTopElementsTrackBar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lastUpdateTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.top10Machines);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rateValueLabel);
            this.panel2.Controls.Add(this.refreshRateTrackBar);
            this.panel2.Location = new System.Drawing.Point(12, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(798, 267);
            this.panel2.TabIndex = 38;
            // 
            // SaveTopButton
            // 
            this.SaveTopButton.Location = new System.Drawing.Point(683, 78);
            this.SaveTopButton.Name = "SaveTopButton";
            this.SaveTopButton.Size = new System.Drawing.Size(99, 23);
            this.SaveTopButton.TabIndex = 45;
            this.SaveTopButton.Text = "Save Top to file";
            this.SaveTopButton.UseVisualStyleBackColor = true;
            this.SaveTopButton.Click += new System.EventHandler(this.SaveTopButton_Click);
            // 
            // numberOfTopLabel
            // 
            this.numberOfTopLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numberOfTopLabel.AutoSize = true;
            this.numberOfTopLabel.BackColor = System.Drawing.SystemColors.Control;
            this.numberOfTopLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.numberOfTopLabel.Location = new System.Drawing.Point(744, 33);
            this.numberOfTopLabel.Name = "numberOfTopLabel";
            this.numberOfTopLabel.Size = new System.Drawing.Size(21, 15);
            this.numberOfTopLabel.TabIndex = 44;
            this.numberOfTopLabel.Text = "10";
            // 
            // numberOfTopElementsTrackBar
            // 
            this.numberOfTopElementsTrackBar.Location = new System.Drawing.Point(99, 27);
            this.numberOfTopElementsTrackBar.Maximum = 1000;
            this.numberOfTopElementsTrackBar.Minimum = 1;
            this.numberOfTopElementsTrackBar.Name = "numberOfTopElementsTrackBar";
            this.numberOfTopElementsTrackBar.Size = new System.Drawing.Size(639, 45);
            this.numberOfTopElementsTrackBar.TabIndex = 43;
            this.numberOfTopElementsTrackBar.Value = 10;
            this.numberOfTopElementsTrackBar.Scroll += new System.EventHandler(this.NumberOfTopElements);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Number of Top:";
            // 
            // lastUpdateTime
            // 
            this.lastUpdateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastUpdateTime.AutoSize = true;
            this.lastUpdateTime.Location = new System.Drawing.Point(415, 73);
            this.lastUpdateTime.Name = "lastUpdateTime";
            this.lastUpdateTime.Size = new System.Drawing.Size(87, 13);
            this.lastUpdateTime.TabIndex = 41;
            this.lastUpdateTime.Text = "Not Updated Yet";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Time of last update:";
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
            this.TopIndex,
            this.TopHost,
            this.TopDescription,
            this.TopMetric,
            this.TopBiggestValue,
            this.TopMaxValue,
            this.TopUnit,
            this.TopProcentageValue,
            this.TopDate,
            this.TopId});
            this.top10Machines.Location = new System.Drawing.Point(10, 108);
            this.top10Machines.Name = "top10Machines";
            this.top10Machines.RowTemplate.Height = 40;
            this.top10Machines.Size = new System.Drawing.Size(780, 124);
            this.top10Machines.TabIndex = 38;
            this.top10Machines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.top10Machines_CellContentClick);
            // 
            // TopIndex
            // 
            this.TopIndex.HeaderText = "Index";
            this.TopIndex.Name = "TopIndex";
            this.TopIndex.ReadOnly = true;
            this.TopIndex.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TopIndex.Width = 50;
            // 
            // TopHost
            // 
            this.TopHost.HeaderText = "Host";
            this.TopHost.Name = "TopHost";
            // 
            // TopDescription
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TopDescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.TopDescription.FillWeight = 120F;
            this.TopDescription.HeaderText = "Description";
            this.TopDescription.Name = "TopDescription";
            this.TopDescription.ReadOnly = true;
            this.TopDescription.Width = 200;
            // 
            // TopMetric
            // 
            this.TopMetric.HeaderText = "Metric";
            this.TopMetric.Name = "TopMetric";
            // 
            // TopBiggestValue
            // 
            this.TopBiggestValue.HeaderText = "BiggestValue";
            this.TopBiggestValue.Name = "TopBiggestValue";
            // 
            // TopMaxValue
            // 
            this.TopMaxValue.HeaderText = "MaxValue";
            this.TopMaxValue.Name = "TopMaxValue";
            // 
            // TopUnit
            // 
            this.TopUnit.HeaderText = "Unit";
            this.TopUnit.Name = "TopUnit";
            // 
            // TopProcentageValue
            // 
            this.TopProcentageValue.HeaderText = "ProcentageValue";
            this.TopProcentageValue.Name = "TopProcentageValue";
            // 
            // TopDate
            // 
            this.TopDate.HeaderText = "Date";
            this.TopDate.Name = "TopDate";
            this.TopDate.Width = 110;
            // 
            // TopId
            // 
            this.TopId.HeaderText = "Id";
            this.TopId.Name = "TopId";
            this.TopId.ReadOnly = true;
            this.TopId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TopId.Width = 69;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "NewMonitorFile";
            // 
            // SaveLogsButton
            // 
            this.SaveLogsButton.Location = new System.Drawing.Point(616, 633);
            this.SaveLogsButton.Name = "SaveLogsButton";
            this.SaveLogsButton.Size = new System.Drawing.Size(99, 23);
            this.SaveLogsButton.TabIndex = 46;
            this.SaveLogsButton.Text = "Save Logs to file";
            this.SaveLogsButton.UseVisualStyleBackColor = true;
            this.SaveLogsButton.Click += new System.EventHandler(this.SaveLogsButton_Click);
            // 
            // logsWindowsTextBox
            // 
            this.logsWindowsTextBox.Location = new System.Drawing.Point(12, 659);
            this.logsWindowsTextBox.Name = "logsWindowsTextBox";
            this.logsWindowsTextBox.Size = new System.Drawing.Size(798, 69);
            this.logsWindowsTextBox.TabIndex = 47;
            this.logsWindowsTextBox.Text = "";
            // 
            // LogsWindow
            // 
            this.LogsWindow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogsWindow.AutoSize = true;
            this.LogsWindow.Location = new System.Drawing.Point(12, 643);
            this.LogsWindow.Name = "LogsWindow";
            this.LogsWindow.Size = new System.Drawing.Size(33, 13);
            this.LogsWindow.TabIndex = 46;
            this.LogsWindow.Text = "Logs:";
            // 
            // AutoClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 741);
            this.Controls.Add(this.LogsWindow);
            this.Controls.Add(this.logsWindowsTextBox);
            this.Controls.Add(this.SaveLogsButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.clearLogsButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.logsTextBox);
            this.MaximumSize = new System.Drawing.Size(838, 970);
            this.MinimumSize = new System.Drawing.Size(837, 766);
            this.Name = "AutoClient";
            this.Text = "AutoClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshRateTrackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfTopElementsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10Machines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logsTextBox;
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
        private System.Windows.Forms.TrackBar refreshRateTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rateValueLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView top10Machines;
        private System.Windows.Forms.Button OpenMonitorFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SaveMonitorFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridView monitorsGridView;
        private System.Windows.Forms.Button addMonitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonitorPassword;
        private System.Windows.Forms.DataGridViewButtonColumn MonitorDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastUpdateTime;
        private System.Windows.Forms.Label numberOfTopLabel;
        private System.Windows.Forms.TrackBar numberOfTopElementsTrackBar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveTopButton;
        private System.Windows.Forms.Button SaveLogsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopHost;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopMetric;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopBiggestValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopMaxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopProcentageValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TopId;
        private System.Windows.Forms.RichTextBox logsWindowsTextBox;
        private System.Windows.Forms.Label LogsWindow;
    }
}

