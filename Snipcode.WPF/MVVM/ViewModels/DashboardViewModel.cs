using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;
        public DashboardViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
    }
}
