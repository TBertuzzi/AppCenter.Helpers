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

namespace AppCenter.Helpers.Push
{
    public sealed class PushNotification
    {
        private readonly Config _config;
        private HttpClient _httpClient;
        public PushNotification(Config config)
        {
            _config = config;

            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(string.Format(EndPoints.RestApi,config.OwnerName,config.AppName));
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("X-API-Token", config.Token);

        }

        public ServiceResponse<Notification> SendPushNotification(Notification notification)
            => SendPushNotificationAsync(notification).Result;

        public async Task<ServiceResponse<Notification>>
            SendPushNotificationAsync(Notification notification)
        {
            var response = await _httpClient.PostAsync<Notification>("push/notifications", notification);
            return response;
        }

        public ServiceResponse<NotificationResult> GetPushNotifications()
           => GetPushNotificationsAsync().Result;

        public async Task<ServiceResponse<NotificationResult>>
            GetPushNotificationsAsync()
        {
            var response = await _httpClient.GetAsync<NotificationResult>("push/notifications");
            return response;
        }

        public ServiceResponse<NotificationResult> GetPushNotificationById(string notificationId)
           => GetPushNotificationByIdAsync(notificationId).Result;

        public async Task<ServiceResponse<NotificationResult>>
          GetPushNotificationByIdAsync(string notificationId)
        {
            var parameters = new Dictionary<string, string>();
            parameters.Add("notification_id", notificationId);

            var response = await _httpClient.GetAsync<NotificationResult>("push/notifications", parameters);
            return response;
        }
    }
}
