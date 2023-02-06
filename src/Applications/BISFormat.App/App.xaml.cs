using BISFormat.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

namespace BISFormat
{
    public partial class App : Application
    {
        private IServiceProvider _serviceProvider;

        public App()
        {
            _serviceProvider = Architecture.Startup.ConfigureServices().BuildServiceProvider();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            _serviceProvider.GetService<IAppManager>().StartApp();
        }
    }
}
