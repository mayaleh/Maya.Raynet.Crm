// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class CompanyRelationship
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        /* "notice": null */
        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Notice { get; set; }

        /* "companyJoin": {
  "id": 1,
  "name": "RAYNET s.r.o.",
  "role": "C_SUPPLIER",
  "state": "A_POTENTIAL",
  "regNumber": "26843820",
  "rating": "A",
  "primaryAddress": {
    "id": 1,
    "primary": null,
    "address": {
      "id": 1,
      "city": "Ostrava-Poruba",
      "country": "Česká republika",
      "countryCode": "CZ",
      "name": null,
      "province": null,
      "street": null,
      "zipCode": null,
      "lat": null,
      "lng": null
    },
    "contactInfo": {
      "primary": null,
      "email": "info@raynet.cz",
      "email2": null,
      "tel1": "+420 553 401 520",
      "tel1Type": null,
      "tel2": null,
      "tel2Type": null,
      "fax": null,
      "www": null,
      "otherContact": null
    },
    "territory": {
      "id": 90,
      "value": "aaaaaa"
    }
  }
} */
        [JsonProperty("companyJoin", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company CompanyJoin { get; set; }

        [JsonProperty("companyJoinType", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CompanyJoinType { get; set; }

    }
}
