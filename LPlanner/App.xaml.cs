using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LPlanner
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string ConfigPath = "config.ini";
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            #region Настройка контейнера
            IServiceCollection services = new ServiceCollection();

            if (!File.Exists(ConfigPath))
            {
                using (File.Create(ConfigPath)) { }
            }
            var configBuilder = new ConfigurationBuilder().AddIniFile(ConfigPath);
            IConfiguration config = configBuilder.Build();
            services.AddSingleton<IConfiguration>(config);

            services.AddTransient<MainWindow, MainWindow>();
            #endregion

            var provider = services.BuildServiceProvider();

            #region Запуск основного окна
            MainWindow mainWindow = provider.GetService<MainWindow>();
            mainWindow.Show();
            #endregion
        }
    }
}
