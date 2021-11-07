// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BusinessCases
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /* "company": {
  "id": 1093,
  "name": "Firma 1"
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": null */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "owner": {
  "id": 11,
  "fullName": "Ludmila Nováková"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "currency": {
  "id": 15,
  "value": "Kč"
} */
        [JsonProperty("currency")]
        public object Currency { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill")]
        public string ValidTill { get; set; }

        /* "scheduledEnd": null */
        [JsonProperty("scheduledEnd")]
        public object ScheduledEnd { get; set; }

        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("tradingProfit")]
        public float TradingProfit { get; set; }

        [JsonProperty("estimatedValue")]
        public int EstimatedValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("exchangeRate")]
        public int ExchangeRate { get; set; }

        /* "businessCasePhase": {
  "id": 45,
  "value": "Výhra"
} */
        [JsonProperty("businessCasePhase")]
        public object BusinessCasePhase { get; set; }

        /* "businessCaseType": null */
        [JsonProperty("businessCaseType")]
        public object BusinessCaseType { get; set; }

        /* "category": {
  "id": 96,
  "value": "Obchod morava"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "project": null */
        [JsonProperty("project")]
        public object Project { get; set; }

        /* "source": null */
        [JsonProperty("source")]
        public object Source { get; set; }

        /* "businessCaseClassification1": null */
        [JsonProperty("businessCaseClassification1")]
        public object BusinessCaseClassification1 { get; set; }

        /* "businessCaseClassification2": null */
        [JsonProperty("businessCaseClassification2")]
        public object BusinessCaseClassification2 { get; set; }

        /* "businessCaseClassification3": null */
        [JsonProperty("businessCaseClassification3")]
        public object BusinessCaseClassification3 { get; set; }

        /* "losingReason": null */
        [JsonProperty("losingReason")]
        public object LosingReason { get; set; }

        /* "losingCategory": null */
        [JsonProperty("losingCategory")]
        public object LosingCategory { get; set; }

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

        /* "description": null */
        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

    }
}
