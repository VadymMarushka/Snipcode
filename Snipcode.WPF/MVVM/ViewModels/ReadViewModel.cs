using CommunityToolkit.Mvvm.ComponentModel;
using Snipcode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class ReadViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        [ObservableProperty]
        private Snippet _currentSnippet;

        public ReadViewModel(MainViewModel mainViewModel, Snippet currentSnippet)
        {
            _mainViewModel = mainViewModel;
            CurrentSnippet = currentSnippet;
        }
    }
}
