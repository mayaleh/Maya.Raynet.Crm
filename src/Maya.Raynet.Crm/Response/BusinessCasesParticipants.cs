// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class BusinessCasesParticipants
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        /* "company": {
  "id": 2,
  "name": "a"
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": {
  "id": 5,
  "fullName": "Magdaléna Pišlová"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "businessCase": {
  "id": 4,
  "code": "OP-17-001"
} */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

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

        [JsonProperty("_version")]
        public int _version { get; set; }

    }
}
