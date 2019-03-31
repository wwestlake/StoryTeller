using Castle.Core.Logging;
using Castle.Windsor;
using LagDaemon.StoryTeller.UI.Interfaces;
using LagDaemon.StoryTeller.UI.Utilities;
using LagDaemon.StoryTeller.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LagDaemon.StoryTeller.UI
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool _checked;
        private IWindsorContainer _container;
        private ILogger _log;

        public MainWindowViewModel(IWindsorContainer container, ILogger log, DockManagerViewModel dockManagerViewModel)
        {
            _container = container;
            _log = log;
            DockManagerViewModel = dockManagerViewModel;
        }

        public IViewModel DockManagerViewModel { get; private set; }

 



    }
}
