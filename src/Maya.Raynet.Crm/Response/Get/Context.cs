// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class Context
    {
        [JsonProperty("entityName", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityName { get; set; }

        [JsonProperty("entityId", NullValueHandling = NullValueHandling.Ignore)]
        public long? EntityId { get; set; }

        [JsonProperty("entityTab", NullValueHandling = NullValueHandling.Ignore)]
        public string EntityTab { get; set; }

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }
    }
}