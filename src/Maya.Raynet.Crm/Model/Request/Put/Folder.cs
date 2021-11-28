// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Folder
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /* "parent": null */
        [JsonProperty("parent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Parent { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Category { get; set; }

        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int SecurityLevel { get; set; }

    }
}
