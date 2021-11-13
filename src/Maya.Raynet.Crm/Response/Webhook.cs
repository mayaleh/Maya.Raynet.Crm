// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class Webhook
    {
        [JsonProperty("webhookId", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }

        [JsonProperty("secretToken", NullValueHandling = NullValueHandling.Ignore)]
        public string SecretToken { get; set; }

        [JsonProperty("eventsFilter", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> EventsFilter { get; set; }
    }
}