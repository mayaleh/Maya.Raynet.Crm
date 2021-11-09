// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Leads
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("leadDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LeadDate { get; set; }

        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Topic { get; set; }

        /* "leadPhase": {
  "id": 105,
  "code01": "V řešení",
  "color": "c14d00",
  "status": "B_ACTIVE",
  "locked": false
} */
        [JsonProperty("leadPhase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object LeadPhase { get; set; }

        /* "owner": {
  "id": 63,
  "fullName": "Pan Tau"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Owner { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        /* "company": {
  "id": 1093,
  "name": "Králíček"
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Company { get; set; }

        /* "person": {
  "id": 16255,
  "fullName": "Pan Ušák"
} */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Person { get; set; }

        /* "businessCase": {
  "id": 8824,
  "code": "OP-21-809",
  "name": "Zájemce o zeleninu"
} */
        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object BusinessCase { get; set; }

        [JsonProperty("companyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /* "convertDate": null */
        [JsonProperty("convertDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ConvertDate { get; set; }

        /* "contactSource": {
  "id": 815,
  "value": "web A - našli nás na internetu"
} */
        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactSource { get; set; }

        /* "category": null */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Category { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        /* "contactInfo": {
  "email": "kralicek@mrkev.cz",
  "email2": "test@mrkev.cz",
  "tel1": "123456789",
  "tel1Type": "mobil",
  "tel2": null,
  "tel2Type": null,
  "www": null,
  "fax": null,
  "otherContact": null
} */
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactInfo { get; set; }

        /* "address": {
  "city": "Velká Lhota",
  "countryName": "Česká republika",
  "countryCode": "CZ",
  "street": "Hlavní ulice",
  "province": "Jihomoravký kraj",
  "zipCode": "123 00",
  "lat": null,
  "lng": null
} */
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Address { get; set; }

        /* "socialNetworkContact": {
  "facebook": null,
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

        /* "customFields": null */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

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

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SecurityLevel { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<> Tags { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        /* "regNumber": null */
        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object RegNumber { get; set; }

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

    }
}
