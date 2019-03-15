using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models.Analytic
{
    public class AnalyticsEvent
    {
        [JsonProperty("events")]
        public List<Event> Events { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("total_devices")]
        public long TotalDevices { get; set; }
    }
}
