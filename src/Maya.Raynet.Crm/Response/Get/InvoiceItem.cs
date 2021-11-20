// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class InvoiceItem
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public long? Amount { get; set; }

        [JsonProperty("unitPrice", NullValueHandling = NullValueHandling.Ignore)]
        public long? UnitPrice { get; set; }

        [JsonProperty("taxRate", NullValueHandling = NullValueHandling.Ignore)]
        public long? TaxRate { get; set; }

        [JsonProperty("basePrice", NullValueHandling = NullValueHandling.Ignore)]
        public long? BasePrice { get; set; }

        [JsonProperty("totalTax", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalTax { get; set; }

        [JsonProperty("totalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalPrice { get; set; }

        [JsonProperty("discountPercent", NullValueHandling = NullValueHandling.Ignore)]
        public long? DiscountPercent { get; set; }

        [JsonProperty("sequenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public long? SequenceNumber { get; set; }

        [JsonProperty("unitLabel", NullValueHandling = NullValueHandling.Ignore)]
        public string UnitLabel { get; set; }

        [JsonProperty("calculateTaxFromTotalPrice", NullValueHandling = NullValueHandling.Ignore)]
        public bool? CalculateTaxFromTotalPrice { get; set; }

        [JsonProperty("priceListItem")]
        public object PriceListItem { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

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
    }
}