// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Offers
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

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill")]
        public string ValidTill { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("totalAmount")]
        public float TotalAmount { get; set; }

        [JsonProperty("estimatedValue")]
        public int EstimatedValue { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        /* "offerStatus": {
  "id": 45,
  "value": "Příprava"
} */
        [JsonProperty("offerStatus")]
        public object OfferStatus { get; set; }

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

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

    }
}
