// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Events
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("personal")]
        public bool Personal { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        /* "category": {
  "id": 95,
  "value": "Zdravý duch"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        /* "activity": null */
        [JsonProperty("activity")]
        public object Activity { get; set; }

        /* "company": {
  "id": 2,
  "name": "Dobrý spánek s.r.o."
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": null */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "lead": null */
        [JsonProperty("lead")]
        public object Lead { get; set; }

        /* "project": null */
        [JsonProperty("project")]
        public object Project { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        /* "offer": null */
        [JsonProperty("offer")]
        public object Offer { get; set; }

        /* "salesOrder": null */
        [JsonProperty("salesOrder")]
        public object SalesOrder { get; set; }

        [JsonProperty("scheduledFrom")]
        public string ScheduledFrom { get; set; }

        [JsonProperty("scheduledTill")]
        public string ScheduledTill { get; set; }

        [JsonProperty("completed")]
        public string Completed { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

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

        [JsonProperty("_version")]
        public int _version { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields")]
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

        [JsonProperty("meetingPlace")]
        public string MeetingPlace { get; set; }

        /* "companyAddress": {
  "city": "Ostrava",
  "country": "Česká republika",
  "province": null,
  "street": "Sokolská tř. 1263/24",
  "zipCode": "702 00"
} */
        [JsonProperty("companyAddress")]
        public object CompanyAddress { get; set; }

    }
}
