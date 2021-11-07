// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Task
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        /* "category": {
  "id": 90,
  "value": "Lékař"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("personal")]
        public bool Personal { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "Petr Svetr"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "company": {
  "id": 2,
  "name": "Firma s.r.o."
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": {
  "id": 3,
  "fullName": "Pavel Dobrý"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "lead": null */
        [JsonProperty("lead")]
        public object Lead { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        /* "offer": null */
        [JsonProperty("offer")]
        public object Offer { get; set; }

        /* "salesOrder": null */
        [JsonProperty("salesOrder")]
        public object SalesOrder { get; set; }

        /* "project": null */
        [JsonProperty("project")]
        public object Project { get; set; }

        /* "activity": null */
        [JsonProperty("activity")]
        public object Activity { get; set; }

        [JsonProperty("scheduledFrom")]
        public string ScheduledFrom { get; set; }

        [JsonProperty("scheduledTill")]
        public string ScheduledTill { get; set; }

        [JsonProperty("deadline")]
        public string Deadline { get; set; }

        /* "completed": null */
        [JsonProperty("completed")]
        public object Completed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("solution")]
        public string Solution { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        [JsonProperty("rowInfo.createdAt")]
        public string RowInfo.createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy")]
        public string RowInfo.createdBy { get; set; }

        [JsonProperty("rowInfo.updatedAt")]
        public string RowInfo.updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy")]
        public string RowInfo.updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfo.rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState")]
        public object RowInfo.rowState { get; set; }

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel")]
        public object SecurityLevel { get; set; }

        /* "customFields": {
  "VIP_b91d1": false
} */
        [JsonProperty("customFields")]
        public object CustomFields { get; set; }

        /* "participants": [
  {
    "id": 123,
    "owner": false,
    "role": null,
    "name": "Martin Vosa",
    "person": 6,
    "company": 2,
    "lead": null
  },
  {
    "id": 119,
    "owner": true,
    "role": "FROM",
    "name": "Petr Svetr",
    "person": 2,
    "company": 2,
    "lead": null
  }
] */
        [JsonProperty("participants")]
        public List<object> Participants { get; set; }

        /* "recurrence": {
  "id": 5,
  "count": 3,
  "endDate": null,
  "interval": "WEEKLY",
  "recurrenceDay": 4,
  "startDate": "2018-03-05"
} */
        [JsonProperty("recurrence")]
        public object Recurrence { get; set; }

    }
}
