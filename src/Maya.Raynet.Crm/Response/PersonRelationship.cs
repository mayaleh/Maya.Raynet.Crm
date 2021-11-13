// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class PersonRelationship
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public Company Company { get; set; }

        [JsonProperty("companyAddress", NullValueHandling = NullValueHandling.Ignore)]
        public ComapnyAddress CompanyAddress { get; set; }

        [JsonProperty("notice", NullValueHandling = NullValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }
    }
}