// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response
{
    public class Message
    {
        [JsonProperty("changes", NullValueHandling = NullValueHandling.Ignore)]
        public List<Change> Changes { get; set; }
    }
}