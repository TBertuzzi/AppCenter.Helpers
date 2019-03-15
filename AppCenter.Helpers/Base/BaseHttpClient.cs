using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AppCenter.Helpers.Base
{
    public class BaseHttpClient : HttpClient
    {
        public BaseHttpClient(Config config)
        {
            this.BaseAddress = new Uri(string.Format(EndPoints.RestApi, config.OwnerName, config.AppName));
            this.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            this.DefaultRequestHeaders.Add("X-API-Token", config.Token);
        }
    }
}
