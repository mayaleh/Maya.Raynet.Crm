// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:38:09 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Lead
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
  "id": 1,
  "fullName": "RAYNET CRM"
} */
        [JsonProperty("owner")]
        public object Owner { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        /* "company": {
  "id": 1093,
  "name": "Neteče a nepoteče s.r.o"
} */
        [JsonProperty("company")]
        public object Company { get; set; }

        /* "person": null */
        [JsonProperty("person")]
        public object Person { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase")]
        public object BusinessCase { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /* "convertDate": null */
        [JsonProperty("convertDate")]
        public object ConvertDate { get; set; }

        /* "contactSource": {
  "id": 61,
  "value": "e-mail"
} */
        [JsonProperty("contactSource")]
        public object ContactSource { get; set; }

        /* "category": {
  "id": 91,
  "value": "asd"
} */
        [JsonProperty("category")]
        public object Category { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("titleBefore")]
        public string TitleBefore { get; set; }

        [JsonProperty("titleAfter")]
        public string TitleAfter { get; set; }

        /* "territory": {
  "id": 129,
  "value": "Morava"
} */
        [JsonProperty("territory")]
        public object Territory { get; set; }

        /* "contactInfo": {
  "email": "netece@nepotece.cz",
  "email2": "test@nepotece.cz",
  "tel1": "+420 800 123 123 ",
  "tel1Type": "Mobil",
  "tel2": "+420 123 456 789",
  "tel2Type": "Pevná linka",
  "fax": null,
  "www": null,
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
  "facebook": "kapkafb",
  "googleplus": "kapkagp",
  "twitter": "kapkatw",
  "linkedin": "kapkali",
  "pinterest": "kapkapi",
  "instagram": "kapkain",
  "skype": "kapkask",
  "youtube": "kapkayo"
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

        [JsonProperty("rowInfo.updatedAt")]
        public string RowInfo.updatedAt { get; set; }

        [JsonProperty("rowInfo.updatedBy")]
        public string RowInfo.updatedBy { get; set; }

        /* "rowInfo.rowAccess": null */
        [JsonProperty("rowInfo.rowAccess")]
        public object RowInfo.rowAccess { get; set; }

        [JsonProperty("rowInfo.rowState")]
        public string RowInfo.rowState { get; set; }

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel")]
        public object SecurityLevel { get; set; }

        [JsonProperty("tags")]
        public List<> Tags { get; set; }

        [JsonProperty("notice")]
        public string Notice { get; set; }

        [JsonProperty("regNumber")]
        public string RegNumber { get; set; }

        [JsonProperty("_version")]
        public int _version { get; set; }

        [JsonProperty("attachments")]
        public List<> Attachments { get; set; }

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
