// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class SalesOrderItem
    {
        [JsonProperty("productCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProductCode { get; set; }

        [JsonProperty("priceList", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int PriceList { get; set; }

        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Count { get; set; }

        [JsonProperty("price", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Price { get; set; }

        [JsonProperty("taxRate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TaxRate { get; set; }

        [JsonProperty("discountPercent", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float DiscountPercent { get; set; }

        [JsonProperty("cost", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Cost { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

    }
}
