// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class LegalTitle
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "company": {
  "id": 1,
  "name": "RAYNET"
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": null */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "lead": null */
        [JsonProperty("lead")]
        public object Lead { get; set; }

        /* "gdprTemplate": {
  "id": 1,
  "name": "Oprávněný zájem",
  "legalTitle": "LEGITIMATE_INTEREST"
} */
        [JsonProperty("gdprTemplate")]
        public object GdprTemplate { get; set; }

        /* "gdprFormAgreement": null */
        [JsonProperty("gdprFormAgreement")]
        public object GdprFormAgreement { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill")]
        public string ValidTill { get; set; }

        [JsonProperty("rowInfo.createdAt")]
        public string RowInfo.createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy")]
        public string RowInfo.createdBy { get; set; }

        /* "rowInfo.updatedAt": null */
        [JsonProperty("rowInfo.updatedAt")]
        public object RowInfo.updatedAt { get; set; }

        /* "rowInfo.updatedBy": null */
        [JsonProperty("rowInfo.updatedBy")]
        public object RowInfo.updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfo.rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState")]
        public object RowInfo.rowState { get; set; }

    }
}
