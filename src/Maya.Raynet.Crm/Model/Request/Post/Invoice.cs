// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Post
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

        [JsonProperty("vendorName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorName { get; set; }

        [JsonProperty("vendorRegNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorRegNumber { get; set; }

        [JsonProperty("vendorTaxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorTaxNumber { get; set; }

        /* "vendorAddress": {
  "street": "Francouzská 6167/5",
  "city": "Ostrava",
  "zipCode": "708 00",
  "countryCode": "CZ",
  "countryName": "Česká republika",
  "province": "Moravskoslezský kraj"
} */
        [JsonProperty("vendorAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object VendorAddress { get; set; }

        [JsonProperty("vendorEmail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorEmail { get; set; }

        [JsonProperty("vendorFax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorFax { get; set; }

        [JsonProperty("vendorPhoneNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorPhoneNumber { get; set; }

        [JsonProperty("vendorWebsite", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorWebsite { get; set; }

        [JsonProperty("vendorBankName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorBankName { get; set; }

        [JsonProperty("vendorBankAccountNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorBankAccountNumber { get; set; }

        [JsonProperty("vendorBankIban", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorBankIban { get; set; }

        [JsonProperty("vendorBankSwift", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorBankSwift { get; set; }

        [JsonProperty("vendorBusinessRegisterNote", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VendorBusinessRegisterNote { get; set; }

        [JsonProperty("billingName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BillingName { get; set; }

        [JsonProperty("billingRegNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BillingRegNumber { get; set; }

        [JsonProperty("billingTaxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BillingTaxNumber { get; set; }

        /* "billingAddress": {
  "street": "Francouzská 6167/5",
  "city": "Ostrava",
  "zipCode": "708 00",
  "countryCode": "CZ",
  "countryName": "Česká republika",
  "province": "Moravskoslezský kraj"
} */
        [JsonProperty("billingAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BillingAddress { get; set; }

        /* "items": [
  {
    "name": "položka 1",
    "unitPrice": 123,
    "taxRate": 21,
    "amount": 2,
    "unitLabel": "ks",
    "discountPercent": 0
  },
  {
    "id": 2,
    "name": "položka 2",
    "unitPrice": 123,
    "taxRate": 21,
    "amount": 2,
    "unitLabel": "ks",
    "discountPercent": 10
  }
] */
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Items { get; set; }

    }
}
