// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class Change
    {
        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; set; }

        [JsonProperty("oldValue", NullValueHandling = NullValueHandling.Ignore)]
        public string OldValue { get; set; }

        [JsonProperty("newValue", NullValueHandling = NullValueHandling.Ignore)]
        public string NewValue { get; set; }
    }
}