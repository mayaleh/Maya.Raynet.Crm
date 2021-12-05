// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Post
{
    public class BulkPriceListItem
    {
        [JsonProperty("price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal Price { get; set; }

        [JsonProperty("product", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Product { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("unit", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Unit { get; set; }

        [JsonProperty("cost", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal Cost { get; set; }

        [JsonProperty("taxRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public decimal TaxRate { get; set; }
    }
}
