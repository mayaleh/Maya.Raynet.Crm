// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Post
{
    public class Project
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Company { get; set; }

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Person { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Owner { get; set; }

        [JsonProperty("totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int TotalAmount { get; set; }

        [JsonProperty("avgValue.totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int AvgValue_totalAmount { get; set; }

        [JsonProperty("minValue.totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MinValue_totalAmount { get; set; }

        [JsonProperty("maxValue.totalAmount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MaxValue_totalAmount { get; set; }

        [JsonProperty("projectStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ProjectStatus { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ValidFrom { get; set; }

        [JsonProperty("scheduledEnd", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledEnd { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

    }
}
