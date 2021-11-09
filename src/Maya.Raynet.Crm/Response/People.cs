// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class People
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleBefore { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleAfter { get; set; }

        /* "primaryRelationship": {
  "id": 1,
  "type": "konzultant",
  "company": {
    "id": 1,
    "name": "RAYNET s.r.o."
  }
} */
        [JsonProperty("primaryRelationship", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrimaryRelationship { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "test test"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactInfo { get; set; }

        /* "privateAddress": {
  "city": "Ostrava",
  "country": "Česká republika",
  "countryCode": "CZ",
  "province": null,
  "street": "Ocelářská 177",
  "zipCode": "703 00"
} */
        [JsonProperty("privateAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrivateAddress { get; set; }

        /* "category": {
  "id": 96,
  "value": "kat 1"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        /* "personClassification1": {
  "id": 97,
  "value": "kla 1"
} */
        [JsonProperty("personClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonClassification1 { get; set; }

        /* "personClassification2": {
  "id": 98,
  "value": "kla 2"
} */
        [JsonProperty("personClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonClassification2 { get; set; }

        /* "personClassification3": {
  "id": 99,
  "value": "kla 3"
} */
        [JsonProperty("personClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonClassification3 { get; set; }

        [JsonProperty("salutation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Salutation { get; set; }

        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Birthday { get; set; }

        /* "language": {
  "id": 70,
  "value": "Český"
} */
        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Language { get; set; }

        /* "maritalStatus": {
  "id": 78,
  "value": "Svobodný/Svobodná"
} */
        [JsonProperty("maritalStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object MaritalStatus { get; set; }

        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("companyAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CompanyAddress { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

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

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("activeUserAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ActiveUserAccount { get; set; }

        [JsonProperty("keyman", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Keyman { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<> Tags { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("inlineGdpr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> InlineGdpr { get; set; }

    }
}
