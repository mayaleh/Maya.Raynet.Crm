// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Lead
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("leadDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? LeadDate { get; set; }

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
        public LeadPhase LeadPhase { get; set; }

        /* "owner": {
  "id": 1,
  "fullName": "RAYNET CRM"
} */
        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Owner Owner { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        [JsonProperty("companyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CompanyName { get; set; }

        /* "company": {
  "id": 1093,
  "name": "Neteče a nepoteče s.r.o"
} */
        [JsonProperty("company", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Company Company { get; set; }

        /* "person": null */
        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Person Person { get; set; }

        /* "businessCase": null */
        [JsonProperty("businessCase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public BusinessCase BusinessCase { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        /* "convertDate": null */
        [JsonProperty("convertDate", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTimeOffset? ConvertDate { get; set; }

        /* "contactSource": {
  "id": 61,
  "value": "e-mail"
} */
        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue ContactSource { get; set; }

        /* "category": {
  "id": 91,
  "value": "asd"
} */
        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Category { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleBefore { get; set; }

        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleAfter { get; set; }

        /* "territory": {
  "id": 129,
  "value": "Morava"
} */
        [JsonProperty("territory", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Territory { get; set; }

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
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ContactInfo ContactInfo { get; set; }

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
        public Address Address { get; set; }

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
        [JsonProperty("socialNetworkContact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SocialNetwork SocialNetworkContact { get; set; }

        /* "customFields": null */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Dictionary<string, object> CustomFields { get; set; }

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

        [JsonProperty("rowInfo.rowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_rowState { get; set; }

        /* "securityLevel": {
  "id": 1,
  "name": "Sdílená"
} */
        [JsonProperty("securityLevel", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SecurityLevel SecurityLevel { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegNumber { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int _version { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

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
        public List<InlineGdpr> InlineGdpr { get; set; }

    }
}
