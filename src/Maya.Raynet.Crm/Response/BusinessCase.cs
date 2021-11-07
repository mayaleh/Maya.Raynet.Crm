// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BusinessCase
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /* "company": {
  "id": 1,
  "name": "RAYNET s.r.o."
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": {
  "id": 3,
  "fullName": "Jan Novák"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "owner": {
  "id": 3,
  "fullName": "Marie Vyležíková"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "currency": {
  "id": 17,
  "value": "$"
} */
        [JsonProperty("currency")]
        public object Currency { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        /* "validTill": null */
        [JsonProperty("validTill")]
        public object ValidTill { get; set; }

        /* "scheduledEnd": null */
        [JsonProperty("scheduledEnd")]
        public object ScheduledEnd { get; set; }

        [JsonProperty("totalAmount")]
        public int TotalAmount { get; set; }

        [JsonProperty("totalAmountWithTax")]
        public int TotalAmountWithTax { get; set; }

        [JsonProperty("estimatedValue")]
        public int EstimatedValue { get; set; }

        [JsonProperty("tradingProfit")]
        public int TradingProfit { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("exchangeRate")]
        public int ExchangeRate { get; set; }

        /* "businessCasePhase": {
  "id": 39,
  "value": "Identifikace příležitosti"
} */
        [JsonProperty("businessCasePhase")]
        public object BusinessCasePhase { get; set; }

        /* "businessCaseType": null */
        [JsonProperty("businessCaseType")]
        public object BusinessCaseType { get; set; }

        /* "category": null */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "project": null */
        [JsonProperty("project")]
        public object Project { get; set; }

        /* "source": null */
        [JsonProperty("source")]
        public object Source { get; set; }

        /* "businessCaseClassification1": {
  "id": 93,
  "value": "test"
} */
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

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        [JsonProperty("attachments")]
        public List<> Attachments { get; set; }

        /* "customFields": {
  "Popis_prio_c49d5": "Text text",
  "Priorita_O_a5fab": "TOP"
} */
        [JsonProperty("customFields")]
        public object CustomFields { get; set; }

        /* "items": [
  {
    "id": 1,
    "priceListItem": null,
    "name": "Nekategorizovaný produkt",
    "description": null,
    "price": 122,
    "taxRate": 0,
    "unit": "ks",
    "discountPercent": 0,
    "count": 1
  }
] */
        [JsonProperty("items")]
        public List<object> Items { get; set; }

    }
}
