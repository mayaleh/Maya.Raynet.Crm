// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class SocialNetwork
    {
        [JsonProperty("facebook", NullValueHandling = NullValueHandling.Ignore)]
        public string Facebook { get; set; }

        [JsonProperty("googleplus", NullValueHandling = NullValueHandling.Ignore)]
        public string Googleplus { get; set; }

        [JsonProperty("twitter", NullValueHandling = NullValueHandling.Ignore)]
        public string Twitter { get; set; }

        [JsonProperty("linkedin", NullValueHandling = NullValueHandling.Ignore)]
        public string Linkedin { get; set; }

        [JsonProperty("pinterest", NullValueHandling = NullValueHandling.Ignore)]
        public string Pinterest { get; set; }

        [JsonProperty("instagram", NullValueHandling = NullValueHandling.Ignore)]
        public string Instagram { get; set; }

        [JsonProperty("skype", NullValueHandling = NullValueHandling.Ignore)]
        public string Skype { get; set; }

        [JsonProperty("youtube", NullValueHandling = NullValueHandling.Ignore)]
        public string Youtube { get; set; }
    }
}