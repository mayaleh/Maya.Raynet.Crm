// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class PriceLists
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        /* "category": null */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        /* "currency": {
  "id": 16,
  "value": "€"
} */
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Currency { get; set; }

        /* "description": null */
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Description { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("primary", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Primary { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        /* "validTill": null */
        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ValidTill { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "Igor Hnízdo"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        [JsonProperty("rowInfo.createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdBy { get; set; }

        /* "rowInfo.updatedAt": null */
        [JsonProperty("rowInfo.updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_updatedAt { get; set; }

        /* "rowInfo.updatedBy": null */
        [JsonProperty("rowInfo.updatedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_updatedBy { get; set; }

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

    }
}
