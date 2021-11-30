using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Model
{
    public class EmptyResult
    {
        [JsonProperty("success", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsSuccess { get; set; }
    }
}
