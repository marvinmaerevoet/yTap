using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using YY.Logging;

namespace YY.Configuration;

internal static class YResourceManager {
    internal static Stream LoadEmbeddedResource(string resourceName) {
        try {
            Stream? dataStream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"YApp.Resources.{resourceName}");
            YLog.Info($"Load embedded resource - ResourceName: {resourceName}");
            return dataStream ?? throw new ArgumentException($"Resource '{resourceName}' not found in assembly.");
        } catch(Exception ex) {
            YLog.Error(ex);
            throw;
        }
    }

    internal static IConfiguration GetConfiguration() {
        return new ConfigurationBuilder().AddJsonStream(LoadEmbeddedResource("AppConfig.json")).Build();
    }
}