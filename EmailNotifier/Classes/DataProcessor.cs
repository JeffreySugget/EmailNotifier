using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailNotifier.Interfaces;
using EmailNotifier.Models;
using Newtonsoft.Json;

namespace EmailNotifier.Classes
{
    public class DataProcessor : IDataProcessor
    {
        private readonly IApiHelper _apiHelper;
        private readonly IConfigurationHelper _configurationHelper;
        private readonly IEmailHelper _emailHelper;

        public DataProcessor(IApiHelper apiHelper, IConfigurationHelper configurationHelper, IEmailHelper emailHelper)
        {
            _apiHelper = apiHelper;
            _configurationHelper = configurationHelper;
            _emailHelper = emailHelper;
        }

        public void ProcessKaylaShows()
        {
            var json = _apiHelper.Get();
            var data = JsonConvert.DeserializeObject<DownloadsRoot>(json);

            var kaylaShows = _configurationHelper.KaylaShows.Split('|');
            var listOfShows = new List<Episode>();

            foreach (var e in data.Episodes)
            {
                foreach (var s in kaylaShows)
                {
                    if (e.Series.Title == s)
                    {
                        if (DateTime.Parse(e.Date) >= DateTime.UtcNow.AddMinutes(-15))
                        {
                            listOfShows.Add(e.Episode);
                        }
                    }
                }
            }

            if (listOfShows.Count > 0)
            {
                SendEmail(listOfShows);
            }
        }

        private void SendEmail(List<Episode> shows)
        {
            
        }
    }
}
