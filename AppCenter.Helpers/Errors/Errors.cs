using AppCenter.Helpers.Base;
using AppCenter.Helpers.Models.Error;
using HttpExtension;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCenter.Helpers.Errors
{
    public class Errors : BaseHttpClient
    {
        public Errors(Config config) :
            base(config)
        {
        }

        public ServiceResponse<ErrorGroupEvent> GetErrorGroups()
            => GetErrorGroupsAsync().Result;

        public async Task<ServiceResponse<ErrorGroupEvent>>
           GetErrorGroupsAsync()
        {
            var response = await this.GetAsync<ErrorGroupEvent>("errors/errorGroups");
            return response;
        }
    }
}
