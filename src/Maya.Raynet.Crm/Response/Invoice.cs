// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;


namespace Maya.Raynet.Crm.Response
{
    public class Invoice
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public Company Company { get; set; }

        [JsonProperty("invoiceType", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceType { get; set; }

        [JsonProperty("issueDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssueDate { get; set; }

        [JsonProperty("dueDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("taxableSupplyDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TaxableSupplyDate { get; set; }

        [JsonProperty("invoiceState", NullValueHandling = NullValueHandling.Ignore)]
        public string InvoiceState { get; set; }

        [JsonProperty("baseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? BaseAmount { get; set; }

        [JsonProperty("totalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAmount { get; set; }

        [JsonProperty("unpaidAmount", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnpaidAmount { get; set; }

        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public Currency Currency { get; set; }

        [JsonProperty("currencyExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public long? CurrencyExchangeRate { get; set; }

        [JsonProperty("variableSymbol", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableSymbol { get; set; }

        [JsonProperty("constantSymbol", NullValueHandling = NullValueHandling.Ignore)]
        public string ConstantSymbol { get; set; }

        [JsonProperty("specificSymbol")]
        public object SpecificSymbol { get; set; }

        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("owner", NullValueHandling = NullValueHandling.Ignore)]
        public Owner Owner { get; set; }

        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("privateNote")]
        public object PrivateNote { get; set; }

        [JsonProperty("deliveryNote")]
        public object DeliveryNote { get; set; }

        [JsonProperty("creditNoteReason")]
        public object CreditNoteReason { get; set; }

        [JsonProperty("vendorName", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorName { get; set; }

        [JsonProperty("vendorBankAccountNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorBankAccountNumber { get; set; }

        [JsonProperty("vendorBankName", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorBankName { get; set; }

        [JsonProperty("vendorBankIban", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorBankIban { get; set; }

        [JsonProperty("vendorBankSwift", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorBankSwift { get; set; }

        [JsonProperty("vendorRegNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorRegNumber { get; set; }

        [JsonProperty("vendorTaxNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorTaxNumber { get; set; }

        [JsonProperty("vendorTaxNumber2")]
        public object VendorTaxNumber2 { get; set; }

        [JsonProperty("vendorEmail", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorEmail { get; set; }

        [JsonProperty("vendorWebsite", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorWebsite { get; set; }

        [JsonProperty("vendorPhoneNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorPhoneNumber { get; set; }

        [JsonProperty("vendorFax")]
        public object VendorFax { get; set; }

        [JsonProperty("vendorBusinessRegisterNote", NullValueHandling = NullValueHandling.Ignore)]
        public string VendorBusinessRegisterNote { get; set; }

        [JsonProperty("vendorAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Address VendorAddress { get; set; }

        [JsonProperty("billingName", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingName { get; set; }

        [JsonProperty("billingRegNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingRegNumber { get; set; }

        [JsonProperty("billingTaxNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string BillingTaxNumber { get; set; }

        [JsonProperty("billingTaxNumber2")]
        public object BillingTaxNumber2 { get; set; }

        [JsonProperty("billingAddress", NullValueHandling = NullValueHandling.Ignore)]
        public Address BillingAddress { get; set; }

        [JsonProperty("badDebt", NullValueHandling = NullValueHandling.Ignore)]
        public bool? BadDebt { get; set; }

        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        [JsonProperty("salesOrder")]
        public object SalesOrder { get; set; }

        [JsonProperty("paymentType", NullValueHandling = NullValueHandling.Ignore)]
        public string PaymentType { get; set; }

        [JsonProperty("decimalPrecision", NullValueHandling = NullValueHandling.Ignore)]
        public long? DecimalPrecision { get; set; }

        [JsonProperty("taxPayer", NullValueHandling = NullValueHandling.Ignore)]
        public string TaxPayer { get; set; }

        [JsonProperty("rounding", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rounding { get; set; }

        [JsonProperty("roundingType", NullValueHandling = NullValueHandling.Ignore)]
        public string RoundingType { get; set; }

        [JsonProperty("reverseTax", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReverseTax { get; set; }

        [JsonProperty("rowInfo.createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoCreatedAt { get; set; }

        [JsonProperty("rowInfo.createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoCreatedBy { get; set; }

        [JsonProperty("rowInfo.updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoUpdatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoUpdatedBy { get; set; }

        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfoRowAccess { get; set; }

        [JsonProperty("rowInfo.rowState")]
        public object RowInfoRowState { get; set; }

        [JsonProperty("securityLevel", NullValueHandling = NullValueHandling.Ignore)]
        public Company SecurityLevel { get; set; }

        [JsonProperty("_version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        [JsonProperty("extIds")]
        public object ExtIds { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Tags { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public List<InvoiceItem> Items { get; set; }

        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public List<Payment> Payments { get; set; }
    }
}
