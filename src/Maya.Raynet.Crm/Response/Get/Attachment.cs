// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class Attachment
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("link", NullValueHandling = NullValueHandling.Ignore)]
        public string Link { get; set; }

        [JsonProperty("linkName", NullValueHandling = NullValueHandling.Ignore)]
        public string LinkName { get; set; }

        [JsonProperty("file", NullValueHandling = NullValueHandling.Ignore)]
        public FileInfo File { get; set; }

        [JsonProperty("folder", NullValueHandling = NullValueHandling.Ignore)]
        public string Folder { get; set; }
    }
}