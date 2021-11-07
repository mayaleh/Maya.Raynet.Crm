// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Invoices
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        /* "company": {
  "id": 1,
  "name": "RAYNET s.r.o."
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        [JsonProperty("invoiceType")]
        public string InvoiceType { get; set; }

        [JsonProperty("issueDate")]
        public string IssueDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("taxableSupplyDate")]
        public string TaxableSupplyDate { get; set; }

        [JsonProperty("invoiceState")]
        public string InvoiceState { get; set; }

        [JsonProperty("baseAmount")]
        public int BaseAmount { get; set; }

        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("unpaidAmount")]
        public float UnpaidAmount { get; set; }

        [JsonProperty("currencyExchangeRate")]
        public int CurrencyExchangeRate { get; set; }

        /* "currency": {
  "id": 15,
  "value": "Kč"
} */
        [JsonProperty("currency")]
        public object Currency { get; set; }

        [JsonProperty("variableSymbol")]
        public string VariableSymbol { get; set; }

        [JsonProperty("constantSymbol")]
        public string ConstantSymbol { get; set; }

        /* "specificSymbol": null */
        [JsonProperty("specificSymbol")]
        public object SpecificSymbol { get; set; }

        /* "category": null */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "M P"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        /* "privateNote": null */
        [JsonProperty("privateNote")]
        public object PrivateNote { get; set; }

        /* "deliveryNote": null */
        [JsonProperty("deliveryNote")]
        public object DeliveryNote { get; set; }

        /* "creditNoteReason": null */
        [JsonProperty("creditNoteReason")]
        public object CreditNoteReason { get; set; }

        /* "vendorName": null */
        [JsonProperty("vendorName")]
        public object VendorName { get; set; }

        /* "vendorBankAccountNumber": null */
        [JsonProperty("vendorBankAccountNumber")]
        public object VendorBankAccountNumber { get; set; }

        [JsonProperty("badDebt")]
        public bool BadDebt { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        [JsonProperty("paymentType")]
        public string PaymentType { get; set; }

        [JsonProperty("decimalPrecision")]
        public int DecimalPrecision { get; set; }

        [JsonProperty("taxPayer")]
        public string TaxPayer { get; set; }

        [JsonProperty("rounding")]
        public bool Rounding { get; set; }

        [JsonProperty("roundingType")]
        public string RoundingType { get; set; }

        [JsonProperty("reverseTax")]
        public bool ReverseTax { get; set; }

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

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

    }
}
