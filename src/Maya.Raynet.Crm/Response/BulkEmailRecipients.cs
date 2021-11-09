// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BulkEmailRecipients
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        /* "massEmail": {
  "id": 9,
  "title": "Druhá emailová kampaň"
} */
        [JsonProperty("massEmail", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object MassEmail { get; set; }

        /* "company": {
  "id": 3,
  "name": "Drozd a.s."
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        /* "lead": null */
        [JsonProperty("lead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Lead { get; set; }

        /* "person": null */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Person { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("opened", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Opened { get; set; }

        /* "clicked": null */
        [JsonProperty("clicked", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Clicked { get; set; }

        /* "unsubscribed": null */
        [JsonProperty("unsubscribed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Unsubscribed { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

    }
}
