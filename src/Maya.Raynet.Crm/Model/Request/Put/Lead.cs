// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 14:05:29 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model.Request.Put
{
    public class Lead
    {
        [JsonProperty("topic", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Topic { get; set; }

        [JsonProperty("priority", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Priority { get; set; }

        [JsonProperty("companyName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CompanyName { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Owner { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Category { get; set; }

        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ContactSource { get; set; }

        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegNumber { get; set; }

        [JsonProperty("leadPhase", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int LeadPhase { get; set; }

        /* "contactInfo": {
  "email": "metece@nepotece.cz",
  "email2": "test@nepotece.cz",
  "tel1": "+420 800 123 123 ",
  "tel1Type": "Mobil",
  "tel2": "+420 123 456 789",
  "tel2Type": "Pevná linka",
  "www": "nepotece.cz",
  "fax": "+420 123 123 123",
  "otherContact": "Pobočka XY"
} */
        [JsonProperty("contactInfo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ContactInfo { get; set; }

        /* "address": {
  "street": "Hlavní ulice",
  "city": "Velká Lhota",
  "province": "Jihomoravký kraj",
  "zipCode": "123 00",
  "country": "CZ",
  "lat": null,
  "lng": null
} */
        [JsonProperty("address", DefaultValueHandling = DefaultValueHandling.Ignore)]
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
        [JsonProperty("socialNetworkContact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object SocialNetworkContact { get; set; }

        /* "customFields": {
  "VIP_b91d1": false
} */
        [JsonProperty("customFields", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object CustomFields { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Tags { get; set; }

        [JsonProperty("notificationMessage", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NotificationMessage { get; set; }

        [JsonProperty("notificationEmailAddresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> NotificationEmailAddresses { get; set; }

    }
}
