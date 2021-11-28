// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Post
{
    public class BusinessAddress
    {
        /* "address": {
  "name": "Sídlo firmy",
  "street": "Francouzská 6167/5",
  "city": "Ostrava",
  "province": "Morava",
  "zipCode": "708 00",
  "country": "CZ",
  "lat": null,
  "lng": null
} */
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Address { get; set; }

        /* "contactInfo": {
  "email": "info@raynet.cz",
  "email2": "",
  "fax": "",
  "otherContact": "",
  "tel1": "+420 553 401 520",
  "tel1Type": "recepce",
  "tel2": "+420 553 401 547",
  "tel2Type": "zákaznická podpora",
  "www": "www.raynet.cz"
} */
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactInfo { get; set; }

        [JsonProperty("territory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Territory { get; set; }

    }
}
