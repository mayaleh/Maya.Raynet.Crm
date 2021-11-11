// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class LoadConfiguration
    {
        /* "Company": [
  {
    "label": "Číslo klienta",
    "dataType": "STRING",
    "enumeration": [],
    "groupName": "Interní",
    "name": "Cislo_klie_cd702"
  },
  {
    "label": "Spolupráce od",
    "dataType": "DATE",
    "enumeration": [],
    "groupName": "Interní",
    "name": "Spoluprace_2aa2c"
  }
] */
        [JsonProperty("Company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Company { get; set; }

        /* "Person": [
  {
    "label": "VIP",
    "dataType": "BOOLEAN",
    "enumeration": [],
    "groupName": "Interní",
    "name": "VIP_b91d1"
  }
] */
        [JsonProperty("Person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Person { get; set; }

        /* "BusinessCase": [
  {
    "label": "Priorita OP",
    "dataType": "ENUMERATION",
    "enumeration": [
      "TOP",
      "Velká",
      "Střední",
      "Malá"
    ],
    "groupName": "Priorita",
    "name": "Priorita_O_a5fab"
  }
] */
        [JsonProperty("BusinessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<BusinessCase> BusinessCase { get; set; }

        [JsonProperty("Offer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Offer> Offer { get; set; }

        [JsonProperty("SalesOrder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Order> SalesOrder { get; set; }

        [JsonProperty("Product", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Product> Product { get; set; }

    }
}
