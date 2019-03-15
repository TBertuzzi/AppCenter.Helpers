using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models
{
    public class NotificationResultContent
    {
        [JsonProperty("notification_id")]
        public string NotificationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notification_target")]
        public NotificationTarget NotificationTarget { get; set; }

        [JsonProperty("send_time")]
        public DateTimeOffset SendTime { get; set; }

        [JsonProperty("pns_send_failure")]
        public long PnsSendFailure { get; set; }

        [JsonProperty("pns_send_success")]
        public long PnsSendSuccess { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }
    }
}
