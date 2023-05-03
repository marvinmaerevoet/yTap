using Microsoft.Win32;
using Microsoft.Win32.TaskScheduler;
using YY.Logging;

namespace YY.Configuration;

internal class YSettingsManager {
    internal static Settings GetRegistrySettings(string registryKeyPath) {
        try {
            Settings settings = new();
            using RegistryKey? key = Registry.CurrentUser.OpenSubKey(registryKeyPath);
            if(key != null) {
                settings.UserLanguage = key.GetValue(nameof(settings.UserLanguage), "English").ToString() ?? "English";
                settings.Delay = int.Parse(key.GetValue(nameof(settings.Delay), 0).ToString() ?? "");
                if((key.GetValue(nameof(settings.Delay), 0).ToString() ?? "") == "Hibernate") {
                    settings.PowerState = PowerState.Hibernate;
                } else if((key.GetValue(nameof(settings.Delay), 0).ToString() ?? "") == "Suspend") {
                    settings.PowerState = PowerState.Suspend;
                }
                settings.IsTasksDisable = bool.Parse(key.GetValue(nameof(settings.IsTasksDisable), false).ToString() ?? "");
                settings.IsForceCritical = bool.Parse(key.GetValue(nameof(settings.IsForceCritical), false).ToString() ?? "");
                settings.IsRunOnStartup = bool.Parse(key.GetValue(nameof(settings.IsRunOnStartup), false).ToString() ?? "");
            }
            YLog.Info($"Get registry settings - Path: {registryKeyPath}, UserLanguage: {settings.UserLanguage}, Delay: {settings.Delay}, PowerState: {settings.PowerState}, IsTasksDisable: {settings.IsTasksDisable}, IsForceCritical: {settings.IsForceCritical}, IsRunOnStartup: {settings.IsRunOnStartup}");
            return settings;
        } catch(Exception ex) {
            YLog.Error(ex);
            return new Settings();
        }
    }

    internal static void SetRegistrySettings(string registryKeyPath, Settings settings) {
        try {
            using RegistryKey key = Registry.CurrentUser.CreateSubKey(registryKeyPath);
            if(key != null) {
                key.SetValue(nameof(settings.UserLanguage), settings.UserLanguage, RegistryValueKind.String);
                key.SetValue(nameof(settings.Delay), settings.Delay.ToString(), RegistryValueKind.String);
                key.SetValue(nameof(settings.PowerState), settings.PowerState.ToString(), RegistryValueKind.String);
                key.SetValue(nameof(settings.IsTasksDisable), settings.IsTasksDisable.ToString(), RegistryValueKind.String);
                key.SetValue(nameof(settings.IsForceCritical), settings.IsForceCritical.ToString(), RegistryValueKind.String);
                key.SetValue(nameof(settings.IsRunOnStartup), settings.IsRunOnStartup.ToString(), RegistryValueKind.String);
            }
            YLog.Info($"Set registry settings - Path: {registryKeyPath}, UserLanguage: {settings.UserLanguage}, Delay: {settings.Delay}, PowerState: {settings.PowerState}, IsTasksDisable: {settings.IsTasksDisable}, IsForceCritical: {settings.IsForceCritical}, IsRunOnStartup: {settings.IsRunOnStartup}");
        } catch(Exception ex) {
            YLog.Error(ex);
        }
    }

    internal static void SetRunOnStartup(bool isRunOnStartup) {
        try {
            if(isRunOnStartup == true) {
                TaskDefinition taskDefinition = TaskService.Instance.NewTask();
                taskDefinition.RegistrationInfo.Description = "yTap AutoStart";
                taskDefinition.Principal.RunLevel = TaskRunLevel.Highest;
                _ = taskDefinition.Triggers.Add(new LogonTrigger());
                _ = taskDefinition.Actions.Add(new ExecAction(Application.ExecutablePath, null, null));
                _ = TaskService.Instance.RootFolder.RegisterTaskDefinition("yTap_AutoStart", taskDefinition);
                YLog.Info($"Set scheduled Task");
            } else {
                TaskService.Instance.RootFolder.DeleteTask("yTap_AutoStart");
                YLog.Info($"Delete scheduled Task");
            }
        } catch(Exception ex) {
            YLog.Error(ex);
        }        
    }

    internal class Settings {
        internal string UserLanguage = "English";
        internal int Delay = 0;
        internal PowerState PowerState = PowerState.Suspend;
        internal bool IsTasksDisable = false;
        internal bool IsForceCritical = false;
        internal bool IsRunOnStartup = false;
    }
}
