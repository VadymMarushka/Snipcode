using Snipcode.Data.Interfaces;
using Snipcode.WPF.MVVM.ViewModels;
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
using Wpf.Ui.Appearance;
using Wpf.Ui.Controls;

namespace Snipcode.WPF
{
    public partial class MainWindow : FluentWindow
    {
        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            this.DataContext = mainViewModel;
            SystemThemeWatcher.Watch(this);
            ApplicationThemeManager.ApplySystemTheme();
        }
    }
}