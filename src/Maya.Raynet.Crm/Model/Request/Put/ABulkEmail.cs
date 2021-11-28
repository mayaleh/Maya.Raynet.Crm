// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class ABulkEmail
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("completed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Completed { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("campaignName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CampaignName { get; set; }

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Source { get; set; }

        [JsonProperty("externalId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalId { get; set; }

        [JsonProperty("externalOverviewUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalOverviewUrl { get; set; }

        [JsonProperty("externalThumbnailUrl", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExternalThumbnailUrl { get; set; }

        /* "stats": {
  "sent": "500",
  "clicked": "300",
  "opened": "400",
  "unsubscribed": "200"
} */
        [JsonProperty("stats", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Stats { get; set; }

    }
}
