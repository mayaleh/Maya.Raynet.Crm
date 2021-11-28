// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Company
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int SecurityLevel { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Owner { get; set; }

        [JsonProperty("rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Rating { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Category { get; set; }

        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ContactSource { get; set; }

        [JsonProperty("employeesNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EmployeesNumber { get; set; }

        [JsonProperty("legalForm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int LegalForm { get; set; }

        [JsonProperty("paymentTerm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PaymentTerm { get; set; }

        [JsonProperty("turnover", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Turnover { get; set; }

        [JsonProperty("economyActivity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EconomyActivity { get; set; }

        [JsonProperty("companyClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int CompanyClassification1 { get; set; }

        [JsonProperty("companyClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int CompanyClassification2 { get; set; }

        [JsonProperty("companyClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int CompanyClassification3 { get; set; }

        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegNumber { get; set; }

        [JsonProperty("taxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxNumber { get; set; }

        [JsonProperty("taxPayer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxPayer { get; set; }

        [JsonProperty("bankAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankAccount { get; set; }

        /* "addresses": [
  {
    "address": {
      "name": "Sídlo firmy",
      "street": "Francouzská 6167/5",
      "city": "Ostrava",
      "province": "Morava",
      "zipCode": "708 00",
      "country": "CZ",
      "lat": 49.827486,
      "lng": 18.186497
    },
    "contactInfo": {
      "email": "info@raynet.cz",
      "email2": "",
      "fax": "",
      "otherContact": "",
      "tel1": "+420 553 401 520",
      "tel1Type": "recepce",
      "tel2": "+420 553 401 547",
      "tel2Type": "zákaznická podpora",
      "www": "www.raynet.cz"
    },
    "territory": 12
  }
] */
        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Addresses { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /* "customFields": {
  "Spoluprace_2aa2c": "2013-01-01"
} */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

    }
}
