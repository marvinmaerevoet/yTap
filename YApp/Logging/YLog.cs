using Microsoft.Extensions.Configuration;
using Serilog;
using System.Globalization;
using YY.UI;

namespace YY.Logging;

internal static class YLog {
    private static string? LogFilePath;
    private static string? ActionsLogFilePath;
    private static ILogger? Logger;
    private static ILogger? ActionsLogger;

    private static void HandleUnknown(Exception? ex) {
        string message =
            $"Unknown error occurred. :( " +
            $"\n\r" +
            $"\n\r Find logs at:" +
            $"\n\r {LogFilePath}" +
            $"\n\r" +
            $"\n\r {ex}";
        YDialogBox.ShowError(message);
    }

    internal static void Action(string message) {
        ActionsLogger?.Information($"{message}");
    }

    internal static void Error(Exception ex) {
        Logger?.Error($"{ex}");
    }

    internal static void Info(string message) {
        Logger?.Information($"{message}");
    }

    /// Use this once to handle unhandled exceptions
    internal static void Unknown(object sender, UnhandledExceptionEventArgs exArgs) {
        Logger?.Fatal($"{exArgs.ExceptionObject}");
        Exception? ex = exArgs.ExceptionObject as Exception;
        HandleUnknown(ex);
    }

    internal static void Initialize(IConfiguration configuration) {

        string productManufacturer = configuration["ProductManufacturer"] ?? "yTap";
        string productName = configuration["ProductName"] ?? "yTap";

        LogFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), productManufacturer, productName);
        ActionsLogFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), productManufacturer, productName, "Actions");

        Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(Path.Combine(LogFilePath, "log-.txt"), rollingInterval: RollingInterval.Month, formatProvider: CultureInfo.InvariantCulture)
            .CreateLogger();

        ActionsLogger = new LoggerConfiguration()
            .MinimumLevel.Information()
            .WriteTo.File(Path.Combine(ActionsLogFilePath, "actionslog.txt"), rollingInterval: RollingInterval.Infinite, formatProvider: CultureInfo.InvariantCulture)
            .CreateLogger();

        Logger?.Information($"**** Logging initialized");
    }
}
