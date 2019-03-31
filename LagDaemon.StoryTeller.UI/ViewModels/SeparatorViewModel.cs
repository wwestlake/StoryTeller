using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.UI.ViewModels
{
    public class SeparatorViewModel : MenuItemViewModel
    {
        public SeparatorViewModel(MenuItemViewModel parentViewModel)
            : base(parentViewModel)
        {

        }

        public override void LoadChildMenuItems()
        {
            base.LoadChildMenuItems();
        }
    }
}
