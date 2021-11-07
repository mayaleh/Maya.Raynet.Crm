// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Companies
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        /* "titleBefore": null */
        [JsonProperty("titleBefore")]
        public object TitleBefore { get; set; }

        /* "firstName": null */
        [JsonProperty("firstName")]
        public object FirstName { get; set; }

        /* "lastName": null */
        [JsonProperty("lastName")]
        public object LastName { get; set; }

        /* "titleAfter": null */
        [JsonProperty("titleAfter")]
        public object TitleAfter { get; set; }

        [JsonProperty("person")]
        public bool Person { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("rating")]
        public string Rating { get; set; }

        /* "owner": {
  "id": 1,
  "fullName": "RAYNET CRM"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("regNumber")]
        public string RegNumber { get; set; }

        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        /* "taxNumber2": null */
        [JsonProperty("taxNumber2")]
        public object TaxNumber2 { get; set; }

        [JsonProperty("taxPayer")]
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
        [JsonProperty("primaryAddress")]
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
        [JsonProperty("contactAddress")]
        public object ContactAddress { get; set; }

        /* "category": {
  "id": 15,
  "value": "Zákazník"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "turnover": {
  "id": 82,
  "value": "do 1 mil. Kč"
} */
        [JsonProperty("turnover")]
        public object Turnover { get; set; }

        /* "economyActivity": {
  "id": 92,
  "value": "obor 1"
} */
        [JsonProperty("economyActivity")]
        public object EconomyActivity { get; set; }

        /* "companyClassification1": {
  "id": 93,
  "value": "kla 1"
} */
        [JsonProperty("companyClassification1")]
        public object CompanyClassification1 { get; set; }

        /* "companyClassification2": {
  "id": 94,
  "value": "kla 2"
} */
        [JsonProperty("companyClassification2")]
        public object CompanyClassification2 { get; set; }

        /* "companyClassification3": {
  "id": 95,
  "value": "kla 3"
} */
        [JsonProperty("companyClassification3")]
        public object CompanyClassification3 { get; set; }

        /* "paymentTerm": {
  "id": 64,
  "value": "7 dní"
} */
        [JsonProperty("paymentTerm")]
        public object PaymentTerm { get; set; }

        /* "contactSource": {
  "id": 62,
  "value": "e-mail"
} */
        [JsonProperty("contactSource")]
        public object ContactSource { get; set; }

        /* "birthday": null */
        [JsonProperty("birthday")]
        public object Birthday { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

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

        [JsonProperty("_version")]
        public int _version { get; set; }

    }
}
