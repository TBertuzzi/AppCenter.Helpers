using AppCenter.Helpers.Base;
using AppCenter.Helpers.Models.Analytic;
using HttpExtension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCenter.Helpers.Analytics
{
    public class Analytics : BaseHttpClient
    {
        public Analytics(Config config) 
            : base(config)
        {
        }

        public ServiceResponse<AnalyticsEvent> GetEvents()
           => GetEventsAsync().Result;

        public async Task<ServiceResponse<AnalyticsEvent>>
           GetEventsAsync()
        {
            var response = await this.GetAsync<AnalyticsEvent>("analytics/events");
            return response;
        }
    }
}
