using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmailNotifier.Models
{
    class DownloadsRoot
    {
        [JsonProperty(PropertyName = "records")]
        public List<EpisodeData> Episodes { get; set; }
    }
}
