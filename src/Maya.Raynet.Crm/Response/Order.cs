// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Order
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

        /* "businessCase": {
  "id": 4,
  "code": "OP-17-001"
} */
        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCase { get; set; }

        /* "offer": {
  "id": 8,
  "code": "NAB-17-001"
} */
        [JsonProperty("offer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Offer { get; set; }

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

        [JsonProperty("exchangeRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ExchangeRate { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidTill { get; set; }

        [JsonProperty("expirationDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExpirationDate { get; set; }

        [JsonProperty("requestDeliveryDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RequestDeliveryDate { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float TotalAmount { get; set; }

        [JsonProperty("estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EstimatedValue { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        /* "salesOrderStatus": {
  "id": 45,
  "value": "Příprava"
} */
        [JsonProperty("salesOrderStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SalesOrderStatus { get; set; }

        /* "category": {
  "id": 96,
  "value": "Obchod morava"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

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

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /* "deliveryAddress": {
  "name": "RAYNET Praha s.r.o.",
  "city": "Praha",
  "country": "Česká republika",
  "countryCode": "CZ",
  "province": "Praha",
  "street": "Albertov 2038/6",
  "zipCode": "128 00"
} */
        [JsonProperty("deliveryAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object DeliveryAddress { get; set; }

        /* "invoiceAddress": {
  "name": "RAYNET s.r.o.",
  "city": "Ostrava-Poruba",
  "country": "Česká republika",
  "countryCode": "CZ",
  "province": "Moravskoslezský kraj",
  "street": "Francouzská 6167/5",
  "zipCode": "708 00"
} */
        [JsonProperty("invoiceAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object InvoiceAddress { get; set; }

        [JsonProperty("invoiceRegNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoiceRegNumber { get; set; }

        [JsonProperty("invoiceTaxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoiceTaxNumber { get; set; }

        /* "invoiceTaxNumber2": null */
        [JsonProperty("invoiceTaxNumber2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object InvoiceTaxNumber2 { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<> Attachments { get; set; }

        /* "customFields": {
  "Popis_prio_c49d5": "Text text",
  "Priorita_O_a5fab": "TOP"
} */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("items", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Items { get; set; }

    }
}
