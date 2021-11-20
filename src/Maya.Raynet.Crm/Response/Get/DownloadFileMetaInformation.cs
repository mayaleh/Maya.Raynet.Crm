// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class DownloadFileMetaInformation
    {
        [JsonProperty("uuid", NullValueHandling = NullValueHandling.Ignore)]
        public string Uuid { get; set; }

        [JsonProperty("fileName", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("fileSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        [JsonProperty("contentType", NullValueHandling = NullValueHandling.Ignore)]
        public string ContentType { get; set; }

        [JsonProperty("accessToken", NullValueHandling = NullValueHandling.Ignore)]
        public string AccessToken { get; set; }

        [JsonProperty("instanceName", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }
    }
}