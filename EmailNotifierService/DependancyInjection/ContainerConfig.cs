using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using ApiLibrary.Classes;
using ApiLibrary.Interfaces;
using EmailNotifierService.Interfaces;
using EmailNotifierService.Classes;

namespace EmailNotifierService.DependancyInjection
{
    public class ContainerConfig
    {
        public static void ConfigureContainer(IUnityContainer container)
        {
            container.RegisterType<IEmailHelper, EmailHelper>();
            container.RegisterType<IConfigurationHelper, ConfigurationHelper>();
            container.RegisterType<IApiHelper, ApiHelper>();
            container.RegisterType<IDataProcessor, DataProcessor>();
            container.RegisterType<IDataHelper, DataHelper>();
        }
    }
}
