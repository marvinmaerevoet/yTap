using YY.Logging;

namespace YY.WakeManagement;

internal static partial class YPowerStateManager {
    internal static async void SetPowerStateAsync(int delay, PowerState powerState, bool forceCritical, bool isWakeDisable) {
        YLog.Info($"Set power state async - PowerState: {powerState}, ForceCritical: {forceCritical}, IsWakeDisable: {isWakeDisable}");
        await Task.Delay(delay*1000);
        _ = Application.SetSuspendState(powerState, forceCritical, isWakeDisable);
    }
}