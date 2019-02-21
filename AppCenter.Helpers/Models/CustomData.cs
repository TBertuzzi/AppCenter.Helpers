using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models
{
    public class CustomData
    {
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }
        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }
        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }
}
