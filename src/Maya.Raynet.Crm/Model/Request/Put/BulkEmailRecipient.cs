// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class BulkEmailRecipient
    {
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Person { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("opened", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Opened { get; set; }

        [JsonProperty("clicked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Clicked { get; set; }

        [JsonProperty("unsubscribed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Unsubscribed { get; set; }

    }
}
