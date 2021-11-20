// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class FoldersAndFiles
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("path", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Path { get; set; }

        /* "owner": null */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        /* "link": null */
        [JsonProperty("link", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Link { get; set; }

        /* "file": null */
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object File { get; set; }

    }
}
