using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Core.Logging;
using Castle.Services.Logging.Log4netIntegration;
using LagDaemon.StoryTeller.UI;
using LagDaemon.StoryTeller.UI.Utilities;
using LagDaemon.StoryTeller.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Facilities.Logging;
using LagDaemon.StoryTeller.Utilities;

namespace LagDaemon.StoryTeller.Startup
{
    class Program
    {
        private static IWindsorContainer _container;

        [STAThread]
        static void Main(string[] args)
        {
            _container = new WindsorContainer();
            _container.AddFacility<ViewActivatorFacility>();
            _container.AddFacility<LoggingFacility>(f => f.LogUsing<Log4netFactory>().WithConfig("log4net.xml"));
            ILogger log = _container.Resolve<ILogger>();
            var name = ApplicationInformation.Name();
            log.Info("{0} -- Starting", name);


            _container.Register(Component.For<IWindsorContainer>().Instance(_container));
            _container.Install(new UIContainerInstaller());


            var app = new App();
            
            app.Run(_container.Resolve<MainWindow>());
        }
    }
}
