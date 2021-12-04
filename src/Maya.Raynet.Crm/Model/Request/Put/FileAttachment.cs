// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class FileAttachment
    {
        [JsonProperty("uuid", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Uuid { get; set; }

        [JsonProperty("fileName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("contentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ContentType { get; set; }

        [JsonProperty("fileSize", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int FileSize { get; set; }

    }
}
