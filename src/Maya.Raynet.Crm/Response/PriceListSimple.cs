﻿// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class PriceListSimple
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
    }
}