// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Notification
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        /* "context": [
  {
    "entityName": "Company",
    "entityId": 4,
    "entityTab": "basic",
    "value": "Test NX s.r.o."
  }
] */
        [JsonProperty("context", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Context> Context { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        /* "message": {
  "changes": [
    {
      "label": "Název",
      "oldValue": "Test s.r.o.",
      "newValue": "Test NX s.r.o."
    }
  ]
} */
        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message Message { get; set; }

        /* "sender": {
  "id": 2,
  "fullName": "Petr Svetr"
} */
        [JsonProperty("sender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Sender { get; set; }

        /* "recipient": {
  "id": 9,
  "fullName": "Jan Novák"
} */
        [JsonProperty("recipient", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Recipient { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("read", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Read { get; set; }

        [JsonProperty("flag", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Flag { get; set; }

    }
}
