using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCenter.Helpers.Models.Error
{
    public class ReasonFrame
    {
        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("classMethod")]
        public bool ClassMethod { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("line")]
        public long Line { get; set; }

        [JsonProperty("appCode")]
        public bool AppCode { get; set; }

        [JsonProperty("frameworkName")]
        public string FrameworkName { get; set; }

        [JsonProperty("codeFormatted")]
        public string CodeFormatted { get; set; }

        [JsonProperty("codeRaw")]
        public string CodeRaw { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("methodParams")]
        public string MethodParams { get; set; }

        [JsonProperty("exceptionType")]
        public string ExceptionType { get; set; }

        [JsonProperty("osExceptionType")]
        public string OsExceptionType { get; set; }
    }
}
