// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Document
    {
        /* "file": {
  "uuid": "7d694dbb4e6241829de8a385da797283",
  "fileName": "picture.png",
  "contentType": "image/png",
  "fileSize": 24309
} */
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object File { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int SecurityLevel { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Category { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Template { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidTill { get; set; }

        [JsonProperty("folder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Folder { get; set; }

    }
}
