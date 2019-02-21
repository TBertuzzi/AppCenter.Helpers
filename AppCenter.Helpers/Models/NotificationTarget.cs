using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models
{
    public class NotificationTarget
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("devices")]
        public List<string> Devices { get; set; }
    }
}
