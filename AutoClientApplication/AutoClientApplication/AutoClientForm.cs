using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoClientApplication.Utils;

namespace AutoClientApplication {

    public partial class AutoClientForm : Form {

        private const string DEFAULT_MONITOR_FILENAME = "Monitors.dat";

        private const string NEW_EMPTY_MONITOR_NAME = "-> Write Address Here <-";

        private TimeSpan refreshRate;

        public AutoClientForm() {
            InitializeComponent();
            InitStartOption();
            AssignDefaultValues();
        }

        private void InitStartOption() {
            resultsTextBox.ReadOnly = true;
            directoryLabel.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void TopButton_Click(object sender, EventArgs e) {
            AddNewInfo("TOP request clicked.");
        }

        private void ClearLogsButton_Click(object sender, EventArgs e) {
            resultsTextBox.Text = "";
            clearLogsButton.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e) {
            AssignUiAfterStartButton();
            AddNewInfo("Application started.");
            DownloadDataFromAllMonitors();
        }

        private void DownloadDataFromAllMonitors() {
            for (int monitorIndex = 0; monitorIndex < monitorsGridView.RowCount; monitorIndex++)
                GetSensors(GetMonitorAddress(monitorIndex));
        }

        private static void UpdateSensorValues(List<Sensor> sensors) {
            throw new NotImplementedException();
        }

        private static async void GetSensors(string address) {
            var listOfSensors = await SensorsRestDownloader.GetSensorsAsync<List<Sensor>>(address);
            if (listOfSensors.Data.Count > 0)
                UpdateSensorValues(listOfSensors.Data);
        }

        private void StopButton_Click(object sender, EventArgs e) {
            AssignUiAfterStopButton();
            AddNewInfo("Application stopped.");
        }

        private void AddNewInfo(string info) {
            resultsTextBox.Text += DateTime.Now.ToString("H:mm:ss") + "  -  " + info + Environment.NewLine;
            clearLogsButton.Enabled = true;
        }

        private void LoadMonitorsFileButton_Click(object sender, EventArgs e) {
            AddNewInfo("Loading file: " + directoryLabel.Text);
            ReadDirectoryFile();
        }

        private void ReadDirectoryFile() {
            if (!File.Exists(directoryLabel.Text)) {
                AddNewInfo("ERROR: Directory not exists.");
                return;
            }
            StreamReader file = new StreamReader(directoryLabel.Text);
            string line = file.ReadLine();
            if (line == null) {
                AddNewInfo("WARNING: FILE is empty. " + line);
                return;
            }
            while (line != null) {
                if (!AnyRowContainsAddress(line)) {
                    AddNewInfo("New monitor added to list: " + line);
                    monitorsGridView.Rows.Add();
                    var id = monitorsGridView.Rows.Count - 1;
                    var currentRow = monitorsGridView.Rows[id];
                    currentRow.Cells["MonitorIndex"].Value = id + 1;
                    currentRow.Cells["MonitorAddress"].Value = line;
                    currentRow.Cells["MonitorDelete"].Value = "X";
                    clearMonitorsButton.Enabled = true;
                    startButton.Enabled = true;
                }
                line = file.ReadLine();
            }
            file.Close();
        }

        private bool AnyRowContainsAddress(string address) {
            foreach (DataGridViewRow row in monitorsGridView.Rows) {
                if (row.Cells["MonitorAddress"].Value.Equals(address))
                    return true;
            }
            return false;
        }

        private void DeleteMonitor(int rowIndex) {
            foreach (DataGridViewRow row in monitorsGridView.Rows) {
                if ((int)row.Cells["MonitorIndex"].Value > rowIndex)
                    row.Cells["MonitorIndex"].Value = (int)row.Cells["MonitorIndex"].Value - 1;
            }
            var monitorAddress = GetMonitorAddress(rowIndex);
            if (!monitorAddress.Equals(NEW_EMPTY_MONITOR_NAME))
                AddNewInfo("Monitor deleted: " + monitorAddress);
            else
                AddNewInfo("Empty Monitor deleted");
            monitorsGridView.Rows.RemoveAt(rowIndex);

            if (monitorsGridView.Rows.Count == 0) {
                startButton.Enabled = false;
                clearMonitorsButton.Enabled = false;
            }
        }

        private string GetMonitorAddress(int rowIndex) {
            return (string)monitorsGridView.Rows[rowIndex].Cells["MonitorAddress"].Value;
        }

        private void RestartButton_Click(object sender, EventArgs e) {
            AssignDefaultValues();
        }

        private void AddMonitor_Click(object sender, EventArgs e) {
            monitorsGridView.Rows.Add();
            var id = monitorsGridView.RowCount - 1;
            var currentRow = monitorsGridView.Rows[id];
            currentRow.Cells["MonitorIndex"].Value = id + 1;
            currentRow.Cells["MonitorAddress"].Value = NEW_EMPTY_MONITOR_NAME;
            currentRow.Cells["MonitorDelete"].Value = "X";
            clearMonitorsButton.Enabled = true;
            startButton.Enabled = true;
            AddNewInfo("New empty monitor added to list: ");
        }

        private string PrepereMonitorAddressesForSave() {
            var monitorAddresses = string.Empty;
            foreach (DataGridViewRow row in monitorsGridView.Rows)
                monitorAddresses += (string)row.Cells["MonitorAddress"].Value + Environment.NewLine;
            return monitorAddresses;
        }

        private void ClearMonitorsButton_Click(object sender, EventArgs e) {
            AddNewInfo("All monitors deleted.");
            monitorsGridView.Rows.Clear();
            clearMonitorsButton.Enabled = false;
            startButton.Enabled = false;
        }

        private void RefreshRateTackBarOnValueChange(object sender, EventArgs e) {
            refreshRate = TimeSpan.FromSeconds(trackBar1.Value);
            rateValueLabel.Text = SecondsToHours(refreshRate);
        }

        private void OpenMonitorFile_Click(object sender, EventArgs e) {
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "Data files|*.dat|Text files|*.txt";
            openFileDialog1.InitialDirectory = directoryLabel.Text;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
                directoryLabel.Text = openFileDialog1.FileName;
        }

        private void MonitorsGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (monitorsGridView.Columns[e.ColumnIndex].Name == "MonitorDelete")
                DeleteMonitor(e.RowIndex);
        }

        private void SaveMonitorFile_Click_1(object sender, EventArgs e) {
            saveFileDialog1.InitialDirectory = directoryLabel.Text;
            saveFileDialog1.Filter = "Data files|*.dat|Text files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, PrepereMonitorAddressesForSave());
        }

        private void AssignDefaultValues() {
            refreshRate = new TimeSpan(0);
            rateValueLabel.Text = SecondsToHours(refreshRate);
            stopButton.Enabled = false;
            startButton.Enabled = false;
            clearLogsButton.Enabled = false;
            clearMonitorsButton.Enabled = false;
            topButton.Enabled = false;
            top10Machines.Rows.Clear();
            monitorsGridView.Rows.Clear();
            directoryLabel.Text = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + DEFAULT_MONITOR_FILENAME;
            resultsTextBox.Text = "";
        }

        private void AssignUiAfterStartButton() {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            topButton.Enabled = true;
            clearMonitorsButton.Enabled = false;
            loadMonitorsButton.Enabled = false;
        }

        private void AssignUiAfterStopButton() {
            stopButton.Enabled = false;
            startButton.Enabled = true;
            topButton.Enabled = false;
            clearMonitorsButton.Enabled = true;
            loadMonitorsButton.Enabled = true;
        }
    }
}
