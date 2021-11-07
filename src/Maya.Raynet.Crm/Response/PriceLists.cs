// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class PriceLists
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "category": null */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        /* "currency": {
  "id": 16,
  "value": "€"
} */
        [JsonProperty("currency")]
        public object Currency { get; set; }

        /* "description": null */
        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /* "validTill": null */
        [JsonProperty("validTill")]
        public object ValidTill { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "Igor Hnízdo"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("rowInfo.createdAt")]
        public string RowInfo.createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy")]
        public string RowInfo.createdBy { get; set; }

        /* "rowInfo.updatedAt": null */
        [JsonProperty("rowInfo.updatedAt")]
        public object RowInfo.updatedAt { get; set; }

        /* "rowInfo.updatedBy": null */
        [JsonProperty("rowInfo.updatedBy")]
        public object RowInfo.updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfo.rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState")]
        public object RowInfo.rowState { get; set; }

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel")]
        public object SecurityLevel { get; set; }

    }
}
