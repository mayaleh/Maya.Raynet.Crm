// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class WebhookList
    {
        [JsonProperty("technicalContacts", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("webhooks", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Webhook> Webhooks { get; set; }

    }
}
