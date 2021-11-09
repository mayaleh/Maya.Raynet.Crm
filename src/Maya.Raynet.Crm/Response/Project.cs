// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Project
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /* "company": {
  "id": 4,
  "name": "Extra company a.s."
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        /* "person": {
  "id": 9,
  "fullName": "Ing. Milan Buldog"
} */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Person { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "Petr Svetr"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        /* "category": {
  "id": 128,
  "value": "Výroba"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TotalAmount { get; set; }

        [JsonProperty("tradingProfit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TradingProfit { get; set; }

        [JsonProperty("estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EstimatedValue { get; set; }

        [JsonProperty("avgValue.totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AvgValue_totalAmount { get; set; }

        [JsonProperty("avgValue.tradingProfit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AvgValue_tradingProfit { get; set; }

        [JsonProperty("avgValue.estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AvgValue_estimatedValue { get; set; }

        [JsonProperty("minValue.totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MinValue_totalAmount { get; set; }

        [JsonProperty("minValue.tradingProfit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MinValue_tradingProfit { get; set; }

        [JsonProperty("minValue.estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MinValue_estimatedValue { get; set; }

        [JsonProperty("maxValue.totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxValue_totalAmount { get; set; }

        [JsonProperty("maxValue.tradingProfit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxValue_tradingProfit { get; set; }

        [JsonProperty("maxValue.estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxValue_estimatedValue { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        /* "projectStatus": {
  "id": 59,
  "value": "Aktivní (v běhu)"
} */
        [JsonProperty("projectStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ProjectStatus { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        /* "validTill": null */
        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ValidTill { get; set; }

        [JsonProperty("scheduledEnd", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledEnd { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

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

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("businessCases", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> BusinessCases { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

    }
}
