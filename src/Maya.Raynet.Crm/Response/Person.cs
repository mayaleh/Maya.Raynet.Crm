// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Person
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleBefore { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleAfter { get; set; }

        /* "owner": {
  "id": 2,
  "fullName": "test test"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        /* "category": {
  "id": 96,
  "value": "kat 1"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        /* "primaryRelationship": {
  "id": 1,
  "type": "oddělení podpory",
  "company": {
    "id": 2,
    "name": "RAYNET s.r.o."
  }
} */
        [JsonProperty("primaryRelationship", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrimaryRelationship { get; set; }

        /* "personClassification1": {
  "id": 97,
  "value": "kla 1"
} */
        [JsonProperty("personClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonClassification1 { get; set; }

        /* "personClassification2": {
  "id": 98,
  "value": "kla 2"
} */
        [JsonProperty("personClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonClassification2 { get; set; }

        /* "personClassification3": {
  "id": 99,
  "value": "kla 3"
} */
        [JsonProperty("personClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PersonClassification3 { get; set; }

        [JsonProperty("salutation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Salutation { get; set; }

        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Birthday { get; set; }

        /* "language": {
  "id": 70,
  "value": "čeština"
} */
        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Language { get; set; }

        /* "maritalStatus": {
  "id": 78,
  "value": "Svobodná/Svobodný"
} */
        [JsonProperty("maritalStatus", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object MaritalStatus { get; set; }

        [JsonProperty("gender", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Gender { get; set; }

        /* "contactInfo": {
  "email": "podpora@raynet.cz",
  "email2": "13123@4123.cz",
  "tel1": "+420 553 401 547",
  "tel1Type": "mobil",
  "tel2": "13213",
  "tel2Type": "mobil",
  "www": "www.w.cz",
  "fax": "+ 420 321 987 377",
  "otherContact": "další kontakt"
} */
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactInfo { get; set; }

        /* "socialNetworkContact": {
  "facebook": "vylezikovaface",
  "googleplus": null,
  "twitter": null,
  "linkedin": null,
  "pinterest": null,
  "instagram": null,
  "skype": null,
  "youtube": null
} */
        [JsonProperty("socialNetworkContact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SocialNetworkContact { get; set; }

        /* "privateAddress": {
  "city": "Ostrava-Poruba",
  "country": "Česká republika",
  "countryCode": "CZ",
  "province": "Moravskoslezský kraj",
  "street": "Francouzská 5",
  "zipCode": "708 00"
} */
        [JsonProperty("privateAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PrivateAddress { get; set; }

        /* "customFields": {
  "VIP_b91d1": true
} */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

        [JsonProperty("rowInfo.createdAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_createdAt { get; set; }

        [JsonProperty("rowInfo.updatedAt", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_updatedAt { get; set; }

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

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        /* "photo": {
  "id": 428,
  "contentType": "image/png",
  "fileName": "photo.png",
  "size": 17485
} */
        [JsonProperty("photo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Photo { get; set; }

        [JsonProperty("activeUserAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ActiveUserAccount { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

        /* "attachments": [
  {
    "id": 235,
    "link": "http://www.seznam.cz",
    "linkName": "seznam",
    "file": null,
    "folder": null
  }
] */
        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Attachments { get; set; }

        /* "relationships": [
  {
    "id": 1,
    "company": {
      "id": 1,
      "name": "RAYNET s.r.o."
    },
    "companyAddress": {
      "id": 1,
      "name": "Sídlo firmy"
    },
    "notice": null,
    "primary": true,
    "type": "péče o zákazníky"
  }
] */
        [JsonProperty("relationships", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> Relationships { get; set; }

        /* "inlineGdpr": [
  {
    "id": 1,
    "validFrom": "2018-01-01",
    "validTill": "2019-01-01",
    "legalTitle": "LEGITIMATE_INTEREST",
    "templateName": "Opravněný zájem",
    "gdprTemplate": 1
  }
] */
        [JsonProperty("inlineGdpr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<object> InlineGdpr { get; set; }

        [JsonProperty("keyman", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Keyman { get; set; }

        /* "originLead": {
  "id": 4,
  "code": "L-18-002",
  "topic": "Můj lead"
} */
        [JsonProperty("originLead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object OriginLead { get; set; }

    }
}
