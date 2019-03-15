using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models.Error
{
    public class ErrorGroupEvent
    {
        [JsonProperty("nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("errorGroups")]
        public List<ErrorGroup> ErrorGroups { get; set; }
    }
}
