// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class ActivityParticipant
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Owner { get; set; }

        [JsonProperty("role", NullValueHandling = NullValueHandling.Ignore)]
        public string Role { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("person", NullValueHandling = NullValueHandling.Ignore)]
        public long? Person { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public long? Company { get; set; }

        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public long? Lead { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }
    }
}