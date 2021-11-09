// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BusinessCases
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /* "company": {
  "id": 1093,
  "name": "Firma 1"
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        /* "person": null */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Person { get; set; }

        /* "owner": {
  "id": 11,
  "fullName": "Ludmila Nováková"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        /* "currency": {
  "id": 15,
  "value": "Kč"
} */
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Currency { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidTill { get; set; }

        /* "scheduledEnd": null */
        [JsonProperty("scheduledEnd", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ScheduledEnd { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float TotalAmount { get; set; }

        [JsonProperty("tradingProfit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float TradingProfit { get; set; }

        [JsonProperty("estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EstimatedValue { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("probability", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Probability { get; set; }

        [JsonProperty("exchangeRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ExchangeRate { get; set; }

        /* "businessCasePhase": {
  "id": 45,
  "value": "Výhra"
} */
        [JsonProperty("businessCasePhase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCasePhase { get; set; }

        /* "businessCaseType": null */
        [JsonProperty("businessCaseType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCaseType { get; set; }

        /* "category": {
  "id": 96,
  "value": "Obchod morava"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        /* "project": null */
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Project { get; set; }

        /* "source": null */
        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Source { get; set; }

        /* "businessCaseClassification1": null */
        [JsonProperty("businessCaseClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCaseClassification1 { get; set; }

        /* "businessCaseClassification2": null */
        [JsonProperty("businessCaseClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCaseClassification2 { get; set; }

        /* "businessCaseClassification3": null */
        [JsonProperty("businessCaseClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCaseClassification3 { get; set; }

        /* "losingReason": null */
        [JsonProperty("losingReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object LosingReason { get; set; }

        /* "losingCategory": null */
        [JsonProperty("losingCategory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object LosingCategory { get; set; }

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

        /* "description": null */
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Description { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<> Tags { get; set; }

    }
}
