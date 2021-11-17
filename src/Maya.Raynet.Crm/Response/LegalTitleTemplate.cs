// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class LegalTitleTemplate
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("legalTitle", NullValueHandling = NullValueHandling.Ignore)]
        public string LegalTitle { get; set; }

        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("selectedField", NullValueHandling = NullValueHandling.Ignore)]
        public SelectedField SelectedField { get; set; }

        [JsonProperty("gdprTypeAgreement", NullValueHandling = NullValueHandling.Ignore)]
        public List<long> GdprTypeAgreement { get; set; }

        [JsonProperty("gdprContract", NullValueHandling = NullValueHandling.Ignore)]
        public IdValue GdprContract { get; set; }

        [JsonProperty("gdprFormAgreement", NullValueHandling = NullValueHandling.Ignore)]
        public IdValue GdprFormAgreement { get; set; }

        [JsonProperty("gdprLawRegulation", NullValueHandling = NullValueHandling.Ignore)]
        public IdValue GdprLawRegulation { get; set; }

        [JsonProperty("_version", NullValueHandling = NullValueHandling.Ignore)]
        public long? Version { get; set; }

        [JsonProperty("rowInfo.createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoCreatedAt { get; set; }

        [JsonProperty("rowInfo.createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoCreatedBy { get; set; }

        [JsonProperty("rowInfo.updatedAt", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoUpdatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoUpdatedBy { get; set; }

        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfoRowAccess { get; set; }

        [JsonProperty("rowInfo.rowState")]
        public object RowInfoRowState { get; set; }
    }
}
