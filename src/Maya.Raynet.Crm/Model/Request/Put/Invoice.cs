// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Invoice
    {
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Company { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("constantSymbol", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConstantSymbol { get; set; }

        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Currency { get; set; }

        [JsonProperty("dueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DueDate { get; set; }

        [JsonProperty("invoiceType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoiceType { get; set; }

        [JsonProperty("issueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IssueDate { get; set; }

        [JsonProperty("paymentTermDays", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PaymentTermDays { get; set; }

        [JsonProperty("paymentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PaymentType { get; set; }

        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int SecurityLevel { get; set; }

        [JsonProperty("specificSymbol", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SpecificSymbol { get; set; }

        [JsonProperty("taxableSupplyDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxableSupplyDate { get; set; }

        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int BusinessCase { get; set; }

    }
}
