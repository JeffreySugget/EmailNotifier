using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EmailNotifier.Models
{
    class SeriesRoot
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}
