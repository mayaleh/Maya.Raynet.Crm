// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using Newtonsoft.Json;

namespace Maya.Raynet.Crm.Response.Get
{
    public class ProjectParticipant
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Id { get; set; }

        /* "company": {
  "id": 2,
  "name": "a"
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }

        /* "person": {
  "id": 5,
  "fullName": "Magdaléna Pišlová"
} */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }

        /* "project": {
  "id": 4,
  "code": "PRO-17-001"
} */
        [JsonProperty("project", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Project Project { get; set; }

        [JsonProperty("note", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Note { get; set; }

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

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Version { get; set; }

    }
}
