using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using LagDaemon.StoryTeller.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LagDaemon.StoryTeller.UI
{
    public class UIContainerInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Classes.FromThisAssembly().BasedOn<IViewModel>().LifestyleSingleton()
            );
            container.Register(
                Classes.FromThisAssembly().BasedOn<IView>().LifestyleSingleton()
            );
        }
    }
}
