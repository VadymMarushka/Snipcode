using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Snipcode.Core.Entities;
using Snipcode.Data;
using Snipcode.Data.Interfaces;
using Snipcode.Data.Services;
using Snipcode.WPF.MVVM.ViewModels;
using Snipcode.WPF.MVVM.Views;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using Wpf.Ui;
using Wpf.Ui.DependencyInjection;

namespace Snipcode.WPF
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();
                    string path = Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                        "Snipcode"
                    );
                    Directory.CreateDirectory(path);
                    string dbPath = Path.Combine(path, "snipcode.db");
                    services.AddDbContextFactory<SnipcodeContext>(options =>
                        options.UseSqlite($"Data Source={dbPath}"));
                    services.AddTransient<ISnipcodeDataService, SnipcodeDataService>();

                    services.AddSingleton<INavigationService, NavigationService>();
                    services.AddNavigationViewPageProvider();

                    services.AddSingleton<MainViewModel>();
                    services.AddSingleton<DashboardViewModel>();

                    services.AddTransient<DashboardView>();
                    services.AddTransient<SettingsView>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }
}
