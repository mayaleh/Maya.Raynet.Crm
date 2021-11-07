// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class PriceList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "category": {
  "id": 103,
  "value": "Ohoo"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        /* "currency": {
  "id": 17,
  "value": "$"
} */
        [JsonProperty("currency")]
        public object Currency { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill")]
        public string ValidTill { get; set; }

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

        [JsonProperty("rowInfo.updatedAt")]
        public string RowInfo.updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy")]
        public string RowInfo.updatedBy { get; set; }

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

        /* "items": [
  {
    "id": 2,
    "product": {
      "id": 1,
      "code": "007",
      "name": "Pohovka rohová"
    },
    "price": 420.1344,
    "rowInfo.createdAt": "2017-02-03 11:41",
    "rowInfo.createdBy": "admin@firma.cz",
    "rowInfo.updatedAt": null,
    "rowInfo.updatedBy": null,
    "rowInfo.rowAccess": null,
    "rowInfo.rowState": null
  }
] */
        [JsonProperty("items")]
        public List<object> Items { get; set; }

    }
}
