// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class EmailStatistics
    {
        [JsonProperty("sent", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Sent { get; set; }

        [JsonProperty("clicked", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Clicked { get; set; }

        [JsonProperty("opened", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Opened { get; set; }

        [JsonProperty("unsubscribed", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ParseStringToLongConverter))]
        public long? Unsubscribed { get; set; }
    }
}