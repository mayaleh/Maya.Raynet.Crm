// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public partial class ContactInfo
    {
        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string Email { get; set; }

        [JsonProperty("email2", NullValueHandling = NullValueHandling.Ignore)]
        public string Email2 { get; set; }

        [JsonProperty("primary", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Primary { get; set; }

        [JsonProperty("tel1", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel1 { get; set; }

        [JsonProperty("tel1Type", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel1Type { get; set; }

        [JsonProperty("tel2", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel2 { get; set; }

        [JsonProperty("tel2Type", NullValueHandling = NullValueHandling.Ignore)]
        public string Tel2Type { get; set; }

        [JsonProperty("www", NullValueHandling = NullValueHandling.Ignore)]
        public string Www { get; set; }

        [JsonProperty("otherContact", NullValueHandling = NullValueHandling.Ignore)]
        public string OtherContact { get; set; }
    }

}