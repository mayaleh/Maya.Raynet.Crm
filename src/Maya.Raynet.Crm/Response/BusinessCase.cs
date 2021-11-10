// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BusinessCase
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Owner { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Currency { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ValidTill { get; set; }

        [JsonProperty("scheduledEnd", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ScheduledEnd { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TotalAmount { get; set; }

        [JsonProperty("totalAmountWithTax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TotalAmountWithTax { get; set; }

        [JsonProperty("estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EstimatedValue { get; set; }

        [JsonProperty("tradingProfit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TradingProfit { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("probability", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Probability { get; set; }

        [JsonProperty("exchangeRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ExchangeRate { get; set; }

        [JsonProperty("businessCasePhase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue BusinessCasePhase { get; set; }

        [JsonProperty("businessCaseType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BusinessCaseTypes BusinessCaseType { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BusinessCaseCategory Category { get; set; }

        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Project Project { get; set; }

        /* "source": null */
        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Source { get; set; }

        [JsonProperty("businessCaseClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue BusinessCaseClassification1 { get; set; }

        /* "businessCaseClassification2": null */
        [JsonProperty("businessCaseClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue BusinessCaseClassification2 { get; set; }

        /* "businessCaseClassification3": null */
        [JsonProperty("businessCaseClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue BusinessCaseClassification3 { get; set; }

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
        public string RowInfo_rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_rowState { get; set; }

        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SecurityLevel SecurityLevel { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dictionary<string, object> CustomFields { get; set; }

        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<BusinessCaseItem> Items { get; set; }

    }
}
