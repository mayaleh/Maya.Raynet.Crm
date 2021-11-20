// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class Payment
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("rowInfo.createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoCreatedAt { get; set; }

        [JsonProperty("rowInfo.createdBy", NullValueHandling = NullValueHandling.Ignore)]
        public string RowInfoCreatedBy { get; set; }

        [JsonProperty("rowInfo.updatedAt")]
        public object RowInfoUpdatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy")]
        public object RowInfoUpdatedBy { get; set; }

        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfoRowAccess { get; set; }

        [JsonProperty("rowInfo.rowState")]
        public object RowInfoRowState { get; set; }
    }
}