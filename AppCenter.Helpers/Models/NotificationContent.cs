using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models
{
    public class NotificationContent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("custom_data")]
        public CustomData CustomData { get; set; }
    }
}
