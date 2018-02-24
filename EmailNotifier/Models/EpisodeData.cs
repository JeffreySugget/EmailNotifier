using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmailNotifier.Models
{
    class EpisodeData
    {
        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        [JsonProperty(PropertyName = "episode")]
        public Episode Episode { get; set; }

        [JsonProperty(PropertyName = "series")]
        public Series Series { get; set; }
    }
}
