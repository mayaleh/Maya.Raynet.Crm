// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class User
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

        /* "person": {
  "id": 2,
  "fullName": "Milan Buldog"
} */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }

        [JsonProperty("username", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("email2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email2 { get; set; }

        [JsonProperty("userRole", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UserRole { get; set; }

        /* "personRecordFilter": null */
        [JsonProperty("personRecordFilter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonRecordFilter { get; set; }

        [JsonProperty("listExportPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ListExportPermission { get; set; }

        [JsonProperty("detailReportPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DetailReportPermission { get; set; }

        [JsonProperty("googleContactsPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool GoogleContactsPermission { get; set; }

        [JsonProperty("bulkOperationPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool BulkOperationPermission { get; set; }

        [JsonProperty("codelistEditPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CodelistEditPermission { get; set; }

        [JsonProperty("editOnlyOwnedRecordsPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool EditOnlyOwnedRecordsPermission { get; set; }

        [JsonProperty("onlyLockRecordsPermission", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool OnlyLockRecordsPermission { get; set; }

        /* "deletePermissionConfig": null */
        [JsonProperty("deletePermissionConfig", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object DeletePermissionConfig { get; set; }

        [JsonProperty("twoFactorEnabled", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool TwoFactorEnabled { get; set; }

        [JsonProperty("timezone", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Timezone { get; set; }

        [JsonProperty("dateFormat", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DateFormat { get; set; }

        [JsonProperty("timeFormat", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TimeFormat { get; set; }

        [JsonProperty("startWeekDay", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("securityLevels", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<SecurityLevel> SecurityLevels { get; set; }

        [JsonProperty("rowInfo.createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdBy { get; set; }

        [JsonProperty("rowInfo.updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedBy { get; set; }

    }
}
