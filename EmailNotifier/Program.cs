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
            var container = new UnityContainer();
            container.RegisterType<IEmailHelper, EmailHelper>();
            container.RegisterType<IConfigurationHelper, ConfigurationHelper>();
            container.RegisterType<IApiHelper, ApiHelper>();
            container.RegisterType<IDataProcessor, DataProcessor>();
            container.RegisterType<IDatabaseHelper, DatabaseHelper>();

            var databaseHelper = container.Resolve<IDatabaseHelper>();

            databaseHelper.CreateDatabase();

            var dataProcessor = container.Resolve<IDataProcessor>();

            dataProcessor.ProcessOtherShows();
        }
    }
}
