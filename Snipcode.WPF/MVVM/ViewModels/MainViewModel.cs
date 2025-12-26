using CommunityToolkit.Mvvm.ComponentModel;
using Snipcode.Core.Entities;
using Snipcode.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private readonly ISnipcodeDataService _dataService;

        [ObservableProperty]
        private ObservableObject _selectedViewModel;

        [ObservableProperty]
        private string _title;
        public MainViewModel(ISnipcodeDataService dataService)
        {
            _dataService = dataService;
            SelectedViewModel = new DashboardViewModel(this);
        }
        partial void OnSelectedViewModelChanged(ObservableObject value)
        {
            if (value is DashboardViewModel) Title = "Snipcode";
            else if (value is EditorViewModel editorViewModel) Title = (editorViewModel.CurrentSnippet != null) ? "Edit Snippet" : "New Snippet";
            else if (value is OpenViewModel) Title = "Open snippet";
            else if (value is ReadViewModel readViewModel) Title = readViewModel.CurrentSnippet.Title;
            else Title = "Snipcode";
        }
    }
}
