using Castle.Core;
using Castle.MicroKernel.Facilities;
using LagDaemon.StoryTeller.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.UI.Utilities
{
    public class ViewActivatorFacility : AbstractFacility
    {
        protected override void Init()
        {
            Kernel.ComponentModelCreated += Kernel_ComponentModelCreated;
        }

        private void Kernel_ComponentModelCreated(ComponentModel model)
        {
            var isView = typeof(IView).IsAssignableFrom(Type.GetType(model.ComponentName.ToString()));
            if (!isView) return;
            if (model.CustomComponentActivator == null)
                model.CustomComponentActivator = typeof(WPFWindowActivator);
        }
    }
}
