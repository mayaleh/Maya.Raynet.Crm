// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class PriceListItems
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "product": {
  "id": 57,
  "code": "KONV",
  "name": "Konvalinka"
} */
        [JsonProperty("product")]
        public object Product { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public float Price { get; set; }

        [JsonProperty("cost")]
        public float Cost { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("taxRate")]
        public int TaxRate { get; set; }

        /* "description": null */
        [JsonProperty("description")]
        public object Description { get; set; }

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

    }
}
