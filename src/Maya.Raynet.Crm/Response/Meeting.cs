// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Meeting
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        /* "category": {
  "id": 90,
  "value": "Lékař"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("personal", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Personal { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "Petr Svetr"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        /* "company": {
  "id": 2,
  "name": "Firma s.r.o."
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        /* "lead": null */
        [JsonProperty("lead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Lead { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCase { get; set; }

        /* "offer": null */
        [JsonProperty("offer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Offer { get; set; }

        /* "salesOrder": null */
        [JsonProperty("salesOrder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SalesOrder { get; set; }

        /* "project": null */
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Project { get; set; }

        /* "activity": null */
        [JsonProperty("activity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Activity { get; set; }

        [JsonProperty("scheduledFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledFrom { get; set; }

        [JsonProperty("scheduledTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledTill { get; set; }

        /* "completed": null */
        [JsonProperty("completed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Completed { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("solution", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Solution { get; set; }

        [JsonProperty("meetingPlace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MeetingPlace { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("rowInfo.createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdBy { get; set; }

        [JsonProperty("rowInfo.updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_rowAccess { get; set; }

        /* "rowInfo.rowState": null */
        [JsonProperty("rowInfo.rowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RowInfo_rowState { get; set; }

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SecurityLevel { get; set; }

        /* "customFields": {
  "VIP_b91d1": false
} */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
    "id": 120,
    "owner": false,
    "role": null,
    "name": "První lead",
    "person": null,
    "company": null,
    "lead": 18
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
        [JsonProperty("participants", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Participants { get; set; }

        /* "recurrence": {
  "id": 5,
  "count": 3,
  "endDate": null,
  "interval": "WEEKLY",
  "recurrenceDay": 4,
  "startDate": "2018-03-05"
} */
        [JsonProperty("recurrence", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Recurrence { get; set; }

    }
}
