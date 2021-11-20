using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class IdValue
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Value { get; set; }
    }
}
