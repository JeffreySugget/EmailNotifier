using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiLibrary.Models
{
    public class SeriesRoot
    {
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }
    }
}
