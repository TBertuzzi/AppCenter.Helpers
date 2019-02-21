using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models
{
    public class Notification
    {
        [JsonProperty("notification_target")]
        public NotificationTarget NotificationTarget { get; set; }
        [JsonProperty("notification_content")]
        public NotificationContent NotificationContent { get; set; }
    }
}
