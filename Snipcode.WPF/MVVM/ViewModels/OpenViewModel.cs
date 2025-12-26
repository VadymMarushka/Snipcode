using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class OpenViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;
        public OpenViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
        }
    }
}
