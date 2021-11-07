// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Leads
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("leadDate")]
        public string LeadDate { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        /* "leadPhase": {
  "id": 105,
  "code01": "V řešení",
  "color": "c14d00",
  "status": "B_ACTIVE",
  "locked": false
} */
        [JsonProperty("leadPhase")]
        public object LeadPhase { get; set; }

        /* "owner": {
  "id": 63,
  "fullName": "Pan Tau"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        /* "company": {
  "id": 1093,
  "name": "Králíček"
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": {
  "id": 16255,
  "fullName": "Pan Ušák"
} */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "businessCase": {
  "id": 8824,
  "code": "OP-21-809",
  "name": "Zájemce o zeleninu"
} */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /* "convertDate": null */
        [JsonProperty("convertDate")]
        public object ConvertDate { get; set; }

        /* "contactSource": {
  "id": 815,
  "value": "web A - našli nás na internetu"
} */
        [JsonProperty("contactSource")]
        public object ContactSource { get; set; }

        /* "category": null */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("firstName")]
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
        [JsonProperty("contactInfo")]
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
        [JsonProperty("address")]
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
        [JsonProperty("socialNetworkContact")]
        public object SocialNetworkContact { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields")]
        public object CustomFields { get; set; }

        [JsonProperty("rowInfo.createdAt")]
        public string RowInfo.createdAt { get; set; }

        [JsonProperty("rowInfo.createdBy")]
        public string RowInfo.createdBy { get; set; }

        /* "rowInfo.updatedAt": null */
        [JsonProperty("rowInfo.updatedAt")]
        public object RowInfo.updatedAt { get; set; }

        /* "rowInfo.updatedBy": null */
        [JsonProperty("rowInfo.updatedBy")]
        public object RowInfo.updatedBy { get; set; }

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

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        /* "regNumber": null */
        [JsonProperty("regNumber")]
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
        [JsonProperty("inlineGdpr")]
        public List<object> InlineGdpr { get; set; }

    }
}
