using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AppCenter.Helpers.Models;
using HttpExtension;
using Newtonsoft.Json;
using System.Linq;
using AppCenter.Helpers.Base;

namespace AppCenter.Helpers.Push
{
    public sealed class PushNotification : BaseHttpClient
    {
        public PushNotification(Config config) 
            : base(config)
        {

        }

        public ServiceResponse<Notification> SendPushNotification(Notification notification)
            => SendPushNotificationAsync(notification).Result;

        public async Task<ServiceResponse<Notification>>
            SendPushNotificationAsync(Notification notification)
        {
            var response = await this.PostAsync<Notification>("push/notifications", notification);
            return response;
        }

        public ServiceResponse<NotificationResult> GetPushNotifications()
           => GetPushNotificationsAsync().Result;

        public async Task<ServiceResponse<NotificationResult>>
            GetPushNotificationsAsync()
        {
            var response = await this.GetAsync<NotificationResult>("push/notifications");
            return response;
        }

        public ServiceResponse<NotificationResult> GetPushNotificationById(string notificationId)
           => GetPushNotificationByIdAsync(notificationId).Result;

        public async Task<ServiceResponse<NotificationResult>>
          GetPushNotificationByIdAsync(string notificationId)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("notification_id", notificationId);

            var response = await this.GetAsync<NotificationResult>("push/notifications", parameters);
            return response;
        }
    }
}
