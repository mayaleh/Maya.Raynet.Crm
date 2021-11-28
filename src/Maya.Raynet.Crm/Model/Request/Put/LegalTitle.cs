// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class LegalTitle
    {
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Person { get; set; }

        [JsonProperty("gdprTemplate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int GdprTemplate { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

    }
}
