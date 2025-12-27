using CommunityToolkit.Mvvm.ComponentModel;
using Snipcode.Core.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Snipcode.WPF.MVVM.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        private MainViewModel _mainViewModel;

        [ObservableProperty]
        private ObservableCollection<Snippet> _recentSnippets;
        public DashboardViewModel(MainViewModel mainViewModel)
        {
            _mainViewModel = mainViewModel;
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
        }
    }
}
