using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class PdfExportInfo
    {
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        [JsonProperty("instanceName", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }
    }
}
