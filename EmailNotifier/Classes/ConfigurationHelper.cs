using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotifier.Interfaces;
using System.Configuration;

namespace EmailNotifier.Classes
{
    public class ConfigurationHelper : IConfigurationHelper
    {
        public string EmailPassword => ConfigurationManager.AppSettings["EmailPassword"];

        public string FromAddress => ConfigurationManager.AppSettings["FromAddress"];

        public string KaylaShows => ConfigurationManager.AppSettings["KaylaShows"];
    }
}
