using Snipcode.Data.Interfaces;
using Snipcode.WPF.MVVM.ViewModels;
using Snipcode.WPF.MVVM.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui;
using Wpf.Ui.Abstractions;
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace Snipcode.WPF
{
    public partial class MainWindow : FluentWindow
    {
        public MainWindow(
                MainViewModel viewModel,
                INavigationService navigationService,
                IServiceProvider serviceProvider,
                INavigationViewPageProvider pageService)
        {
            InitializeComponent();
            DataContext = viewModel;
            RootNavigation.SetServiceProvider(serviceProvider);
            RootNavigation.SetPageProviderService(pageService);

            navigationService.SetNavigationControl(RootNavigation);
            Loaded += (_, _) => navigationService.Navigate(typeof(MVVM.Views.DashboardView));
        }
    }
}