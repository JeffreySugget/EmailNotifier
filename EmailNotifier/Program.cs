using EmailNotifier.Classes;
using EmailNotifier.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using ApiLibrary.Interfaces;
using ApiLibrary.Classes;

namespace EmailNotifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: move DI code to own class
            var container = new UnityContainer();
            container.RegisterType<IEmailHelper, EmailHelper>();
            container.RegisterType<IConfigurationHelper, ConfigurationHelper>();
            container.RegisterType<IApiHelper, ApiHelper>();
            container.RegisterType<IDataProcessor, DataProcessor>();
            container.RegisterType<IDataHelper, DataHelper>();

            var dataProcessor = container.Resolve<IDataProcessor>();

            dataProcessor.ProcessShows();
            dataProcessor.ProcessOtherShows();
        }
    }
}
