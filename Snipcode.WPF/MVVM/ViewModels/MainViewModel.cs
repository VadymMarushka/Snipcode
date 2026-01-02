using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Snipcode.Core.Entities;
using Snipcode.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {

        [ObservableProperty]
        private string _title = "Snipcode";

        public MainViewModel()
        {

        }
    }
}
