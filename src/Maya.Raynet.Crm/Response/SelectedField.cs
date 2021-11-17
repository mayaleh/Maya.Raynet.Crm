// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class SelectedField
    {
        [JsonProperty("lead", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Lead { get; set; }

        [JsonProperty("field", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Field { get; set; }

        [JsonProperty("person", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Person { get; set; }

        [JsonProperty("company", NullValueHandling = NullValueHandling.Ignore)]
        public List<object> Company { get; set; }
    }
}
