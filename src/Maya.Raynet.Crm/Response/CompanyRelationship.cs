// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class CompanyRelationship
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "notice": null */
        [JsonProperty("notice")]
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
        [JsonProperty("companyJoin")]
        public object CompanyJoin { get; set; }

        [JsonProperty("companyJoinType")]
        public string CompanyJoinType { get; set; }

    }
}
