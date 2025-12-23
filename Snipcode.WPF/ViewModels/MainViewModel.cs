using Snipcode.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Snipcode.WPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private readonly ISnipcodeDataService _dataService;
        public MainViewModel(ISnipcodeDataService dataService)
        {
            _dataService = dataService;
        }
        private BaseViewModel selectedViewModel;
        public BaseViewModel SelectedViewModel
        {
            get { return selectedViewModel; }
            set
            {
                selectedViewModel = value;
                OnPropertyChanged(); // Повідомляємо UI про зміну View.
            }
        }
    }
}
