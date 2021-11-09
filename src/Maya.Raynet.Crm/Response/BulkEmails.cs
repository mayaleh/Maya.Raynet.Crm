// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BulkEmails
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

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
  "sent": "900",
  "clicked": "600",
  "opened": "800",
  "unsubscribed": "500"
} */
        [JsonProperty("stats", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Stats { get; set; }

        [JsonProperty("rowInfo.createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdBy { get; set; }

        [JsonProperty("rowInfo.updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_rowState { get; set; }

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SecurityLevel { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

    }
}
