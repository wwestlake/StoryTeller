using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LagDaemon.StoryTeller.UI.ViewModels
{
    public class RibbonViewModel : ViewModelBase
    {
        public string Title { get; set; }
    }

    public class RibbonTabViewModel : RibbonViewModel
    {
        public ObservableCollection<RibbonGroupViewModel> Groups { get; set; }
    }

    public class RibbonGroupViewModel : RibbonViewModel
    {
        public ObservableCollection<RibbonButtonViewModel> Items { get; set; }
    }

    public class RibbonButtonViewModel : RibbonViewModel
    {
        public ICommand ClickedCommand => new DelegateCommand<RibbonViewModel>( (vm) =>
        {
            var a = vm;
        }); 
    }
}
