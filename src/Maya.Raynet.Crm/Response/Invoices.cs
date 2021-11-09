// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Invoices
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /* "company": {
  "id": 1,
  "name": "RAYNET s.r.o."
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        [JsonProperty("invoiceType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoiceType { get; set; }

        [JsonProperty("issueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string IssueDate { get; set; }

        [JsonProperty("dueDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DueDate { get; set; }

        [JsonProperty("taxableSupplyDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxableSupplyDate { get; set; }

        [JsonProperty("invoiceState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoiceState { get; set; }

        [JsonProperty("baseAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int BaseAmount { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float TotalAmount { get; set; }

        [JsonProperty("unpaidAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float UnpaidAmount { get; set; }

        [JsonProperty("currencyExchangeRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int CurrencyExchangeRate { get; set; }

        /* "currency": {
  "id": 15,
  "value": "Kč"
} */
        [JsonProperty("currency", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Currency { get; set; }

        [JsonProperty("variableSymbol", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VariableSymbol { get; set; }

        [JsonProperty("constantSymbol", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ConstantSymbol { get; set; }

        /* "specificSymbol": null */
        [JsonProperty("specificSymbol", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SpecificSymbol { get; set; }

        /* "category": null */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "M P"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        [JsonProperty("note", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Note { get; set; }

        /* "privateNote": null */
        [JsonProperty("privateNote", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrivateNote { get; set; }

        /* "deliveryNote": null */
        [JsonProperty("deliveryNote", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object DeliveryNote { get; set; }

        /* "creditNoteReason": null */
        [JsonProperty("creditNoteReason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CreditNoteReason { get; set; }

        /* "vendorName": null */
        [JsonProperty("vendorName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object VendorName { get; set; }

        /* "vendorBankAccountNumber": null */
        [JsonProperty("vendorBankAccountNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object VendorBankAccountNumber { get; set; }

        [JsonProperty("badDebt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool BadDebt { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCase { get; set; }

        [JsonProperty("paymentType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PaymentType { get; set; }

        [JsonProperty("decimalPrecision", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int DecimalPrecision { get; set; }

        [JsonProperty("taxPayer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxPayer { get; set; }

        [JsonProperty("rounding", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Rounding { get; set; }

        [JsonProperty("roundingType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RoundingType { get; set; }

        [JsonProperty("reverseTax", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ReverseTax { get; set; }

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

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<> Tags { get; set; }

    }
}
