using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AppCenter.Helpers.Models
{
    public partial class NotificationResult
    {
        public static NotificationResult FromJson(string json) => JsonConvert.DeserializeObject<NotificationResult>(json, Settings);

        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };

        [JsonProperty("values")]
        public List<NotificationResultContent> ResultContent { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("nextLink")]
        public string NextLink { get; set; }
    }
}
