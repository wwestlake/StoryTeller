using LagDaemon.StoryTeller.UI.Interfaces;
using LagDaemon.StoryTeller.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.UI.ViewModels
{
    public class FileMenuItemViewModel : MenuItemViewModel, IViewModel
    {
        public FileMenuItemViewModel() : base(null)
        {
            Header = "_File";
            Command = new RelayCommand<bool>((x) => { } );
            LoadChildMenuItems();
        }

 
        public override void LoadChildMenuItems()
        {
            ChildMenuItems.Add(new NewMenuItemViewModel(this));
        }
    }
}
