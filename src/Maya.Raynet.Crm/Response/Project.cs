// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Project
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /* "company": {
  "id": 4,
  "name": "Extra company a.s."
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": {
  "id": 9,
  "fullName": "Ing. Milan Buldog"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "Petr Svetr"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "category": {
  "id": 128,
  "value": "Výroba"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonProperty("tradingProfit")]
        public int TradingProfit { get; set; }

        [JsonProperty("estimatedValue")]
        public int EstimatedValue { get; set; }

        [JsonProperty("avgValue.totalAmount")]
        public int AvgValue.totalAmount { get; set; }

        [JsonProperty("avgValue.tradingProfit")]
        public int AvgValue.tradingProfit { get; set; }

        [JsonProperty("avgValue.estimatedValue")]
        public int AvgValue.estimatedValue { get; set; }

        [JsonProperty("minValue.totalAmount")]
        public int MinValue.totalAmount { get; set; }

        [JsonProperty("minValue.tradingProfit")]
        public int MinValue.tradingProfit { get; set; }

        [JsonProperty("minValue.estimatedValue")]
        public int MinValue.estimatedValue { get; set; }

        [JsonProperty("maxValue.totalAmount")]
        public int MaxValue.totalAmount { get; set; }

        [JsonProperty("maxValue.tradingProfit")]
        public int MaxValue.tradingProfit { get; set; }

        [JsonProperty("maxValue.estimatedValue")]
        public int MaxValue.estimatedValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        /* "projectStatus": {
  "id": 59,
  "value": "Aktivní (v běhu)"
} */
        [JsonProperty("projectStatus")]
        public object ProjectStatus { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /* "validTill": null */
        [JsonProperty("validTill")]
        public object ValidTill { get; set; }

        [JsonProperty("scheduledEnd")]
        public string ScheduledEnd { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields")]
        public object CustomFields { get; set; }

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

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        /* "attachments": [
  {
    "id": 1,
    "link": null,
    "linkName": null,
    "file": {
      "id": 12,
      "contentType": "image/jpeg",
      "fileName": "header04.jpg",
      "size": 426507
    },
    "folder": null
  }
] */
        [JsonProperty("attachments")]
        public List<object> Attachments { get; set; }

        /* "businessCases": [
  {
    "id": 8,
    "code": "OP-18-005",
    "company": {
      "id": 4,
      "name": "Extra company a.s."
    },
    "person": null,
    "owner": {
      "id": 2,
      "fullName": "Petr Svetr"
    },
    "currency": {
      "id": 19,
      "value": "Kč"
    },
    "validFrom": "2018-04-05",
    "validTill": null,
    "scheduledEnd": null,
    "totalAmount": 34798,
    "tradingProfit": 22734,
    "estimatedValue": 12064,
    "status": "B_ACTIVE",
    "probability": 20,
    "businessCasePhase": {
      "id": 43,
      "value": "Začínáme"
    }
  }
] */
        [JsonProperty("businessCases")]
        public List<object> BusinessCases { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

    }
}
