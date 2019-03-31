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
            Documents = new ObservableCollection<IView>();
            var vm = new DockWindowViewModel { Title = "Test Window" };
            Documents.Add(new SimpleWindow(vm) { DataContext = vm } );
        }

        public ObservableCollection<IView> Documents { get; private set; }
        public string Title { get { return "Test"; } }
    }
}
