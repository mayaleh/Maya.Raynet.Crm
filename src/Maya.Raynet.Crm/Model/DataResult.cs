using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Model
{
    public class DataResult<T>
    {
        [JsonProperty("success", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }

        [JsonProperty("totalCount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public T Data { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }

        [JsonProperty("translatedMessage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TranslatedMessage { get; set; }
    }
}
