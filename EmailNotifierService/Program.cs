using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Unity;
using EmailNotifierService.DependancyInjection;

namespace EmailNotifierService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            var container = new UnityContainer();
            ContainerConfig.ConfigureContainer(container);

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new EmailService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
