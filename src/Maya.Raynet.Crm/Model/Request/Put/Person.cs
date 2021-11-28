// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Person
    {
        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleBefore { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleAfter { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Owner { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Category { get; set; }

        [JsonProperty("personClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PersonClassification1 { get; set; }

        [JsonProperty("personClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PersonClassification2 { get; set; }

        [JsonProperty("personClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PersonClassification3 { get; set; }

        [JsonProperty("salutation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Salutation { get; set; }

        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Birthday { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Language { get; set; }

        [JsonProperty("maritalStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaritalStatus { get; set; }

        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gender { get; set; }

        /* "contactInfo": {
  "email": "podpora@raynet.cz",
  "email2": "13123@4123.cz",
  "tel1": "+420 553 401 547",
  "tel1Type": "mobil",
  "tel2": "13213",
  "tel2Type": "mobil",
  "www": "www.w.cz",
  "fax": "+ 420 321 987 377",
  "otherContact": "další informace"
} */
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactInfo { get; set; }

        /* "privateAddress": {
  "city": "Ostrava-Poruba",
  "country": "Česká republika",
  "province": "Moravskoslezský kraj",
  "street": "Francouzská 5",
  "zipCode": "708 00"
} */
        [JsonProperty("privateAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrivateAddress { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        /* "relationship": {
  "company": 1,
  "companyAddress": 1,
  "notice": "Podpora pro zákazníky",
  "type": "podpora"
} */
        [JsonProperty("relationship", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Relationship { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("keyman", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Keyman { get; set; }

    }
}
