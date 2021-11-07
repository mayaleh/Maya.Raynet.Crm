// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class DiscussionFollowers
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "person": {
  "id": 2,
  "fullName": "Dušan Gálik"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

    }
}
