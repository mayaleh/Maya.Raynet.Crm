// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class People
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("titleBefore")]
        public string TitleBefore { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("titleAfter")]
        public string TitleAfter { get; set; }

        /* "primaryRelationship": {
  "id": 1,
  "type": "konzultant",
  "company": {
    "id": 1,
    "name": "RAYNET s.r.o."
  }
} */
        [JsonProperty("primaryRelationship")]
        public object PrimaryRelationship { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "test test"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "contactInfo": {
  "email": "podpora@raynet.cz",
  "email2": "test@raynet.cz",
  "tel1": "+420 553 401 547",
  "tel1Type": "mobil",
  "tel2": null,
  "tel2Type": null,
  "www": null,
  "otherContact": null
} */
        [JsonProperty("contactInfo")]
        public object ContactInfo { get; set; }

        /* "privateAddress": {
  "city": "Ostrava",
  "country": "Česká republika",
  "countryCode": "CZ",
  "province": null,
  "street": "Ocelářská 177",
  "zipCode": "703 00"
} */
        [JsonProperty("privateAddress")]
        public object PrivateAddress { get; set; }

        /* "category": {
  "id": 96,
  "value": "kat 1"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "personClassification1": {
  "id": 97,
  "value": "kla 1"
} */
        [JsonProperty("personClassification1")]
        public object PersonClassification1 { get; set; }

        /* "personClassification2": {
  "id": 98,
  "value": "kla 2"
} */
        [JsonProperty("personClassification2")]
        public object PersonClassification2 { get; set; }

        /* "personClassification3": {
  "id": 99,
  "value": "kla 3"
} */
        [JsonProperty("personClassification3")]
        public object PersonClassification3 { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        /* "language": {
  "id": 70,
  "value": "Český"
} */
        [JsonProperty("language")]
        public object Language { get; set; }

        /* "maritalStatus": {
  "id": 78,
  "value": "Svobodný/Svobodná"
} */
        [JsonProperty("maritalStatus")]
        public object MaritalStatus { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        /* "companyAddress": {
  "address": {
    "id": 1,
    "city": "Ostrava-Poruba",
    "country": "Česká republika",
    "countryCode": "CZ",
    "province": null,
    "street": "Francouzská 6167/5",
    "zipCode": "708 00"
  },
  "territory": null
} */
        [JsonProperty("companyAddress")]
        public object CompanyAddress { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields")]
        public object CustomFields { get; set; }

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

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("activeUserAccount")]
        public bool ActiveUserAccount { get; set; }

        [JsonProperty("keyman")]
        public bool Keyman { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

        /* "inlineGdpr": [
  {
    "id": 1,
    "validFrom": "2018-01-01",
    "validTill": "2019-01-01",
    "legalTitle": "LEGITIMATE_INTEREST",
    "templateName": "Opravněný zájem",
    "gdprTemplate": 1
  }
] */
        [JsonProperty("inlineGdpr")]
        public List<object> InlineGdpr { get; set; }

    }
}
