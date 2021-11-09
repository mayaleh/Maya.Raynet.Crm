// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Company
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Person { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleBefore { get; set; }

        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleAfter { get; set; }

        [JsonProperty("salutation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Salutation { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Owner Owner { get; set; }

        [JsonProperty("rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Rating { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Category { get; set; }

        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue ContactSource { get; set; }

        /* "employeesNumber": {
  "id": 64,
  "value": "1 - 10"
} */
        [JsonProperty("employeesNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue EmployeesNumber { get; set; }

        /* "legalForm": {
  "id": 64,
  "value": "s.r.o."
} */
        [JsonProperty("legalForm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue LegalForm { get; set; }

        /* "paymentTerm": {
  "id": 64,
  "value": "7 dní"
} */
        [JsonProperty("paymentTerm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue PaymentTerm { get; set; }

        /* "turnover": {
  "id": 82,
  "value": "do 1 mil. Kč"
} */
        [JsonProperty("turnover", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Turnover { get; set; }

        /* "economyActivity": {
  "id": 92,
  "value": "obor 1"
} */
        [JsonProperty("economyActivity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue EconomyActivity { get; set; }

        /* "companyClassification1": {
  "id": 93,
  "value": "kla 1"
} */
        [JsonProperty("companyClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue CompanyClassification1 { get; set; }

        /* "companyClassification2": {
  "id": 94,
  "value": "kla 2"
} */
        [JsonProperty("companyClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue CompanyClassification2 { get; set; }

        /* "companyClassification3": {
  "id": 95,
  "value": "kla 3"
} */
        [JsonProperty("companyClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue CompanyClassification3 { get; set; }

        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegNumber { get; set; }

        [JsonProperty("taxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxNumber { get; set; }

        /* "taxNumber2": null */
        [JsonProperty("taxNumber2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxNumber2 { get; set; }

        [JsonProperty("taxPayer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxPayer { get; set; }

        [JsonProperty("bankAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankAccount { get; set; }

        /* "birthday": null */
        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? Birthday { get; set; }

        /*{ "primaryAddress": {
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
    "lat": null,
    "lng": null
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
  }}
} */
        [JsonProperty("primaryAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ComapnyAddress PrimaryAddress { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /* "logo": {
  "id": 428,
  "contentType": "image/png",
  "fileName": "logo.png",
  "size": 17485
} */
        [JsonProperty("logo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Logo { get; set; }

        /* "socialNetworkContact": {
  "facebook": "abcd",
  "googleplus": null,
  "twitter": null,
  "linkedin": null,
  "pinterest": null,
  "instagram": null,
  "skype": null,
  "youtube": null
} */
        [JsonProperty("socialNetworkContact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SocialNetworkContact { get; set; }

        /* "customFields": {
  "Cislo_klie_cd702": "AB123",
  "Lonsky_zis_7aac1": 500,
  "Spoluprace_2aa2c": "2016-02-02"
} */
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

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

        /* "attachments": [
  {
    "id": 213,
    "link": null,
    "linkName": null,
    "file": {
      "id": 631,
      "contentType": "application/zip",
      "fileName": "test_zip.zip",
      "size": 4413
    },
    "folder": "Test"
  }
] */
        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Attachments { get; set; }

        /* "addresses": [
  {
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
      "lat": null,
      "lng": null
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
  },
  {
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
  }
] */
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Addresses { get; set; }

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

        /* "originLead": {
  "id": 4,
  "code": "L-18-002",
  "topic": "Můj lead"
} */
        [JsonProperty("originLead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object OriginLead { get; set; }

    }
}
