// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
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
        public List<object> BusinessCase { get; set; }

        [JsonProperty("Offer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Offer { get; set; }

        [JsonProperty("SalesOrder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> SalesOrder { get; set; }

        [JsonProperty("Product", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Product { get; set; }

    }
}
