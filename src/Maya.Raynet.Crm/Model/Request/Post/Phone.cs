// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Post
{
    public class Phone
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Category { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("personal", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Personal { get; set; }

        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Company { get; set; }

        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int BusinessCase { get; set; }

        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Project { get; set; }

        [JsonProperty("activity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Activity { get; set; }

        [JsonProperty("scheduledFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledFrom { get; set; }

        [JsonProperty("scheduledTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledTill { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("solution", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Solution { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /* "customFields": {
  "VIP_b91d1": true
} */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

        /* "participants": [
  {
    "id": -123
  },
  {
    "person": 4
  },
  {
    "id": 119,
    "owner": true,
    "role": "FROM",
    "person": 8,
    "company": 2,
    "lead": null
  }
] */
        [JsonProperty("participants", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Participants { get; set; }

    }
}
