// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Order
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

        /* "businessCase": {
  "id": 4,
  "code": "OP-17-001"
} */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        /* "offer": {
  "id": 8,
  "code": "NAB-17-001"
} */
        [JsonProperty("offer")]
        public object Offer { get; set; }

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

        [JsonProperty("exchangeRate")]
        public int ExchangeRate { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill")]
        public string ValidTill { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("requestDeliveryDate")]
        public string RequestDeliveryDate { get; set; }

        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("estimatedValue")]
        public int EstimatedValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        /* "salesOrderStatus": {
  "id": 45,
  "value": "Příprava"
} */
        [JsonProperty("salesOrderStatus")]
        public object SalesOrderStatus { get; set; }

        /* "category": {
  "id": 96,
  "value": "Obchod morava"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

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

        /* "deliveryAddress": {
  "name": "RAYNET Praha s.r.o.",
  "city": "Praha",
  "country": "Česká republika",
  "countryCode": "CZ",
  "province": "Praha",
  "street": "Albertov 2038/6",
  "zipCode": "128 00"
} */
        [JsonProperty("deliveryAddress")]
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
        [JsonProperty("invoiceAddress")]
        public object InvoiceAddress { get; set; }

        [JsonProperty("invoiceRegNumber")]
        public string InvoiceRegNumber { get; set; }

        [JsonProperty("invoiceTaxNumber")]
        public string InvoiceTaxNumber { get; set; }

        /* "invoiceTaxNumber2": null */
        [JsonProperty("invoiceTaxNumber2")]
        public object InvoiceTaxNumber2 { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

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
