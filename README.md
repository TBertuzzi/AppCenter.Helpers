# AppCenter.Helpers

**THIS PACKAGE IS BETA**

Helpers to get data from Analitycs, Errors and Send Push Notification to the AppCenter

###### This is the component, works on .NET Core and.NET Framework

**Info**

|Code Quality|Build|Nuget|
| ------------------- | ------------------- | :------------------: |
|[![Codacy Badge](https://api.codacy.com/project/badge/Grade/d738c75a567348ee9e02a2ae9f4c4d00)](https://app.codacy.com/app/TBertuzzi/AppCenter.Helpers?utm_source=github.com&utm_medium=referral&utm_content=TBertuzzi/AppCenter.Helpers&utm_campaign=Badge_Grade_Dashboard)||[![NuGet](https://buildstats.info/nuget/AppCenter.Helpers)](https://www.nuget.org/packages/AppCenter.Helpers/)|

**Platform Support**

RepositoryHelpers is a .NET Standard 2.0 library.

**Config**

Use the config class to configure the name, owner, and token of your app in the center app

```csharp
 var config = new Config()
 {
     AppName = "your app name",
     OwnerName = "your owner name",
     Token = "appcenter token"
};
```

To get a token [click here](https://docs.microsoft.com/en-us/appcenter/api-docs/) 

**Push Notification**

To send a notification simply fill in the Notification object and call the SendPushNotification

```csharp
   var notificacao = new Notification
   {
                NotificationTarget = new NotificationTarget
                {
                    Type = "devices_target",
                    Devices = new List<string>(new string[] { "00000000-0000-0000-0000-000000000001" }) //exemplo
                },
                NotificationContent = new NotificationContent
                {
                    Name = "MyAppName",
                    Title = "Notification Title",
                    Body = "Notification Body",
                }
    };

            var push = new PushNotification(config);
            var result = push.SendPushNotification(notificacao);
```


To get all the notifications just use the method below

```csharp
    var resultList = push.GetPushNotifications();

   foreach (var item in resultList.Value.ResultContent)
   {
    Console.WriteLine($"Item {item}");
   }
```

To configure Push Notification in appcenter [click here](https://docs.microsoft.com/en-us/appcenter/push/) 

**Analytics** (In development)

Get all events through GetEvents method

```csharp
   var analytics = new Analytics.Analytics(config);
   var result = analytics.GetEvents();
```

**Analytics** (In development)

Get all error groups through GetErrorGroups method

```csharp
   var errors = new Errors.Errors(config);
   var result = errors.GetErrorGroups();
```

App Center APIs are being implemented bit by bit. Pullrequests are welcome but should follow the existing pattern :)


