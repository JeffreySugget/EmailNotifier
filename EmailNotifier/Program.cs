using EmailNotifier.Classes;
using EmailNotifier.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

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
            container.RegisterType<IDatabaseCreator, DatabaseCreator>();
            container.RegisterType<IDataHelper, DataHelper>();

            var databaseCreator = container.Resolve<IDatabaseCreator>();

            databaseCreator.CreateDatabase();

            var dataProcessor = container.Resolve<IDataProcessor>();

            dataProcessor.ProcessShows();
            dataProcessor.ProcessOtherShows();
        }
    }
}
