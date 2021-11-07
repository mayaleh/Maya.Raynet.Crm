// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Notifications
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "context": [
  {
    "entityName": "Company",
    "entityId": 4,
    "entityTab": "basic",
    "value": "Test NX s.r.o."
  }
] */
        [JsonProperty("context")]
        public List<object> Context { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        /* "message": {
  "changes": [
    {
      "label": "Název",
      "oldValue": "Test s.r.o.",
      "newValue": "Test NX s.r.o."
    }
  ]
} */
        [JsonProperty("message")]
        public object Message { get; set; }

        /* "sender": {
  "id": 2,
  "fullName": "Petr Svetr"
} */
        [JsonProperty("sender")]
        public object Sender { get; set; }

        /* "recipient": {
  "id": 9,
  "fullName": "Jan Novák"
} */
        [JsonProperty("recipient")]
        public object Recipient { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }

        [JsonProperty("flag")]
        public bool Flag { get; set; }

    }
}
