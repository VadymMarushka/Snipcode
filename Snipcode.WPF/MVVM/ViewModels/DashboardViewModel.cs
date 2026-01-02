using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Snipcode.Core.Entities;
using Snipcode.Data.Interfaces;
using Snipcode.WPF.MVVM.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private readonly ISnipcodeDataService _snipcodeDataService;

        [ObservableProperty]
        private ObservableCollection<Snippet> _recentSnippets;

        [ObservableProperty]
        private object _currentDetailView;

        public DashboardViewModel(ISnipcodeDataService snipcodeDataService)
        {
            _snipcodeDataService = snipcodeDataService;
            RecentSnippets = new ObservableCollection<Snippet>
            {
                new Snippet{Code="",Title="1st snippet",Technology = Technology.Python,Category=new Category{ Name="Hobbies"}, Tags=new List<Tag>{ new Tag { Name="python"}, new Tag { Name = "AI" } } },
                new Snippet{Code="",Title="2nd snippet" , Technology=Technology.CSharp,Category=new Category{ Name="ASD"}, Tags=new List<Tag>{ new Tag { Name="CSharp"}, new Tag { Name = ".NET" } }},
                new Snippet{Code="",Title="3rd snippet" , Technology=Technology.JavaScript,Category=new Category{ Name="Work"}, Tags=new List<Tag>{ new Tag { Name="JavaScript"}, new Tag { Name = "Web" } }},
                                new Snippet{Code="",Title="1st snippet",Technology = Technology.Python,Category=new Category{ Name="Hobbies"}, Tags=new List<Tag>{ new Tag { Name="python"}, new Tag { Name = "AI" } } },
                new Snippet{Code="",Title="2nd snippet" , Technology=Technology.CSharp,Category=new Category{ Name="ASD"}, Tags=new List<Tag>{ new Tag { Name="CSharp"}, new Tag { Name = ".NET" } }},
                new Snippet{Code="",Title="3rd snippet" , Technology=Technology.JavaScript,Category=new Category{ Name="Work"}, Tags=new List<Tag>{ new Tag { Name="JavaScript"}, new Tag { Name = "Web" } }},
                                new Snippet{Code="",Title="1st snippet",Technology = Technology.Python,Category=new Category{ Name="Hobbies"}, Tags=new List<Tag>{ new Tag { Name="python"}, new Tag { Name = "AI" } } },
                new Snippet{Code="",Title="2nd snippet" , Technology=Technology.CSharp,Category=new Category{ Name="ASD"}, Tags=new List<Tag>{ new Tag { Name="CSharp"}, new Tag { Name = ".NET" } }},
                new Snippet{Code="",Title="3rd snippet" , Technology=Technology.JavaScript,Category=new Category{ Name="Work"}, Tags=new List<Tag>{ new Tag { Name="JavaScript"}, new Tag { Name = "Web" } }},
                                new Snippet{Code="",Title="1st snippet",Technology = Technology.Python,Category=new Category{ Name="Hobbies"}, Tags=new List<Tag>{ new Tag { Name="python"}, new Tag { Name = "AI" } } },
                new Snippet{Code="",Title="2nd snippet" , Technology=Technology.CSharp,Category=new Category{ Name="ASD"}, Tags=new List<Tag>{ new Tag { Name="CSharp"}, new Tag { Name = ".NET" } }},
                new Snippet{Code="",Title="3rd snippet" , Technology=Technology.JavaScript,Category=new Category{ Name="Work"}, Tags=new List<Tag>{ new Tag { Name="JavaScript"}, new Tag { Name = "Web" } }},
            };
            CurrentDetailView = new StarterView(this);
        }

        [RelayCommand]
        public void OpenSnippet(Snippet snippet)
        {
            CurrentDetailView = new SnippetView(snippet, this);
        }

        [RelayCommand]
        public void GoBackToStarter()
        {
            CurrentDetailView = new StarterView(this);
        }
    }
}
