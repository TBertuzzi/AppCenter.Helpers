using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models.Error
{
    public class ErrorGroup
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("annotation")]
        public string Annotation { get; set; }

        [JsonProperty("errorGroupId")]
        public string ErrorGroupId { get; set; }

        [JsonProperty("appVersion")]
        public string AppVersion { get; set; }

        [JsonProperty("appBuild")]
        public string AppBuild { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("deviceCount")]
        public long DeviceCount { get; set; }

        [JsonProperty("firstOccurrence")]
        public DateTimeOffset FirstOccurrence { get; set; }

        [JsonProperty("lastOccurrence")]
        public DateTimeOffset LastOccurrence { get; set; }

        [JsonProperty("exceptionType")]
        public string ExceptionType { get; set; }

        [JsonProperty("exceptionMessage")]
        public string ExceptionMessage { get; set; }

        [JsonProperty("exceptionClassName")]
        public string ExceptionClassName { get; set; }

        [JsonProperty("exceptionClassMethod")]
        public bool ExceptionClassMethod { get; set; }

        [JsonProperty("exceptionMethod")]
        public string ExceptionMethod { get; set; }

        [JsonProperty("exceptionAppCode")]
        public bool ExceptionAppCode { get; set; }

        [JsonProperty("exceptionFile")]
        public string ExceptionFile { get; set; }

        [JsonProperty("exceptionLine")]
        public string ExceptionLine { get; set; }

        [JsonProperty("codeRaw")]
        public string CodeRaw { get; set; }

        [JsonProperty("reasonFrames")]
        public List<ReasonFrame> ReasonFrames { get; set; }
    }
}
