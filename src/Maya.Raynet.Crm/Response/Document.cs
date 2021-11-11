// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Document
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        /* "description": null */
        [JsonProperty("description", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

        /* "owner": {
  "id": 1,
  "fullName": "RAYNET CRM"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Owner { get; set; }

        /* "category": {
  "id": 289,
  "value": "Kategorie dokumentu"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Category { get; set; }

        [JsonProperty("validFrom", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ValidFrom { get; set; }

        [JsonProperty("validTill", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ValidTill { get; set; }

        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status { get; set; }

        [JsonProperty("template", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Template { get; set; }

        /* "folder": {
  "id": 8,
  "name": "Rejnoci",
  "path": "/Dokumenty/Rejnoci"
} */
        [JsonProperty("folder", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FoldersAndFiles Folder { get; set; }

        /* "attachments": [
  {
    "id": 53,
    "link": "https://seznam.cz",
    "linkName": "aaaa",
    "file": null
  },
  {
    "id": 54,
    "link": null,
    "linkName": null,
    "file": {
      "id": 488,
      "contentType": "image/jpeg",
      "fileName": "MaMaZu.jpg",
      "size": 218878
    }
  }
] */
        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        /* "link": null */
        [JsonProperty("link", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Link { get; set; }

        /* "file": {
  "id": 488,
  "contentType": "image/jpeg",
  "fileName": "MaMaZu.jpg",
  "size": 218878
} */
        [JsonProperty("file", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FileInfo File { get; set; }

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
  "id": 4,
  "name": "Asistentka/Asistent"
} */
        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SecurityLevel SecurityLevel { get; set; }

        /* "extIds": null */
        [JsonProperty("extIds", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ExtIds { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

    }
}
