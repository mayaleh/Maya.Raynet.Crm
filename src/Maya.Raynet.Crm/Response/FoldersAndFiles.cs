// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class FoldersAndFiles
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        /* "owner": null */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "link": null */
        [JsonProperty("link")]
        public object Link { get; set; }

        /* "file": null */
        [JsonProperty("file")]
        public object File { get; set; }

    }
}
