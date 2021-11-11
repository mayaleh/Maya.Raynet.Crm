// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Currency
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code01", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code01 { get; set; }

        [JsonProperty("code02", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code02 { get; set; }

        [JsonProperty("strValue01", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StrValue01 { get; set; }

    }
}
