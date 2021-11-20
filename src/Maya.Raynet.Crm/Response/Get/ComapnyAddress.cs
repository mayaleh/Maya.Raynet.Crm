// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class ComapnyAddress
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        [JsonProperty("contactAddress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContactAddress { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public Address Address { get; set; }

        [JsonProperty("territory", NullValueHandling = NullValueHandling.Ignore)]
        public IdValue Territory { get; set; }

        [JsonProperty("contactInfo", NullValueHandling = NullValueHandling.Ignore)]
        public ContactInfo ContactInfo { get; set; }
    }

}