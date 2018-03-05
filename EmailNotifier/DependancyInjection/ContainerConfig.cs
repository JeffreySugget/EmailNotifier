using ApiLibrary.Classes;
using ApiLibrary.Interfaces;
using EmailNotifier.Classes;
using EmailNotifier.Interfaces;
using Unity;

namespace EmailNotifier.DependancyInjection
{
    public static class ContainerConfig
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
