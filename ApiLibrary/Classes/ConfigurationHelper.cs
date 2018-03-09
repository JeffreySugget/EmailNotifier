using System.Configuration;
using ApiLibrary.Interfaces;

namespace ApiLibrary.Classes
{
    public class ConfigurationHelper : IConfigurationHelper
    {
        public string EmailPassword => ConfigurationManager.AppSettings["EmailPassword"];

        public string FromAddress => ConfigurationManager.AppSettings["FromAddress"];

        public string KaylaShows => ConfigurationManager.AppSettings["KaylaShows"];

        public string ConnectionString => ConfigurationManager.ConnectionStrings["SonarrConnString"].ConnectionString;
    }
}
