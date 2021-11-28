// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Credit
    {
        [JsonProperty("invoiceId", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int InvoiceId { get; set; }

        [JsonProperty("reason", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Reason { get; set; }

    }
}
