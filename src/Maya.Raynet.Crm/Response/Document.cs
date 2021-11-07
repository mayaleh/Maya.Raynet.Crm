// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Document
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        /* "description": null */
        [JsonProperty("description")]
        public object Description { get; set; }

        /* "owner": {
  "id": 1,
  "fullName": "RAYNET CRM"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        /* "category": {
  "id": 289,
  "value": "Kategorie dokumentu"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("validFrom")]
        public string ValidFrom { get; set; }

        [JsonProperty("validTill")]
        public string ValidTill { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("template")]
        public bool Template { get; set; }

        /* "folder": {
  "id": 8,
  "name": "Rejnoci",
  "path": "/Dokumenty/Rejnoci"
} */
        [JsonProperty("folder")]
        public object Folder { get; set; }

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
        [JsonProperty("attachments")]
        public List<object> Attachments { get; set; }

        /* "link": null */
        [JsonProperty("link")]
        public object Link { get; set; }

        /* "file": {
  "id": 488,
  "contentType": "image/jpeg",
  "fileName": "MaMaZu.jpg",
  "size": 218878
} */
        [JsonProperty("file")]
        public object File { get; set; }

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
  "id": 4,
  "name": "Asistentka/Asistent"
} */
        [JsonProperty("securityLevel")]
        public object SecurityLevel { get; set; }

        /* "extIds": null */
        [JsonProperty("extIds")]
        public object ExtIds { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

    }
}
