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
            var subjectLines = new List<string>();

            foreach (var e in data.Episodes)
            {
                if (e.EventType == "grabbed")
                {
                    foreach (var s in kaylaShows)
                    {
                        if (e.Series.Title.ToLower() == s.ToLower())
                        {
                            if (DateTime.Parse(e.Date) >= DateTime.UtcNow.AddMinutes(-15))
                            {
                                CreateShowList(e, subjectLines);
                            }
                        }
                    }
                }
            }

            if (subjectLines.Count > 0)
            {
                SendEmail(subjectLines);
            }
        }

        private void CreateShowList(EpisodeData episodeData, List<string> subjectLines)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Series: {episodeData.Series.Title}");
            sb.AppendLine();
            sb.AppendLine($"Episode Title: {episodeData.Episode.Title}");
            sb.AppendLine();
            sb.AppendLine($"Episode Number: {episodeData.Episode.EpisodeNumber}");
            sb.AppendLine();

            subjectLines.Add(sb.ToString());
        }

        private void SendEmail(List<string> subjectLines)
        {
            var sb = new StringBuilder();

            sb.AppendLine("The following shows have been downloaded");
            sb.AppendLine();
            
            foreach (var l in subjectLines)
            {
                sb.AppendLine(l);
            }

            var email = _emailHelper.CreateEmail(sb.ToString(), "Shows Downloaded", "jeffrey.sugget@gmail.com");

            _emailHelper.SendEmail(email);
        }
    }
}
