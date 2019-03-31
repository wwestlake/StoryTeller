using LagDaemon.StoryTeller.UI.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.UI.ViewModels
{
    public class NewMenuItemViewModel : MenuItemViewModel
    {
        public NewMenuItemViewModel(MenuItemViewModel parent) : base(parent)
        {
            Header = "_New";
            Command = new RelayCommand<bool>((x) => { });
            LoadChildMenuItems();
        }

    }
}
