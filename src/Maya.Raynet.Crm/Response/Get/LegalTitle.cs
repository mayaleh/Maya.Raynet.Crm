// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class LegalTitle
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        /* "company": {
  "id": 1,
  "name": "RAYNET"
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }

        /* "person": null */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }

        /* "lead": null */
        [JsonProperty("lead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Lead Lead { get; set; }

        /* "gdprTemplate": {
  "id": 1,
  "name": "Oprávněný zájem",
  "legalTitle": "LEGITIMATE_INTEREST"
} */
        [JsonProperty("gdprTemplate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object GdprTemplate { get; set; }

        /* "gdprFormAgreement": null */
        [JsonProperty("gdprFormAgreement", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object GdprFormAgreement { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ValidFrom { get; set; }

        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ValidTill { get; set; }

        [JsonProperty("rowInfo.createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdBy { get; set; }

        /* "rowInfo.updatedAt": null */
        [JsonProperty("rowInfo.updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_updatedAt { get; set; }

        /* "rowInfo.updatedBy": null */
        [JsonProperty("rowInfo.updatedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_rowState { get; set; }

    }
}
