// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class SalesOrder
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Company { get; set; }

        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int BusinessCase { get; set; }

        [JsonProperty("offer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Offer { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Owner { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float TotalAmount { get; set; }

        [JsonProperty("estimatedValue", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int EstimatedValue { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("salesOrderStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int SalesOrderStatus { get; set; }

    }
}
