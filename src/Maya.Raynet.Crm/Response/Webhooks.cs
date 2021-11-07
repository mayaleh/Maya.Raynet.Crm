// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Webhooks
    {
        [JsonProperty("technicalContacts")]
        public List<string> TechnicalContacts { get; set; }

        /* "webhooks": [
  {
    "webhookId": "cb83cfc88bee4c90ab3111f3dc2b7dfb",
    "url": "https://webhook.site",
    "secretToken": "tajne-heslo",
    "eventsFilter": [
      "record.created",
      "record.updated",
      "record.deleted"
    ]
  }
] */
        [JsonProperty("webhooks")]
        public List<object> Webhooks { get; set; }

    }
}
