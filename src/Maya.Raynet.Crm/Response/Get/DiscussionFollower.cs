// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class DiscussionFollower
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        /* "person": {
  "id": 2,
  "fullName": "Dušan Gálik"
} */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Version { get; set; }

    }
}
