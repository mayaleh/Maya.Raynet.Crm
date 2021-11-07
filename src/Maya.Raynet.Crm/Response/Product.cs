// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("taxRate")]
        public int TaxRate { get; set; }

        /* "category": {
  "id": 791,
  "value": "Náklady"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "primaryPriceListItem": {
  "id": 249,
  "price": 1500,
  "priceList": {
    "id": 1,
    "currency": "CZK"
  }
} */
        [JsonProperty("primaryPriceListItem")]
        public object PrimaryPriceListItem { get; set; }

        /* "productLine": {
  "id": 206,
  "value": "fabie I"
} */
        [JsonProperty("productLine")]
        public object ProductLine { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("cost")]
        public int Cost { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /* "validTill": null */
        [JsonProperty("validTill")]
        public object ValidTill { get; set; }

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

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        /* "photo": null */
        [JsonProperty("photo")]
        public object Photo { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

        [JsonProperty("attachments")]
        public List<> Attachments { get; set; }

        /* "customFields": {
  "Vaha_(g)_80307": 10
} */
        [JsonProperty("customFields")]
        public object CustomFields { get; set; }

    }
}
