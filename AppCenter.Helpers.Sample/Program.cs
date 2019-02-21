using AppCenter.Helpers.Push;
using System;
using AppCenter.Helpers.Models;
using System.Collections.Generic;

namespace AppCenter.Helpers.Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new Config();
            config.AppName = "seu app name";
            config.OwnerName = "seu owner name";
            config.Token = "token";

            var notificacao = new Notification
            {
                NotificationTarget = new NotificationTarget()
                {
                    Type = "devices_target",
                    Devices = new List<string>(new string[] { "00000000-0000-0000-0000-000000000001" }) //exemplo
                },
                NotificationContent = new NotificationContent()
                {
                    Name = "enupemec",
                    Title = "Notificação Mediação",
                    Body = "Teste App Center",
                }
            };

            var push = new PushNotification(config);
          //  var result = push.SendPushNotification(notificacao);

            var resultList = push.GetPushNotifications();

            foreach (var item in resultList.Value.ResultContent)
            {
                Console.WriteLine($"Item {item}");
            }

            Console.ReadKey();
        }
    }
}
