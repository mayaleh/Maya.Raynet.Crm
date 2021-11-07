// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

        /* "person": {
  "id": 2,
  "fullName": "Milan Buldog"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email2")]
        public string Email2 { get; set; }

        [JsonProperty("userRole")]
        public string UserRole { get; set; }

        /* "personRecordFilter": null */
        [JsonProperty("personRecordFilter")]
        public object PersonRecordFilter { get; set; }

        [JsonProperty("listExportPermission")]
        public bool ListExportPermission { get; set; }

        [JsonProperty("detailReportPermission")]
        public bool DetailReportPermission { get; set; }

        [JsonProperty("googleContactsPermission")]
        public bool GoogleContactsPermission { get; set; }

        [JsonProperty("bulkOperationPermission")]
        public bool BulkOperationPermission { get; set; }

        [JsonProperty("codelistEditPermission")]
        public bool CodelistEditPermission { get; set; }

        [JsonProperty("editOnlyOwnedRecordsPermission")]
        public bool EditOnlyOwnedRecordsPermission { get; set; }

        [JsonProperty("onlyLockRecordsPermission")]
        public bool OnlyLockRecordsPermission { get; set; }

        /* "deletePermissionConfig": null */
        [JsonProperty("deletePermissionConfig")]
        public object DeletePermissionConfig { get; set; }

        [JsonProperty("twoFactorEnabled")]
        public bool TwoFactorEnabled { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("dateFormat")]
        public string DateFormat { get; set; }

        [JsonProperty("timeFormat")]
        public string TimeFormat { get; set; }

        [JsonProperty("startWeekDay")]
        public string StartWeekDay { get; set; }

        /* "securityLevels": [
  {
    "id": 14,
    "name": "Bezpečnostní úroveň"
  },
  {
    "id": 1,
    "name": "Sdílená"
  }
] */
        [JsonProperty("securityLevels")]
        public List<object> SecurityLevels { get; set; }

        [JsonProperty("rowInfo.createdAt")]
        public string RowInfo.createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy")]
        public string RowInfo.createdBy { get; set; }

        [JsonProperty("rowInfo.updatedAt")]
        public string RowInfo.updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy")]
        public string RowInfo.updatedBy { get; set; }

    }
}
