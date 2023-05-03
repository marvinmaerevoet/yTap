using YApp.UI;

namespace YY.UI {
    partial class YForm {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YForm));
            this.GeneralSplitContainer = new SplitContainer();
            this.GeneralTabControl = new TabControl();
            this.SettingsTabPage = new TabPage();
            this.SettingsFlowLayoutPanel = new FlowLayoutPanel();
            this.SettingsDelayFlowLayoutPanel = new FlowLayoutPanel();
            this.SettingsDelayLabel = new Label();
            this.SettingsDelayNumericUpDown = new NumericUpDown();
            this.SettingsDelaySecondsLabel = new Label();
            this.SettingsPowerStateFlowLayoutPanel = new FlowLayoutPanel();
            this.SettingsPowerStateLabel = new Label();
            this.SettingsPowerStateComboBox = new ComboBox();
            this.SettingsForceCriticalCheckBox = new CheckBox();
            this.SettingsDisableTasksCheckBox = new CheckBox();
            this.SettingsRunOnStartupCheckBox = new CheckBox();
            this.SettingsUserLanguageFlowLayoutPanel = new FlowLayoutPanel();
            this.SettingsUserLanguageLabel = new Label();
            this.SettingsUserLanguageComboBox = new ComboBox();
            this.SettingsTableLayoutPanel = new TableLayoutPanel();
            this.SettingsSaveButton = new Button();
            this.SettingsLabel = new Label();
            this.DevicesTabPage = new TabPage();
            this.DevicesTreeView = new YTreeView();
            this.DevicesTableLayoutPanel = new TableLayoutPanel();
            this.DevicesRefreshButton = new Button();
            this.DevicesLabel = new Label();
            this.TasksTabPage = new TabPage();
            this.TasksTreeView = new YTreeView();
            this.TasksTableLayoutPanel = new TableLayoutPanel();
            this.TasksLabel = new Label();
            this.TasksDisableTasksCheckBox = new CheckBox();
            this.TasksRefreshButton = new Button();
            this.ActionsPanel = new Panel();
            this.ActionsTextBox = new TextBox();
            this.ActionsTableLayoutPanel = new TableLayoutPanel();
            this.ActionsShowLogButton = new Button();
            this.ActionsLabel = new Label();
            this.ActionsClearButton = new Button();
            this.SettingsSetPowerStateButton = new Button();
            this.TrayContextMenuStrip = new YContextMenu();
            this.TrayOpenToolStripMenuItem = new ToolStripMenuItem();
            this.TraySwitchOffToolStripMenuItem = new ToolStripMenuItem();
            this.TrayNotifyIcon = new NotifyIcon(this.components);
            this.GeneralToolTip = new ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)this.GeneralSplitContainer).BeginInit();
            this.GeneralSplitContainer.Panel1.SuspendLayout();
            this.GeneralSplitContainer.Panel2.SuspendLayout();
            this.GeneralSplitContainer.SuspendLayout();
            this.GeneralTabControl.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.SettingsFlowLayoutPanel.SuspendLayout();
            this.SettingsDelayFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.SettingsDelayNumericUpDown).BeginInit();
            this.SettingsPowerStateFlowLayoutPanel.SuspendLayout();
            this.SettingsUserLanguageFlowLayoutPanel.SuspendLayout();
            this.SettingsTableLayoutPanel.SuspendLayout();
            this.DevicesTabPage.SuspendLayout();
            this.DevicesTableLayoutPanel.SuspendLayout();
            this.TasksTabPage.SuspendLayout();
            this.TasksTableLayoutPanel.SuspendLayout();
            this.ActionsPanel.SuspendLayout();
            this.ActionsTableLayoutPanel.SuspendLayout();
            this.TrayContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // GeneralSplitContainer
            // 
            this.GeneralSplitContainer.Dock = DockStyle.Fill;
            this.GeneralSplitContainer.FixedPanel = FixedPanel.Panel2;
            this.GeneralSplitContainer.Location = new Point(0, 0);
            this.GeneralSplitContainer.Name = "GeneralSplitContainer";
            this.GeneralSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // GeneralSplitContainer.Panel1
            // 
            this.GeneralSplitContainer.Panel1.Controls.Add(this.GeneralTabControl);
            // 
            // GeneralSplitContainer.Panel2
            // 
            this.GeneralSplitContainer.Panel2.Controls.Add(this.ActionsPanel);
            this.GeneralSplitContainer.Size = new Size(404, 381);
            this.GeneralSplitContainer.SplitterDistance = 239;
            this.GeneralSplitContainer.TabIndex = 0;
            // 
            // GeneralTabControl
            // 
            this.GeneralTabControl.Controls.Add(this.SettingsTabPage);
            this.GeneralTabControl.Controls.Add(this.DevicesTabPage);
            this.GeneralTabControl.Controls.Add(this.TasksTabPage);
            this.GeneralTabControl.Dock = DockStyle.Fill;
            this.GeneralTabControl.Location = new Point(0, 0);
            this.GeneralTabControl.Name = "GeneralTabControl";
            this.GeneralTabControl.SelectedIndex = 0;
            this.GeneralTabControl.Size = new Size(404, 239);
            this.GeneralTabControl.TabIndex = 1;
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.SettingsFlowLayoutPanel);
            this.SettingsTabPage.Controls.Add(this.SettingsTableLayoutPanel);
            this.SettingsTabPage.Location = new Point(4, 24);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Size = new Size(396, 211);
            this.SettingsTabPage.TabIndex = 0;
            this.SettingsTabPage.Text = "Settings";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // SettingsFlowLayoutPanel
            // 
            this.SettingsFlowLayoutPanel.AutoScroll = true;
            this.SettingsFlowLayoutPanel.Controls.Add(this.SettingsDelayFlowLayoutPanel);
            this.SettingsFlowLayoutPanel.Controls.Add(this.SettingsPowerStateFlowLayoutPanel);
            this.SettingsFlowLayoutPanel.Controls.Add(this.SettingsForceCriticalCheckBox);
            this.SettingsFlowLayoutPanel.Controls.Add(this.SettingsDisableTasksCheckBox);
            this.SettingsFlowLayoutPanel.Controls.Add(this.SettingsRunOnStartupCheckBox);
            this.SettingsFlowLayoutPanel.Controls.Add(this.SettingsUserLanguageFlowLayoutPanel);
            this.SettingsFlowLayoutPanel.Dock = DockStyle.Fill;
            this.SettingsFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            this.SettingsFlowLayoutPanel.Location = new Point(0, 31);
            this.SettingsFlowLayoutPanel.Name = "SettingsFlowLayoutPanel";
            this.SettingsFlowLayoutPanel.Size = new Size(396, 180);
            this.SettingsFlowLayoutPanel.TabIndex = 0;
            this.SettingsFlowLayoutPanel.WrapContents = false;
            // 
            // SettingsDelayFlowLayoutPanel
            // 
            this.SettingsDelayFlowLayoutPanel.AutoSize = true;
            this.SettingsDelayFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.SettingsDelayFlowLayoutPanel.Controls.Add(this.SettingsDelayLabel);
            this.SettingsDelayFlowLayoutPanel.Controls.Add(this.SettingsDelayNumericUpDown);
            this.SettingsDelayFlowLayoutPanel.Controls.Add(this.SettingsDelaySecondsLabel);
            this.SettingsDelayFlowLayoutPanel.Location = new Point(3, 3);
            this.SettingsDelayFlowLayoutPanel.Name = "SettingsDelayFlowLayoutPanel";
            this.SettingsDelayFlowLayoutPanel.Size = new Size(258, 26);
            this.SettingsDelayFlowLayoutPanel.TabIndex = 2;
            this.SettingsDelayFlowLayoutPanel.WrapContents = false;
            // 
            // SettingsDelayLabel
            // 
            this.SettingsDelayLabel.Anchor = AnchorStyles.Left;
            this.SettingsDelayLabel.AutoSize = true;
            this.SettingsDelayLabel.Location = new Point(3, 5);
            this.SettingsDelayLabel.Name = "SettingsDelayLabel";
            this.SettingsDelayLabel.Size = new Size(128, 15);
            this.SettingsDelayLabel.TabIndex = 0;
            this.SettingsDelayLabel.Text = "Delay before switch off";
            // 
            // SettingsDelayNumericUpDown
            // 
            this.SettingsDelayNumericUpDown.AutoSize = true;
            this.SettingsDelayNumericUpDown.BorderStyle = BorderStyle.None;
            this.SettingsDelayNumericUpDown.Location = new Point(137, 4);
            this.SettingsDelayNumericUpDown.Margin = new Padding(3, 4, 3, 3);
            this.SettingsDelayNumericUpDown.Maximum = new decimal(new int[] { 86400, 0, 0, 0 });
            this.SettingsDelayNumericUpDown.Name = "SettingsDelayNumericUpDown";
            this.SettingsDelayNumericUpDown.Size = new Size(53, 19);
            this.SettingsDelayNumericUpDown.TabIndex = 2;
            this.SettingsDelayNumericUpDown.ValueChanged += SettingsDelayNumericUpDownValueChanged;
            // 
            // SettingsDelaySecondsLabel
            // 
            this.SettingsDelaySecondsLabel.Anchor = AnchorStyles.Left;
            this.SettingsDelaySecondsLabel.AutoSize = true;
            this.SettingsDelaySecondsLabel.Location = new Point(196, 5);
            this.SettingsDelaySecondsLabel.Margin = new Padding(3);
            this.SettingsDelaySecondsLabel.Name = "SettingsDelaySecondsLabel";
            this.SettingsDelaySecondsLabel.Size = new Size(59, 15);
            this.SettingsDelaySecondsLabel.TabIndex = 0;
            this.SettingsDelaySecondsLabel.Text = "(Seconds)";
            // 
            // SettingsPowerStateFlowLayoutPanel
            // 
            this.SettingsPowerStateFlowLayoutPanel.AutoSize = true;
            this.SettingsPowerStateFlowLayoutPanel.Controls.Add(this.SettingsPowerStateLabel);
            this.SettingsPowerStateFlowLayoutPanel.Controls.Add(this.SettingsPowerStateComboBox);
            this.SettingsPowerStateFlowLayoutPanel.Location = new Point(3, 35);
            this.SettingsPowerStateFlowLayoutPanel.Name = "SettingsPowerStateFlowLayoutPanel";
            this.SettingsPowerStateFlowLayoutPanel.Size = new Size(201, 29);
            this.SettingsPowerStateFlowLayoutPanel.TabIndex = 3;
            this.GeneralToolTip.SetToolTip(this.SettingsPowerStateFlowLayoutPanel, "Sets the power state of the computer.\r\nHibernate: Save session and shut down. (slow wake up)\r\nSuspend: Pause activities. (quick wake up)");
            // 
            // SettingsPowerStateLabel
            // 
            this.SettingsPowerStateLabel.Anchor = AnchorStyles.Left;
            this.SettingsPowerStateLabel.AutoSize = true;
            this.SettingsPowerStateLabel.Location = new Point(3, 7);
            this.SettingsPowerStateLabel.Name = "SettingsPowerStateLabel";
            this.SettingsPowerStateLabel.Size = new Size(68, 15);
            this.SettingsPowerStateLabel.TabIndex = 0;
            this.SettingsPowerStateLabel.Text = "Power state";
            this.GeneralToolTip.SetToolTip(this.SettingsPowerStateLabel, "Sets the power state of the computer.\r\nHibernate: Save session and shut down. (slow wake up)\r\nSuspend: Pause activities. (quick wake up)\r\n");
            // 
            // SettingsPowerStateComboBox
            // 
            this.SettingsPowerStateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SettingsPowerStateComboBox.Items.AddRange(new object[] { "Hibernate", "Suspend" });
            this.SettingsPowerStateComboBox.Location = new Point(77, 3);
            this.SettingsPowerStateComboBox.MaxDropDownItems = 2;
            this.SettingsPowerStateComboBox.Name = "SettingsPowerStateComboBox";
            this.SettingsPowerStateComboBox.Size = new Size(121, 23);
            this.SettingsPowerStateComboBox.TabIndex = 3;
            this.GeneralToolTip.SetToolTip(this.SettingsPowerStateComboBox, "Sets the power state of the computer.\r\nHibernate: Save session and shut down. (slow wake up)\r\nSuspend: Pause activities. (quick wake up)\r\n");
            this.SettingsPowerStateComboBox.SelectedValueChanged += SettingsPowerStateComboBox_SelectedValueChanged;
            // 
            // SettingsForceCriticalCheckBox
            // 
            this.SettingsForceCriticalCheckBox.AutoSize = true;
            this.SettingsForceCriticalCheckBox.Location = new Point(3, 70);
            this.SettingsForceCriticalCheckBox.Name = "SettingsForceCriticalCheckBox";
            this.SettingsForceCriticalCheckBox.Size = new Size(280, 19);
            this.SettingsForceCriticalCheckBox.TabIndex = 4;
            this.SettingsForceCriticalCheckBox.Text = "Force immediate switch off (not recommended)";
            this.GeneralToolTip.SetToolTip(this.SettingsForceCriticalCheckBox, "Ignore currently running critical processes");
            this.SettingsForceCriticalCheckBox.CheckedChanged += SettingsForceCriticalCheckBoxCheckedChanged;
            // 
            // SettingsDisableTasksCheckBox
            // 
            this.SettingsDisableTasksCheckBox.AutoSize = true;
            this.SettingsDisableTasksCheckBox.Location = new Point(3, 95);
            this.SettingsDisableTasksCheckBox.Name = "SettingsDisableTasksCheckBox";
            this.SettingsDisableTasksCheckBox.Size = new Size(150, 19);
            this.SettingsDisableTasksCheckBox.TabIndex = 5;
            this.SettingsDisableTasksCheckBox.Text = "Disable scheduled tasks";
            this.GeneralToolTip.SetToolTip(this.SettingsDisableTasksCheckBox, "Disable all scheduled tasks from waking up the computer automatically");
            this.SettingsDisableTasksCheckBox.CheckedChanged += SettingsDisableAllCheckBoxCheckedChanged;
            // 
            // SettingsRunOnStartupCheckBox
            // 
            this.SettingsRunOnStartupCheckBox.AutoSize = true;
            this.SettingsRunOnStartupCheckBox.Location = new Point(3, 120);
            this.SettingsRunOnStartupCheckBox.Name = "SettingsRunOnStartupCheckBox";
            this.SettingsRunOnStartupCheckBox.Size = new Size(104, 19);
            this.SettingsRunOnStartupCheckBox.TabIndex = 6;
            this.SettingsRunOnStartupCheckBox.Text = "Run on startup";
            this.GeneralToolTip.SetToolTip(this.SettingsRunOnStartupCheckBox, "Run app on startup");
            this.SettingsRunOnStartupCheckBox.CheckedChanged += SettingsRunOnStartupCheckBoxCheckedChanged;
            // 
            // SettingsUserLanguageFlowLayoutPanel
            // 
            this.SettingsUserLanguageFlowLayoutPanel.AutoSize = true;
            this.SettingsUserLanguageFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.SettingsUserLanguageFlowLayoutPanel.Controls.Add(this.SettingsUserLanguageLabel);
            this.SettingsUserLanguageFlowLayoutPanel.Controls.Add(this.SettingsUserLanguageComboBox);
            this.SettingsUserLanguageFlowLayoutPanel.Location = new Point(3, 145);
            this.SettingsUserLanguageFlowLayoutPanel.Name = "SettingsUserLanguageFlowLayoutPanel";
            this.SettingsUserLanguageFlowLayoutPanel.Size = new Size(192, 29);
            this.SettingsUserLanguageFlowLayoutPanel.TabIndex = 7;
            this.SettingsUserLanguageFlowLayoutPanel.WrapContents = false;
            // 
            // SettingsUserLanguageLabel
            // 
            this.SettingsUserLanguageLabel.Anchor = AnchorStyles.Left;
            this.SettingsUserLanguageLabel.AutoSize = true;
            this.SettingsUserLanguageLabel.Location = new Point(3, 7);
            this.SettingsUserLanguageLabel.Name = "SettingsUserLanguageLabel";
            this.SettingsUserLanguageLabel.Size = new Size(59, 15);
            this.SettingsUserLanguageLabel.TabIndex = 0;
            this.SettingsUserLanguageLabel.Text = "Language";
            // 
            // SettingsUserLanguageComboBox
            // 
            this.SettingsUserLanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.SettingsUserLanguageComboBox.Items.AddRange(new object[] { "English", "Deutsch" });
            this.SettingsUserLanguageComboBox.Location = new Point(68, 3);
            this.SettingsUserLanguageComboBox.MaxDropDownItems = 2;
            this.SettingsUserLanguageComboBox.Name = "SettingsUserLanguageComboBox";
            this.SettingsUserLanguageComboBox.Size = new Size(121, 23);
            this.SettingsUserLanguageComboBox.TabIndex = 7;
            this.SettingsUserLanguageComboBox.SelectedValueChanged += SettingsUserLanguageComboBox_SelectedValueChanged;
            // 
            // SettingsTableLayoutPanel
            // 
            this.SettingsTableLayoutPanel.ColumnCount = 2;
            this.SettingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.SettingsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.SettingsTableLayoutPanel.Controls.Add(this.SettingsSaveButton, 0, 0);
            this.SettingsTableLayoutPanel.Controls.Add(this.SettingsLabel, 0, 0);
            this.SettingsTableLayoutPanel.Dock = DockStyle.Top;
            this.SettingsTableLayoutPanel.Location = new Point(0, 0);
            this.SettingsTableLayoutPanel.Name = "SettingsTableLayoutPanel";
            this.SettingsTableLayoutPanel.RowCount = 1;
            this.SettingsTableLayoutPanel.RowStyles.Add(new RowStyle());
            this.SettingsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.SettingsTableLayoutPanel.Size = new Size(396, 31);
            this.SettingsTableLayoutPanel.TabIndex = 0;
            // 
            // SettingsSaveButton
            // 
            this.SettingsSaveButton.AutoSize = true;
            this.SettingsSaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.SettingsSaveButton.Location = new Point(308, 3);
            this.SettingsSaveButton.Name = "SettingsSaveButton";
            this.SettingsSaveButton.Size = new Size(85, 25);
            this.SettingsSaveButton.TabIndex = 8;
            this.SettingsSaveButton.Text = "Save settings";
            this.SettingsSaveButton.Click += SettingsSaveButtonClick;
            // 
            // SettingsLabel
            // 
            this.SettingsLabel.AutoEllipsis = true;
            this.SettingsLabel.Dock = DockStyle.Fill;
            this.SettingsLabel.Location = new Point(3, 0);
            this.SettingsLabel.Name = "SettingsLabel";
            this.SettingsLabel.Size = new Size(299, 31);
            this.SettingsLabel.TabIndex = 0;
            this.SettingsLabel.Text = "Settings";
            this.SettingsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DevicesTabPage
            // 
            this.DevicesTabPage.Controls.Add(this.DevicesTreeView);
            this.DevicesTabPage.Controls.Add(this.DevicesTableLayoutPanel);
            this.DevicesTabPage.Location = new Point(4, 24);
            this.DevicesTabPage.Name = "DevicesTabPage";
            this.DevicesTabPage.Size = new Size(396, 211);
            this.DevicesTabPage.TabIndex = 0;
            this.DevicesTabPage.Text = "Devices";
            this.DevicesTabPage.UseVisualStyleBackColor = true;
            // 
            // DevicesTreeView
            // 
            this.DevicesTreeView.BorderStyle = BorderStyle.None;
            this.DevicesTreeView.CheckBoxes = true;
            this.DevicesTreeView.Dock = DockStyle.Fill;
            this.DevicesTreeView.Location = new Point(0, 31);
            this.DevicesTreeView.Name = "DevicesTreeView";
            this.DevicesTreeView.Size = new Size(396, 180);
            this.DevicesTreeView.TabIndex = 3;
            this.DevicesTreeView.AfterCheck += DevicesTreeViewAfterCheck;
            // 
            // DevicesTableLayoutPanel
            // 
            this.DevicesTableLayoutPanel.ColumnCount = 2;
            this.DevicesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.DevicesTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.DevicesTableLayoutPanel.Controls.Add(this.DevicesRefreshButton, 1, 0);
            this.DevicesTableLayoutPanel.Controls.Add(this.DevicesLabel, 0, 0);
            this.DevicesTableLayoutPanel.Dock = DockStyle.Top;
            this.DevicesTableLayoutPanel.Location = new Point(0, 0);
            this.DevicesTableLayoutPanel.Name = "DevicesTableLayoutPanel";
            this.DevicesTableLayoutPanel.RowCount = 1;
            this.DevicesTableLayoutPanel.RowStyles.Add(new RowStyle());
            this.DevicesTableLayoutPanel.Size = new Size(396, 31);
            this.DevicesTableLayoutPanel.TabIndex = 0;
            // 
            // DevicesRefreshButton
            // 
            this.DevicesRefreshButton.AutoSize = true;
            this.DevicesRefreshButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.DevicesRefreshButton.Location = new Point(337, 3);
            this.DevicesRefreshButton.Name = "DevicesRefreshButton";
            this.DevicesRefreshButton.Size = new Size(56, 25);
            this.DevicesRefreshButton.TabIndex = 2;
            this.DevicesRefreshButton.Text = "Refresh";
            this.DevicesRefreshButton.Click += DevicesRefreshButtonClick;
            // 
            // DevicesLabel
            // 
            this.DevicesLabel.AutoEllipsis = true;
            this.DevicesLabel.Dock = DockStyle.Fill;
            this.DevicesLabel.Location = new Point(3, 0);
            this.DevicesLabel.Name = "DevicesLabel";
            this.DevicesLabel.Size = new Size(328, 31);
            this.DevicesLabel.TabIndex = 0;
            this.DevicesLabel.Text = "Devices that may wake the computer";
            this.DevicesLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TasksTabPage
            // 
            this.TasksTabPage.Controls.Add(this.TasksTreeView);
            this.TasksTabPage.Controls.Add(this.TasksTableLayoutPanel);
            this.TasksTabPage.Location = new Point(4, 24);
            this.TasksTabPage.Name = "TasksTabPage";
            this.TasksTabPage.Size = new Size(396, 211);
            this.TasksTabPage.TabIndex = 0;
            this.TasksTabPage.Text = "Tasks";
            this.TasksTabPage.UseVisualStyleBackColor = true;
            // 
            // TasksTreeView
            // 
            this.TasksTreeView.BorderStyle = BorderStyle.None;
            this.TasksTreeView.CheckBoxes = true;
            this.TasksTreeView.Dock = DockStyle.Fill;
            this.TasksTreeView.Location = new Point(0, 31);
            this.TasksTreeView.Name = "TasksTreeView";
            this.TasksTreeView.Size = new Size(396, 180);
            this.TasksTreeView.TabIndex = 4;
            this.TasksTreeView.AfterCheck += TasksTreeViewAfterCheck;
            // 
            // TasksTableLayoutPanel
            // 
            this.TasksTableLayoutPanel.ColumnCount = 3;
            this.TasksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.TasksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.TasksTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.TasksTableLayoutPanel.Controls.Add(this.TasksLabel, 0, 0);
            this.TasksTableLayoutPanel.Controls.Add(this.TasksDisableTasksCheckBox, 1, 0);
            this.TasksTableLayoutPanel.Controls.Add(this.TasksRefreshButton, 2, 0);
            this.TasksTableLayoutPanel.Dock = DockStyle.Top;
            this.TasksTableLayoutPanel.Location = new Point(0, 0);
            this.TasksTableLayoutPanel.Name = "TasksTableLayoutPanel";
            this.TasksTableLayoutPanel.RowCount = 1;
            this.TasksTableLayoutPanel.RowStyles.Add(new RowStyle());
            this.TasksTableLayoutPanel.Size = new Size(396, 31);
            this.TasksTableLayoutPanel.TabIndex = 0;
            // 
            // TasksLabel
            // 
            this.TasksLabel.AutoEllipsis = true;
            this.TasksLabel.Dock = DockStyle.Fill;
            this.TasksLabel.Location = new Point(3, 0);
            this.TasksLabel.Name = "TasksLabel";
            this.TasksLabel.Size = new Size(172, 31);
            this.TasksLabel.TabIndex = 0;
            this.TasksLabel.Text = "Tasks that may wake the computer";
            this.TasksLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TasksDisableTasksCheckBox
            // 
            this.TasksDisableTasksCheckBox.AutoSize = true;
            this.TasksDisableTasksCheckBox.Dock = DockStyle.Fill;
            this.TasksDisableTasksCheckBox.Location = new Point(181, 3);
            this.TasksDisableTasksCheckBox.Name = "TasksDisableTasksCheckBox";
            this.TasksDisableTasksCheckBox.Size = new Size(150, 25);
            this.TasksDisableTasksCheckBox.TabIndex = 2;
            this.TasksDisableTasksCheckBox.Text = "Disable scheduled tasks";
            this.GeneralToolTip.SetToolTip(this.TasksDisableTasksCheckBox, "Disable all scheduled tasks from waking up the computer automatically");
            this.TasksDisableTasksCheckBox.CheckedChanged += TasksDisableAllCheckBoxCheckedChanged;
            // 
            // TasksRefreshButton
            // 
            this.TasksRefreshButton.AutoSize = true;
            this.TasksRefreshButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.TasksRefreshButton.Location = new Point(337, 3);
            this.TasksRefreshButton.Name = "TasksRefreshButton";
            this.TasksRefreshButton.Size = new Size(56, 25);
            this.TasksRefreshButton.TabIndex = 3;
            this.TasksRefreshButton.Text = "Refresh";
            this.TasksRefreshButton.Click += TasksRefreshButtonClick;
            // 
            // ActionsPanel
            // 
            this.ActionsPanel.Controls.Add(this.ActionsTextBox);
            this.ActionsPanel.Controls.Add(this.ActionsTableLayoutPanel);
            this.ActionsPanel.Controls.Add(this.SettingsSetPowerStateButton);
            this.ActionsPanel.Dock = DockStyle.Fill;
            this.ActionsPanel.Location = new Point(0, 0);
            this.ActionsPanel.Name = "ActionsPanel";
            this.ActionsPanel.Size = new Size(404, 138);
            this.ActionsPanel.TabIndex = 0;
            // 
            // ActionsTextBox
            // 
            this.ActionsTextBox.BorderStyle = BorderStyle.None;
            this.ActionsTextBox.Dock = DockStyle.Fill;
            this.ActionsTextBox.Location = new Point(0, 56);
            this.ActionsTextBox.Multiline = true;
            this.ActionsTextBox.Name = "ActionsTextBox";
            this.ActionsTextBox.ReadOnly = true;
            this.ActionsTextBox.ScrollBars = ScrollBars.Both;
            this.ActionsTextBox.Size = new Size(404, 82);
            this.ActionsTextBox.TabIndex = 4;
            this.ActionsTextBox.WordWrap = false;
            // 
            // ActionsTableLayoutPanel
            // 
            this.ActionsTableLayoutPanel.AutoSize = true;
            this.ActionsTableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ActionsTableLayoutPanel.ColumnCount = 3;
            this.ActionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.ActionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.ActionsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            this.ActionsTableLayoutPanel.Controls.Add(this.ActionsShowLogButton, 0, 0);
            this.ActionsTableLayoutPanel.Controls.Add(this.ActionsLabel, 1, 0);
            this.ActionsTableLayoutPanel.Controls.Add(this.ActionsClearButton, 2, 0);
            this.ActionsTableLayoutPanel.Dock = DockStyle.Top;
            this.ActionsTableLayoutPanel.Location = new Point(0, 25);
            this.ActionsTableLayoutPanel.Name = "ActionsTableLayoutPanel";
            this.ActionsTableLayoutPanel.RowCount = 1;
            this.ActionsTableLayoutPanel.RowStyles.Add(new RowStyle());
            this.ActionsTableLayoutPanel.Size = new Size(404, 31);
            this.ActionsTableLayoutPanel.TabIndex = 2;
            // 
            // ActionsShowLogButton
            // 
            this.ActionsShowLogButton.AutoSize = true;
            this.ActionsShowLogButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ActionsShowLogButton.Location = new Point(3, 3);
            this.ActionsShowLogButton.Name = "ActionsShowLogButton";
            this.ActionsShowLogButton.Size = new Size(26, 25);
            this.ActionsShowLogButton.TabIndex = 2;
            this.ActionsShowLogButton.Text = "...";
            this.ActionsShowLogButton.Click += ActionsShowLogButtonClick;
            // 
            // ActionsLabel
            // 
            this.ActionsLabel.AutoEllipsis = true;
            this.ActionsLabel.Dock = DockStyle.Fill;
            this.ActionsLabel.Location = new Point(35, 0);
            this.ActionsLabel.Name = "ActionsLabel";
            this.ActionsLabel.Size = new Size(316, 31);
            this.ActionsLabel.TabIndex = 0;
            this.ActionsLabel.Text = "Actions";
            this.ActionsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ActionsClearButton
            // 
            this.ActionsClearButton.AutoSize = true;
            this.ActionsClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.ActionsClearButton.Location = new Point(357, 3);
            this.ActionsClearButton.Name = "ActionsClearButton";
            this.ActionsClearButton.Size = new Size(44, 25);
            this.ActionsClearButton.TabIndex = 3;
            this.ActionsClearButton.Text = "Clear";
            this.ActionsClearButton.Click += ActionsClearButtonClick;
            // 
            // SettingsSetPowerStateButton
            // 
            this.SettingsSetPowerStateButton.Dock = DockStyle.Top;
            this.SettingsSetPowerStateButton.Location = new Point(0, 0);
            this.SettingsSetPowerStateButton.Name = "SettingsSetPowerStateButton";
            this.SettingsSetPowerStateButton.Size = new Size(404, 25);
            this.SettingsSetPowerStateButton.TabIndex = 1;
            this.SettingsSetPowerStateButton.Text = "Set power state";
            // 
            // TrayContextMenuStrip
            // 
            this.TrayContextMenuStrip.BackColor = Color.FromArgb(43, 43, 43);
            this.TrayContextMenuStrip.Items.AddRange(new ToolStripItem[] { this.TrayOpenToolStripMenuItem, this.TraySwitchOffToolStripMenuItem });
            this.TrayContextMenuStrip.Name = "trayContextMenuStrip";
            this.TrayContextMenuStrip.ShowImageMargin = false;
            this.TrayContextMenuStrip.Size = new Size(156, 70);
            this.TrayContextMenuStrip.Renderer = new ToolStripProfessionalRenderer(new YMenuColorTable());
            // 
            // TrayOpenToolStripMenuItem
            // 
            this.TrayOpenToolStripMenuItem.ForeColor = Color.White;
            this.TrayOpenToolStripMenuItem.Name = "TrayOpenToolStripMenuItem";
            this.TrayOpenToolStripMenuItem.Size = new Size(155, 22);
            this.TrayOpenToolStripMenuItem.Text = "Open";
            this.TrayOpenToolStripMenuItem.Click += TrayOpenToolStripMenuItemClick;
            // 
            // TraySwitchOffToolStripMenuItem
            // 
            this.TraySwitchOffToolStripMenuItem.ForeColor = Color.White;
            this.TraySwitchOffToolStripMenuItem.Name = "TraySwitchOffToolStripMenuItem";
            this.TraySwitchOffToolStripMenuItem.Size = new Size(155, 22);
            this.TraySwitchOffToolStripMenuItem.Text = "Switch off";
            this.TraySwitchOffToolStripMenuItem.Click += TrayHibernateToolStripMenuItemClick;
            // 
            // TrayNotifyIcon
            // 
            this.TrayNotifyIcon.ContextMenuStrip = this.TrayContextMenuStrip;
            this.TrayNotifyIcon.Text = "YNotifyIcon";
            this.TrayNotifyIcon.Visible = true;
            // 
            // YForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 381);
            Controls.Add(this.GeneralSplitContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "YForm";
            Text = "YForm";
            Resize += YFormResize;
            this.GeneralSplitContainer.Panel1.ResumeLayout(false);
            this.GeneralSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.GeneralSplitContainer).EndInit();
            this.GeneralSplitContainer.ResumeLayout(false);
            this.GeneralTabControl.ResumeLayout(false);
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsFlowLayoutPanel.ResumeLayout(false);
            this.SettingsFlowLayoutPanel.PerformLayout();
            this.SettingsDelayFlowLayoutPanel.ResumeLayout(false);
            this.SettingsDelayFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)this.SettingsDelayNumericUpDown).EndInit();
            this.SettingsPowerStateFlowLayoutPanel.ResumeLayout(false);
            this.SettingsPowerStateFlowLayoutPanel.PerformLayout();
            this.SettingsUserLanguageFlowLayoutPanel.ResumeLayout(false);
            this.SettingsUserLanguageFlowLayoutPanel.PerformLayout();
            this.SettingsTableLayoutPanel.ResumeLayout(false);
            this.SettingsTableLayoutPanel.PerformLayout();
            this.DevicesTabPage.ResumeLayout(false);
            this.DevicesTableLayoutPanel.ResumeLayout(false);
            this.DevicesTableLayoutPanel.PerformLayout();
            this.TasksTabPage.ResumeLayout(false);
            this.TasksTableLayoutPanel.ResumeLayout(false);
            this.TasksTableLayoutPanel.PerformLayout();
            this.ActionsPanel.ResumeLayout(false);
            this.ActionsPanel.PerformLayout();
            this.ActionsTableLayoutPanel.ResumeLayout(false);
            this.ActionsTableLayoutPanel.PerformLayout();
            this.TrayContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ToolTip GeneralToolTip;
        private Button SettingsSaveButton;
        private FlowLayoutPanel SettingsFlowLayoutPanel;
        private Panel ActionsPanel;
        private NotifyIcon TrayNotifyIcon;
        private YContextMenu TrayContextMenuStrip;
        private ToolStripMenuItem TrayOpenToolStripMenuItem;
        private ToolStripMenuItem TraySwitchOffToolStripMenuItem;
        private TabControl GeneralTabControl;
        private SplitContainer GeneralSplitContainer;
        private TabPage SettingsTabPage;
        private Label SettingsLabel;
        private TabPage DevicesTabPage;
        private TabPage TasksTabPage;
        private TableLayoutPanel SettingsTableLayoutPanel;
        private TableLayoutPanel DevicesTableLayoutPanel;
        private Label DevicesLabel;
        private TableLayoutPanel TasksTableLayoutPanel;
        private Label TasksLabel;
        private CheckBox TasksDisableTasksCheckBox;
        private FlowLayoutPanel SettingsUserLanguageFlowLayoutPanel;
        private YTreeView DevicesTreeView;
        private Button TasksRefreshButton;
        private YTreeView TasksTreeView;
        private TextBox ActionsTextBox;
        private TableLayoutPanel ActionsTableLayoutPanel;
        private Button ActionsShowLogButton;
        private Label ActionsLabel;
        private Button ActionsClearButton;
        private Label SettingsUserLanguageLabel;
        private ComboBox SettingsUserLanguageComboBox;
        private FlowLayoutPanel SettingsDelayFlowLayoutPanel;
        private Label SettingsDelayLabel;
        private NumericUpDown SettingsDelayNumericUpDown;
        private Label SettingsDelaySecondsLabel;
        private FlowLayoutPanel SettingsPowerStateFlowLayoutPanel;
        private Label SettingsPowerStateLabel;
        private ComboBox SettingsPowerStateComboBox;
        private CheckBox SettingsForceCriticalCheckBox;
        private CheckBox SettingsDisableTasksCheckBox;
        private CheckBox SettingsRunOnStartupCheckBox;
        private Button DevicesRefreshButton;
        private Button SettingsSetPowerStateButton;
    }
}