using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using YY.Configuration;
using YY.Logging;
using YY.UI;

namespace YY;
static class YProgram {
    private static ServiceCollection ConfigureServiceCollection() {
        ServiceCollection serviceCollection = new();
        _ = serviceCollection.AddSingleton<YForm>();
        return serviceCollection;
    }

    [STAThread]
    static void Main() {
        IConfiguration configuration = YResourceManager.GetConfiguration();

        using Mutex mutex = new(false, $@"Global\{Assembly.GetEntryAssembly()?.GetType().GUID}");
        if(!mutex.WaitOne(TimeSpan.Zero, false)) {
            YDialogBox.ShowInfo($"An instance of {configuration["ProductName"]} is already running");
            return;
        }
        YLog.Initialize(configuration);
        AppDomain.CurrentDomain.UnhandledException += YLog.Unknown;

        ApplicationConfiguration.Initialize();

        ServiceCollection serviceCollection = ConfigureServiceCollection();
        using ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
        YForm application = serviceProvider.GetService<YForm>() ?? new YForm();

        Application.Run(application);
    }
}
