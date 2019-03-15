using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models.Analytic
{
    public class Event
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("device_count")]
        public long DeviceCount { get; set; }

        [JsonProperty("previous_device_count")]
        public long PreviousDeviceCount { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("previous_count")]
        public long PreviousCount { get; set; }

        [JsonProperty("count_per_device")]
        public long CountPerDevice { get; set; }

        [JsonProperty("count_per_session")]
        public long CountPerSession { get; set; }
    }
}
