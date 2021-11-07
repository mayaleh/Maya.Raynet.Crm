// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BulkEmailRecipients
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "massEmail": {
  "id": 9,
  "title": "Druhá emailová kampaň"
} */
        [JsonProperty("massEmail")]
        public object MassEmail { get; set; }

        /* "company": {
  "id": 3,
  "name": "Drozd a.s."
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "lead": null */
        [JsonProperty("lead")]
        public object Lead { get; set; }

        /* "person": null */
        [JsonProperty("person")]
        public object Person { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("opened")]
        public string Opened { get; set; }

        /* "clicked": null */
        [JsonProperty("clicked")]
        public object Clicked { get; set; }

        /* "unsubscribed": null */
        [JsonProperty("unsubscribed")]
        public object Unsubscribed { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }
}
