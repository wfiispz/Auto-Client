using System;
using System.IO;
using System.Windows.Forms;
using static AutoClientApplication.Utils;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace AutoClientApplication {

    public partial class AutoClient : Form {

        private const string DEFAULT_MONITOR_FILENAME = "Monitors.dat";

        private const string NEW_EMPTY_MONITOR_NAME = "-> Write Address Here <-";

        private List<Resources> allResources = new List<Resources>();

        private List<TopResource> allTopResources = new List<TopResource>();

        private TimeSpan refreshRate;

        private int numberOfTop = 10;

        private bool isApplicationStopped = false;

        public AutoClient() {
            InitializeComponent();
            InitStartOption();
            AssignDefaultValues();
        }

        private void InitStartOption() {
            logsTextBox.ReadOnly = true;
            directoryLabel.ReadOnly = true;
            top10Machines.ReadOnly = true;
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void TopButton_Click(object sender, EventArgs e) {
            AddNewInfo("TOP request clicked.");
        }

        private void ClearLogsButton_Click(object sender, EventArgs e) {
            logsTextBox.Text = "";
            clearLogsButton.Enabled = false;
        }

        private void StartButton_Click(object sender, EventArgs e) {
            isApplicationStopped = false;
            AssignUiAfterStartButton();
            AddNewInfo("Application started.");
            DownloadDataFromAllMonitors();
        }

        private void DownloadDataFromAllMonitors() {
            for (int monitorIndex = 0; monitorIndex < monitorsGridView.RowCount; monitorIndex++)
                GetMonitorResources(GetMonitorAddress(monitorIndex), GetMonitorUser(monitorIndex), GetMonitorPassword(monitorIndex));
        }

        private async void GetMonitorResources(string address, string user, string password) {
            allResources.Clear();
            allTopResources.Clear();
            top10Machines.Rows.Clear();
            var resourcesRespond = await DataRestDownloader.GetDataAsync<ResourcesRespond>("resources", address, user, password, null, GetDataAsyncErrorCallback);
            lastUpdateTime.Text = DateTime.Now.ToString();
            if (resourcesRespond != null && resourcesRespond.Data.resources != null) {
                AssignNewResources(address, resourcesRespond.Data, user, password);
                if (isApplicationStopped) return;
                AddNewResourcesToView();
            }
            if (isApplicationStopped) return;
            await Task.Delay(refreshRate);
            if (isApplicationStopped) return;
            GetMonitorResources(address, user, password);
        }

        private void AddNewResourcesToView() {
            AddNewInfo("New resources added.");
            AddNewResourcesToDataGridView(GetTopResources(numberOfTop));
        }

        private void AddNewResourcesToDataGridView(List<TopResource> topResources) {
            foreach (var topResource in topResources)
                AddNewRowToDataGridView(topResource);
        }

        private List<TopResource> GetTopResources(int numberOfResources) {
            foreach (var resource in allResources) {
                Value biggestValue = new Value() { value = 0, datatime = new DateTime() };
                Measurement biggestOverstretchedMeasurement = new Measurement();
                SetBiggestMeasurement(resource.measurements, ref biggestOverstretchedMeasurement, ref biggestValue);
                var topResource = new TopResource() {
                    id = resource.id,
                    name = resource.name,
                    description = resource.description,
                    host = biggestOverstretchedMeasurement.host,
                    metric = biggestOverstretchedMeasurement.metric,
                    unit = biggestOverstretchedMeasurement.unit,
                    biggestValue = biggestValue.value,
                    dateTime = biggestValue.datatime
                };
                allTopResources.Add(topResource);
            }
            return allTopResources.OrderByDescending(x => x.biggestValue).Take(numberOfResources).ToList();
        }

        private void SetBiggestMeasurement(List<Measurement> measurements, ref Measurement biggestOverstretchedMeasurement, ref Value biggestValue) {
           foreach (var measurement in measurements) {
                var latestValue = measurement.values.OrderByDescending(x => x.datatime).FirstOrDefault();
                if (latestValue.value > biggestValue.value) {
                    biggestValue = latestValue;
                    biggestOverstretchedMeasurement = measurement;
                }
            }
        }

        private async void AssignNewResources(string address, ResourcesRespond resourcesRespond, string user, string password) {
                foreach (var resource in resourcesRespond.resources)
                    if (allResources.Count == 0 || !allResources.Exists(x => x.id == resource.id)) {
                        allResources.Add(new Resources() {
                            id = resource.id,
                            name = resource.name,
                            description = resource.description,
                            measurements = await GetMonitorMeasurements(address, resource.measurementsGuids, user, password)
                        });
                    }
        }

        private async Task<List<Measurement>> GetMonitorMeasurements(string address, List<string> measurementsGuids, string user, string password) {
            List<Measurement> measurements = new List<Measurement>();
            foreach (var measurementGuid in measurementsGuids) {
                MeasurementRespond measurementData = await GetMeasurementData(address, measurementGuid, user, password);
                if (measurementData != null) {
                    var measuremnt = new Measurement() {
                        host = measurementData.host,
                        metric = measurementData.metric,
                        unit = measurementData.unit,
                        maxValue = measurementData.maxValue,
                        complex = measurementData.complex,
                        values = await GetMeasurementValues(address, measurementGuid, user, password)
                    };
                    measurements.Add(measuremnt);
                }
            }
            return measurements;
        }

        private async Task<MeasurementRespond> GetMeasurementData(string address, string measurementGuid, string user, string password) {
            var measurementRespond = await DataRestDownloader.GetDataAsync<MeasurementRespond>("measurements", address, user, password, measurementGuid, GetDataAsyncErrorCallback);
            return measurementRespond != null ? measurementRespond.Data : null;
        }

        private async Task<List<Value>> GetMeasurementValues(string address, string measurementGuid, string user, string password) {
            var parameter = measurementGuid + "/values";
            var values = await DataRestDownloader.GetDataAsync<List<Value>>("measurements", address, user, password, parameter, GetDataAsyncErrorCallback);
            return values != null ? values.Data : null;
        }

        private void GetDataAsyncErrorCallback(string errorMessage) {
            AddNewInfo(errorMessage);
        }

        private void StopButton_Click(object sender, EventArgs e) {
            isApplicationStopped = true;
            AssignUiAfterStopButton();
            AddNewInfo("Application stopped.");
        }

        private void AddNewInfo(string info) {
            logsTextBox.Text += DateTime.Now.ToString("H:mm:ss") + "  -  " + info + Environment.NewLine;
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
                AddNewInfo("WARNING: FILE is empty. " + directoryLabel.Text);
                return;
            }
            while (line != null) {
                var data = line.Split('$');
                var dataLength = data.Length;
                var address = data[0];
                var user = dataLength > 1 ? data[1] : "User";
                var password = dataLength > 2 ? data[2] : "Password";
                if (!AnyRowContainsAddress(address)) {
                    AddNewInfo("New monitor added to list: " + address);
                    monitorsGridView.Rows.Add();
                    var id = monitorsGridView.Rows.Count - 1;
                    var currentRow = monitorsGridView.Rows[id];
                    currentRow.Cells["MonitorIndex"].Value = id + 1;
                    currentRow.Cells["MonitorAddress"].Value = address;
                    currentRow.Cells["MonitorUser"].Value = user;
                    currentRow.Cells["MonitorPassword"].Value = password;
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

        private string GetMonitorUser(int rowIndex) {
            return (string)monitorsGridView.Rows[rowIndex].Cells["MonitorUser"].Value;
        }

        private string GetMonitorPassword(int rowIndex) {
            return (string)monitorsGridView.Rows[rowIndex].Cells["MonitorPassword"].Value;
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
            currentRow.Cells["MonitorUser"].Value = "User";
            currentRow.Cells["MonitorPassword"].Value = "Password";
            currentRow.Cells["MonitorDelete"].Value = "X";
            clearMonitorsButton.Enabled = true;
            startButton.Enabled = true;
            AddNewInfo("New empty monitor added to list: ");
        }

        private void AddNewRowToDataGridView(TopResource topResource) {
            top10Machines.Rows.Add();
            var index = top10Machines.RowCount - 1;
            var currentRow = top10Machines.Rows[index];
            currentRow.Cells["TopIndex"].Value = index + 1;
            currentRow.Cells["TopHost"].Value = topResource.host;
            currentRow.Cells["TopDescription"].Value = topResource.description;
            currentRow.Cells["TopMetric"].Value = topResource.metric.ToString();
            currentRow.Cells["TopBiggestValue"].Value = topResource.biggestValue;
            currentRow.Cells["TopDate"].Value = topResource.dateTime.ToShortDateString();
            currentRow.Cells["TopUnit"].Value = topResource.unit;
            currentRow.Cells["TopId"].Value = topResource.id;

            AddNewInfo("New resource: " + topResource.host + " added to list: ");
        }

        private string PrepereMonitorAddressesForSave() {
            var monitorAddresses = string.Empty;
            foreach (DataGridViewRow row in monitorsGridView.Rows)
                monitorAddresses += (string)row.Cells["MonitorAddress"].Value + "$" + 
                                    (string)row.Cells["MonitorUser"].Value + "$" + 
                                    (string)row.Cells["MonitorPassword"].Value + Environment.NewLine;
            return monitorAddresses;
        }

        private void ClearMonitorsButton_Click(object sender, EventArgs e) {
            AddNewInfo("All monitors deleted.");
            monitorsGridView.Rows.Clear();
            clearMonitorsButton.Enabled = false;
            startButton.Enabled = false;
        }

        private void RefreshRateTackBarOnValueChange(object sender, EventArgs e) {
            refreshRate = TimeSpan.FromSeconds(refreshRateTrackBar.Value);
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

        private void AssignDefaultValues() {
            refreshRate = new TimeSpan(0, 1, 0);
            refreshRateTrackBar.Value = 60;
            rateValueLabel.Text = SecondsToHours(refreshRate);
            numberOfTop = 10;
            numberOfTopElementsTrackBar.Value = 10;
            numberOfTopLabel.Text = numberOfTop.ToString();
            stopButton.Enabled = false;
            startButton.Enabled = false;
            clearLogsButton.Enabled = false;
            clearMonitorsButton.Enabled = false;
            top10Machines.Rows.Clear();
            monitorsGridView.Rows.Clear();
            lastUpdateTime.Text = "Not updated yet";
            allResources.Clear();
            allTopResources.Clear();
            top10Machines.Rows.Clear();
            directoryLabel.Text = Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + DEFAULT_MONITOR_FILENAME;
            logsTextBox.Text = "";
        }

        private void AssignUiAfterStartButton() {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            clearMonitorsButton.Enabled = false;
            loadMonitorsButton.Enabled = false;
            restartButton.Enabled = false;
            numberOfTopElementsTrackBar.Enabled = false;
            refreshRateTrackBar.Enabled = false;
        }

        private void AssignUiAfterStopButton() {
            stopButton.Enabled = false;
            startButton.Enabled = true;
            restartButton.Enabled = true;
            clearMonitorsButton.Enabled = true;
            loadMonitorsButton.Enabled = true;
            numberOfTopElementsTrackBar.Enabled = true;
            refreshRateTrackBar.Enabled = true;
        }

        private void NumberOfTopElements(object sender, EventArgs e) {
            numberOfTop = numberOfTopElementsTrackBar.Value;
            numberOfTopLabel.Text = numberOfTop.ToString();
        }

        private void SaveMonitorFile_Click_1(object sender, EventArgs e) {
            saveFileDialog1.InitialDirectory = directoryLabel.Text;
            saveFileDialog1.FileName = "Monitors";
            saveFileDialog1.Filter = "Data files|*.dat|Text files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, PrepereMonitorAddressesForSave());
        }

        private void SaveLogsButton_Click(object sender, EventArgs e) {
            saveFileDialog1.InitialDirectory = directoryLabel.Text;
            saveFileDialog1.FileName = "Logs";
            saveFileDialog1.Filter = "Text files|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, logsTextBox.Text);
        }

        private void SaveTopButton_Click(object sender, EventArgs e) {

            saveFileDialog1.InitialDirectory = directoryLabel.Text;
            saveFileDialog1.FileName = "TopResources";
            saveFileDialog1.Filter = "Data files|*.dat|Text files|*.txt|Csv files|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialog1.FileName, PrepereTopForSave());

        }

        private string PrepereTopForSave() {
            var header = "index,host,description,metric,biggestValue,Date,Unit,id" + Environment.NewLine;
            if (top10Machines.Rows.Count > 0) {
                foreach (DataGridViewRow row in top10Machines.Rows) {
                    header += (string)row.Cells["TopIndex"].Value + "," + (string)row.Cells["TopHost"].Value + "," + (string)row.Cells["TopDescription"].Value +
                        (string)row.Cells["TopMetric"].Value + "," + (string)row.Cells["TopBiggestValue"].Value + "," + (string)row.Cells["TopDate"].Value +
                        (string)row.Cells["TopUnit"].Value + "," + (string)row.Cells["TopId"].Value + Environment.NewLine;
                }
            }
            return header;
        }
    }
}
