using CommunityToolkit.Mvvm.ComponentModel;
using Snipcode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class EditorViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        [ObservableProperty]
        private Snippet? _currentSnippet;

        public EditorViewModel(MainViewModel mainViewModel, Snippet? currentSnippet = null)
        {
            _mainViewModel = mainViewModel;
            CurrentSnippet = currentSnippet;
        }
    }
}
