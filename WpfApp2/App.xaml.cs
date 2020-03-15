using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            #region Настройка контейнера
            IServiceCollection services = new ServiceCollection();
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
