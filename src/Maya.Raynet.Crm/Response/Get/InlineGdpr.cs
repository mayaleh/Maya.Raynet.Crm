// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class InlineGdpr
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("validFrom", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ValidFrom { get; set; }

        [JsonProperty("validTill", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ValidTill { get; set; }

        [JsonProperty("legalTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalTitle { get; set; }

        [JsonProperty("templateName", NullValueHandling = NullValueHandling.Ignore)]
        public string TemplateName { get; set; }

        [JsonProperty("gdprTemplate", NullValueHandling = NullValueHandling.Ignore)]
        public long? GdprTemplate { get; set; }
    }
}