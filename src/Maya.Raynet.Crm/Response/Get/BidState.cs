// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class BidState
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code01", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code01 { get; set; }

        [JsonProperty("locked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Locked { get; set; }

    }
}
