using Newtonsoft.Json;
using YY.Logging;

namespace YY.Configuration;

internal class YGlossaryManager {
    internal static Localization GetLocalization(string userLanguage) {
        Stream glossaryStream = YResourceManager.LoadEmbeddedResource("Glossary.json");
        StreamReader glossaryStreamReader = new(glossaryStream);
        GlossaryObject? glossary = JsonConvert.DeserializeObject<GlossaryObject>(glossaryStreamReader.ReadToEnd());
        if(glossary != null) {
            switch(userLanguage) {
                case "English":
                    return glossary.En_US;
                case "Deutsch":
                    return glossary.De_DE;
                default:
                    return glossary.En_US;
            }
        }
        YLog.Info($"Get localization - Userlanguage: {userLanguage}");
        return new Localization();
    }

    internal class Localization {
        public string SettingsTabPage { get; set; }
        public string SettingsLabel { get; set; }
        public string SettingsSaveButton { get; set; }
        public string SettingsUserLanguageLabel { get; set; }
        public string SettingsDelayLabel { get; set; }
        public string SettingsDelaySecondsLabel { get; set; }
        public string SettingsPowerStateLabel { get; set; }
        public string SettingsPowerStateTooltip { get; set; }
        public string SettingsForceCriticalCheckBoxText { get; set; }
        public string SettingsForceCriticalCheckBoxToolTip { get; set; }
        public string SettingsDisableTasksCheckBoxText { get; set; }
        public string SettingsDisableTasksCheckBoxToolTip { get; set; }
        public string SettingsRunOnStartupCheckBoxText { get; set; }
        public string SettingsRunOnStartupCheckBoxTooltip { get; set; }
        public string DevicesTabPage { get; set; }
        public string DevicesLabel { get; set; }
        public string DevicesRefreshButton { get; set; }
        public string TasksTabPage { get; set; }
        public string TasksLabel { get; set; }
        public string TasksDisableTasksCheckBoxText { get; set; }
        public string TasksDisableTasksCheckBoxToolTip { get; set; }
        public string TasksRefreshButton { get; set; }
        public string ActionsLabel { get; set; }
        public string ActionsClearButton { get; set; }

        internal Localization() {
            SettingsTabPage = "Settings";
            SettingsUserLanguageLabel = "Language";
            SettingsDelayLabel = "Delay before switch off";
            SettingsDelaySecondsLabel = "(Seconds)";
            SettingsPowerStateLabel = "Power state";
            SettingsPowerStateTooltip = "Sets the power state of the computer.\r\nHibernate: Save session and shut down. (slow wake up)\r\nSuspend: Pause activities. (quick wake up)";
            SettingsForceCriticalCheckBoxText = "Force immediate switch off (not recommended)";
            SettingsForceCriticalCheckBoxToolTip = "Ignore currently running critical processes";
            SettingsDisableTasksCheckBoxText = "Disable scheduled tasks";
            SettingsDisableTasksCheckBoxToolTip = "Disable all scheduled tasks from waking up the computer automatically";
            SettingsRunOnStartupCheckBoxText = "Run on startup";
            SettingsRunOnStartupCheckBoxTooltip = "Run app on startup";
            SettingsSaveButton = "Save settings";
            SettingsLabel = "Settings";
            DevicesTabPage = "Devices";
            DevicesLabel = "Devices that may wake the computer";
            DevicesRefreshButton = "Refresh";
            TasksTabPage = "Tasks";
            TasksLabel = "Tasks that may wake the computer";
            TasksDisableTasksCheckBoxText = "Disable scheduled tasks";
            TasksDisableTasksCheckBoxToolTip = "Disable all scheduled tasks from waking up the computer automatically";
            TasksRefreshButton = "Refresh";
            ActionsLabel = "Actions";
            ActionsClearButton = "Clear";
        }
    }
    
    internal class GlossaryObject {
        public Localization En_US { internal get; set; }
        public Localization De_DE { internal get; set; }

        internal GlossaryObject() {
            En_US = new Localization();
            De_DE = new Localization();
        }
    }
}
