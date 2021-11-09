// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Events
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("personal", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Personal { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        /* "category": {
  "id": 95,
  "value": "Zdravý duch"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        /* "activity": null */
        [JsonProperty("activity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Activity { get; set; }

        /* "company": {
  "id": 2,
  "name": "Dobrý spánek s.r.o."
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        /* "person": null */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Person { get; set; }

        /* "lead": null */
        [JsonProperty("lead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Lead { get; set; }

        /* "project": null */
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Project { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCase { get; set; }

        /* "offer": null */
        [JsonProperty("offer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Offer { get; set; }

        /* "salesOrder": null */
        [JsonProperty("salesOrder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SalesOrder { get; set; }

        [JsonProperty("scheduledFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledFrom { get; set; }

        [JsonProperty("scheduledTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ScheduledTill { get; set; }

        [JsonProperty("completed", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Completed { get; set; }

        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

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

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

        /* "participants": [
  {
    "owner": true,
    "role": "FROM",
    "name": "Petr Svetr",
    "person": 2,
    "company": null,
    "lead": null
  },
  {
    "owner": false,
    "role": null,
    "name": "Petr Svetr",
    "person": 2,
    "company": null,
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

        [JsonProperty("meetingPlace", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MeetingPlace { get; set; }

        /* "companyAddress": {
  "city": "Ostrava",
  "country": "Česká republika",
  "province": null,
  "street": "Sokolská tř. 1263/24",
  "zipCode": "702 00"
} */
        [JsonProperty("companyAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CompanyAddress { get; set; }

    }
}
