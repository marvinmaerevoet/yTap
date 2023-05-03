using Microsoft.Extensions.Configuration;
using System.Diagnostics;
using YY.Configuration;
using YY.Logging;
using YY.WakeManagement;

namespace YY.UI;

internal partial class YForm : Form {
    private readonly YSettingsManager.Settings Settings;
    private readonly IConfiguration Configuration;
    private readonly string RegistryKeyPath;
    private YGlossaryManager.Localization Localization;

    public YForm() {
        Configuration = YResourceManager.GetConfiguration();
        RegistryKeyPath = $@"Software\{Configuration["ProductManufacturer"]}\{Configuration["ProductName"]}";
        Settings = YSettingsManager.GetRegistrySettings(RegistryKeyPath);
        Localization = YGlossaryManager.GetLocalization(Settings.UserLanguage);
        InitializeComponent();
        ConfigureComponents(Settings);
        DevicesRefresh();
        TasksRefresh();
    }

    private void ConfigureComponents(YSettingsManager.Settings settings) {
        Icon = new Icon(YResourceManager.LoadEmbeddedResource("Zzz_Icon_Color.ico"));
        Text = Configuration["ProductName"];
        SettingsSetPowerStateButton.Text = Configuration["ProductSlogan"];
        TraySwitchOffToolStripMenuItem.Text = Configuration["ProductSlogan"];
        TrayNotifyIcon.Icon = new Icon(YResourceManager.LoadEmbeddedResource("Zzz_Icon_White.ico"));
        TrayNotifyIcon.Text = Configuration["ProductName"];
        TrayOpenToolStripMenuItem.Text = Configuration["ProductName"];
        SettingsUserLanguageComboBox.SelectedItem = settings.UserLanguage;
        SettingsDelayNumericUpDown.Value = settings.Delay;
        SettingsPowerStateComboBox.SelectedItem = settings.PowerState.ToString();
        SettingsForceCriticalCheckBox.Checked = settings.IsForceCritical;
        SettingsDisableTasksCheckBox.Checked = settings.IsTasksDisable;
        SettingsRunOnStartupCheckBox.Checked = settings.IsRunOnStartup;
        TasksDisableTasksCheckBox.Checked = settings.IsTasksDisable;
        ActionsTextBox.Clear();
    }

    private void SetLocalisation(string userLanguage) {
        Localization = YGlossaryManager.GetLocalization(userLanguage);
        SettingsTabPage.Text = Localization.SettingsTabPage;
        SettingsLabel.Text = Localization.SettingsLabel;
        SettingsSaveButton.Text = Localization.SettingsSaveButton;
        SettingsUserLanguageLabel.Text = Localization.SettingsUserLanguageLabel;
        SettingsDelayLabel.Text = Localization.SettingsDelayLabel;
        SettingsDelaySecondsLabel.Text = Localization.SettingsDelaySecondsLabel;
        SettingsPowerStateLabel.Text = Localization.SettingsPowerStateLabel;
        GeneralToolTip.SetToolTip(SettingsPowerStateComboBox, Localization.SettingsPowerStateTooltip);
        GeneralToolTip.SetToolTip(SettingsPowerStateFlowLayoutPanel, Localization.SettingsPowerStateTooltip);
        GeneralToolTip.SetToolTip(SettingsPowerStateLabel, Localization.SettingsPowerStateTooltip);
        SettingsForceCriticalCheckBox.Text = Localization.SettingsForceCriticalCheckBoxText;
        GeneralToolTip.SetToolTip(SettingsForceCriticalCheckBox, Localization.SettingsForceCriticalCheckBoxToolTip);
        SettingsDisableTasksCheckBox.Text = Localization.SettingsDisableTasksCheckBoxText;
        GeneralToolTip.SetToolTip(SettingsDisableTasksCheckBox, Localization.SettingsDisableTasksCheckBoxToolTip);
        SettingsRunOnStartupCheckBox.Text = Localization.SettingsRunOnStartupCheckBoxText;
        GeneralToolTip.SetToolTip(SettingsRunOnStartupCheckBox, Localization.SettingsRunOnStartupCheckBoxTooltip);
        DevicesTabPage.Text = Localization.DevicesTabPage;
        DevicesLabel.Text = Localization.DevicesLabel;
        DevicesRefreshButton.Text = Localization.DevicesRefreshButton;
        TasksTabPage.Text = Localization.TasksTabPage;
        TasksLabel.Text = Localization.TasksLabel;
        TasksDisableTasksCheckBox.Text = Localization.TasksDisableTasksCheckBoxText;
        GeneralToolTip.SetToolTip(TasksDisableTasksCheckBox, Localization.TasksDisableTasksCheckBoxToolTip);
        TasksRefreshButton.Text = Localization.TasksRefreshButton;
        ActionsLabel.Text = Localization.ActionsLabel;
        ActionsClearButton.Text = Localization.ActionsClearButton;

        if(Settings.UserLanguage == "English") {
            GeneralToolTip.SetToolTip(SettingsRunOnStartupCheckBox, $"Run {Configuration["ProductName"]} on startup automatically");
        } else if(Settings.UserLanguage == "Deutsch") {
            GeneralToolTip.SetToolTip(SettingsRunOnStartupCheckBox, $"{Configuration["ProductName"]} beim Starten automatisch ausführen");
        }
    }

    private void YFormResize(object sender, EventArgs e) {
        if(WindowState == FormWindowState.Minimized) {
            Hide();
        }
    }

    private void SetPowerState() {
        YPowerStateManager.SetPowerStateAsync(Settings.Delay, Settings.PowerState, Settings.IsForceCritical, Settings.IsTasksDisable);
    }

    private void DevicesRefresh() {
        DevicesTreeView.Enabled = false;
        DevicesTreeView.BuildFromXDoc(YWakeDevicesManager.GetDevicesXDocument());
        DevicesTreeView.Enabled = true;
    }

    private void TasksRefresh() {
        TasksTreeView.Enabled = false;
        TasksTreeView.BuildFromXDoc(YWakeTasksManager.GetTasksXDocument());
        TasksTreeView.Enabled = !Settings.IsTasksDisable;
    }

    private void LogActions(string message) {
        YLog.Action(message);
        ActionsTextBox.AppendText($"{message}\r\n");
    }

    #region UI Events

    #region Actions
    private void ActionsClearButtonClick(object sender, EventArgs e) {
        ActionsTextBox.Clear();
    }

    private void ActionsShowLogButtonClick(object sender, EventArgs e) {
        string productManufacturer = Configuration["ProductManufacturer"] ?? "";
        string productName = Configuration["ProductName"] ?? "";
        string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), productManufacturer, productName, "Actions");
        if(!Directory.Exists(folderPath)) {
            _ = Directory.CreateDirectory(folderPath);
        }
        _ = Process.Start(new ProcessStartInfo(folderPath) { UseShellExecute = true });
    }

    #endregion

    #region Settings
    private void SettingsSaveButtonClick(object sender, EventArgs e) {
        YSettingsManager.SetRegistrySettings(RegistryKeyPath, Settings);
        LogActions($"Settings saved - Delay: {Settings.Delay}, " +
            $"Power state: {Settings.PowerState}, " +
            $"Disable tasks: {Settings.IsTasksDisable}, " +
            $"Force cirtical: {Settings.IsForceCritical}, " +
            $"Run on startup: {Settings.IsRunOnStartup}");
    }

    private void SettingsDelayNumericUpDownValueChanged(object sender, EventArgs e) {
        Settings.Delay = (int)SettingsDelayNumericUpDown.Value;
        LogActions($"Set delay to {Settings.Delay} seconds.");
    }

    private void SettingsForceCriticalCheckBoxCheckedChanged(object sender, EventArgs e) {
        Settings.IsForceCritical = SettingsForceCriticalCheckBox.Checked;
        LogActions($"Set force critical to {Settings.IsForceCritical}.");
    }

    private void SettingsDisableAllCheckBoxCheckedChanged(object sender, EventArgs e) {
        Settings.IsTasksDisable = SettingsDisableTasksCheckBox.Checked;
        TasksTreeView.Enabled = !Settings.IsTasksDisable;
        TasksDisableTasksCheckBox.Checked = Settings.IsTasksDisable;
        LogActions($"Set disable tasks to {Settings.IsTasksDisable}.");
    }

    private void SettingsRunOnStartupCheckBoxCheckedChanged(object sender, EventArgs e) {
        Settings.IsRunOnStartup = SettingsRunOnStartupCheckBox.Checked;
        YSettingsManager.SetRunOnStartup(Settings.IsRunOnStartup);
        LogActions($"Set run on startup to {Settings.IsRunOnStartup}.");
    }

    private void SettingsHibernateButtonClick(object sender, EventArgs e) {
        LogActions($"{Configuration["ProductSlogan"]}");
        SetPowerState();
    }

    private void SettingsUserLanguageComboBox_SelectedValueChanged(object sender, EventArgs e) {
        Settings.UserLanguage = SettingsUserLanguageComboBox.SelectedItem.ToString() ?? "English";
        SetLocalisation(Settings.UserLanguage);
        LogActions($"Set user language to {Settings.UserLanguage}.");
    }

    private void SettingsPowerStateComboBox_SelectedValueChanged(object sender, EventArgs e) {
        if(SettingsPowerStateComboBox.SelectedItem.ToString() == "Suspend") {
            Settings.PowerState = PowerState.Suspend;
        } else if(SettingsPowerStateComboBox.SelectedItem.ToString() == "Hibernate") {
            Settings.PowerState = PowerState.Hibernate;
        }
        LogActions($"Set power state to {Settings.PowerState}.");
    }

    #endregion

    #region Devices
    private void DevicesRefreshButtonClick(object sender, EventArgs e) {
        DevicesRefresh();
        LogActions("Succesfully scanned for new devices.");
    }

    private void DevicesTreeViewAfterCheck(object? sender, TreeViewEventArgs e) {
        if(e.Node != null) {
            DevicesTreeView.AfterCheck -= DevicesTreeViewAfterCheck;
            string instanceName = YTreeView.GetValueFromTreeNodeText(e.Node, "InstanceName");
            _ = YWakeDevicesManager.SetDeviceEnable(instanceName, e.Node.Checked);

            string isEnable = e.Node.Checked ? "Enabled" : "Disabled";
            string message = $"{isEnable} device to wake the computer. [{e.Node.Text}] [{instanceName}]";
            LogActions(message);

            DevicesRefresh();
            DevicesTreeView.AfterCheck += DevicesTreeViewAfterCheck;
        }
    }

    #endregion

    #region Tasks
    private void TasksRefreshButtonClick(object sender, EventArgs e) {
        TasksRefresh();
        LogActions("Succesfully scanned for new tasks.");
    }

    private void TasksTreeViewAfterCheck(object? sender, TreeViewEventArgs e) {
        if(e.Node?.Level == 0) {
            TasksTreeView.AfterCheck -= TasksTreeViewAfterCheck;
            _ = YWakeTasksManager.SetTaskWakeToRun(e.Node.Text, e.Node.Checked);

            string isEnable = e.Node.Checked ? "Enabled" : "Disabled";
            string message = $"{isEnable} task to wake the computer. [{e.Node.Text}]";
            LogActions(message);

            TasksRefresh();
            TasksTreeView.AfterCheck += TasksTreeViewAfterCheck;
        }
    }

    private void TasksDisableAllCheckBoxCheckedChanged(object sender, EventArgs e) {

        Settings.IsTasksDisable = TasksDisableTasksCheckBox.Checked;
        TasksTreeView.Enabled = !Settings.IsTasksDisable;
        SettingsDisableTasksCheckBox.Checked = Settings.IsTasksDisable;

    }

    #endregion

    #region Tray
    private void TrayHibernateToolStripMenuItemClick(object sender, EventArgs e) {
        LogActions($"{Configuration["ProductSlogan"]}");
        SetPowerState();
    }

    private void TrayOpenToolStripMenuItemClick(object sender, EventArgs e) {
        Show();
        _ = Focus();
        WindowState = FormWindowState.Normal;
    }
    #endregion

    #endregion
}
