using LagDaemon.StoryTeller.UI.Interfaces;
using LagDaemon.StoryTeller.UI.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.UI.ViewModels
{
    public class DockManagerViewModel : ViewModelBase
    {

        public DockManagerViewModel()
        {
            Documents = new ObservableCollection<ViewModelBase>();
            var vm = new DockWindowViewModel { Title = "Test Window" };
            Documents.Add(vm);
            Tabs.Add(new RibbonTabViewModel() { Title = "File" });
            Tabs.Add(new RibbonTabViewModel() { Title = "Edit" });
            Tabs.Add(new RibbonTabViewModel() { Title = "View" });
            Tabs.Add(new RibbonTabViewModel() { Title = "Tools" });
            Tabs.Add(new RibbonTabViewModel() { Title = "Project" });
            Tabs.Add(new RibbonTabViewModel() { Title = "Help" });
        }

        public ObservableCollection<RibbonTabViewModel> Tabs { get; private set; } = new ObservableCollection<RibbonTabViewModel>();

        public ObservableCollection<ViewModelBase> Documents { get; private set; }
        public string Title { get { return "Test"; } }
    }
}
