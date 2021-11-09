// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Companies
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        /* "titleBefore": null */
        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object TitleBefore { get; set; }

        /* "firstName": null */
        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object FirstName { get; set; }

        /* "lastName": null */
        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object LastName { get; set; }

        /* "titleAfter": null */
        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object TitleAfter { get; set; }

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Person { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Rating { get; set; }

        /* "owner": {
  "id": 1,
  "fullName": "RAYNET CRM"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegNumber { get; set; }

        [JsonProperty("taxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxNumber { get; set; }

        /* "taxNumber2": null */
        [JsonProperty("taxNumber2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object TaxNumber2 { get; set; }

        [JsonProperty("taxPayer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxPayer { get; set; }

        /* "primaryAddress": {
  "id": 2,
  "primary": true,
  "contactAddress": false,
  "address": {
    "id": 2,
    "city": "Ostrava-Slezská Ostrava",
    "country": "Česká republika",
    "name": "Sídlo firmy",
    "province": "Moravskoslezský kraj",
    "street": "Těšínská",
    "zipCode": "710 00",
    "lat": 49.2499446,
    "lng": 13.703011
  },
  "territory": {
    "id": 91,
    "value": "Morava"
  },
  "contactInfo": {
    "email": "test@test.cz",
    "email2": "test2@test.cz",
    "primary": true,
    "tel1": "123 456 789",
    "tel1Type": "mobil",
    "tel2": "987 654 321",
    "tel2Type": "pevná linka",
    "www": "www.test.cz",
    "otherContact": null
  }
} */
        [JsonProperty("primaryAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrimaryAddress { get; set; }

        /* "contactAddress": {
  "id": 3,
  "primary": false,
  "contactAddress": true,
  "address": {
    "id": 3,
    "city": "Ostrava-Moravská Ostrava",
    "country": "Česká republika",
    "name": "Provozovna",
    "province": "Moravskoslezský kraj",
    "street": "Českobratrská 113",
    "zipCode": "702 00",
    "lat": null,
    "lng": null
  },
  "territory": {
    "id": 91,
    "value": "Morava"
  },
  "contactInfo": {
    "email": "provozovna@test.cz",
    "email2": null,
    "primary": true,
    "tel1": "444 444 444",
    "tel1Type": "mobil",
    "tel2": "111 111 111",
    "tel2Type": "pevná linka",
    "www": null,
    "otherContact": null
  }
} */
        [JsonProperty("contactAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactAddress { get; set; }

        /* "category": {
  "id": 15,
  "value": "Zákazník"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        /* "turnover": {
  "id": 82,
  "value": "do 1 mil. Kč"
} */
        [JsonProperty("turnover", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Turnover { get; set; }

        /* "economyActivity": {
  "id": 92,
  "value": "obor 1"
} */
        [JsonProperty("economyActivity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object EconomyActivity { get; set; }

        /* "companyClassification1": {
  "id": 93,
  "value": "kla 1"
} */
        [JsonProperty("companyClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CompanyClassification1 { get; set; }

        /* "companyClassification2": {
  "id": 94,
  "value": "kla 2"
} */
        [JsonProperty("companyClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CompanyClassification2 { get; set; }

        /* "companyClassification3": {
  "id": 95,
  "value": "kla 3"
} */
        [JsonProperty("companyClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CompanyClassification3 { get; set; }

        /* "paymentTerm": {
  "id": 64,
  "value": "7 dní"
} */
        [JsonProperty("paymentTerm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PaymentTerm { get; set; }

        /* "contactSource": {
  "id": 62,
  "value": "e-mail"
} */
        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactSource { get; set; }

        /* "birthday": null */
        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Birthday { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

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

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

    }
}
