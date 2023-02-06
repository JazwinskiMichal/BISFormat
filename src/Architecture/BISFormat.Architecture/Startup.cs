using BISFormat.Interfaces;
using BISFormat.UI.Views;
using Microsoft.Extensions.DependencyInjection;

namespace BISFormat.Architecture
{
    public static class Startup
    {
        public static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new();

            services.AddSingleton<IStringTest, StringTest>();
            services.AddSingleton<MainWindowView>();
            services.AddSingleton<IAppManager, AppManager>();

            return services;
        }
    }
}
