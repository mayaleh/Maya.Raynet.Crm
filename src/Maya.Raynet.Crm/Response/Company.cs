// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Maya.Raynet.Crm.Response
{
    public class Company
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("person", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Person { get; set; }

        [JsonProperty("firstName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("lastName", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("titleBefore", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleBefore { get; set; }

        [JsonProperty("titleAfter", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TitleAfter { get; set; }

        [JsonProperty("salutation", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Salutation { get; set; }

        [JsonProperty("owner", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Owner Owner { get; set; }

        [JsonProperty("rating", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Rating { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }

        [JsonProperty("role", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Role { get; set; }

        [JsonProperty("notice", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Notice { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Category { get; set; }

        [JsonProperty("contactSource", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue ContactSource { get; set; }

        [JsonProperty("employeesNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue EmployeesNumber { get; set; }

        [JsonProperty("legalForm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue LegalForm { get; set; }

        [JsonProperty("paymentTerm", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue PaymentTerm { get; set; }

        [JsonProperty("turnover", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue Turnover { get; set; }

        [JsonProperty("economyActivity", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue EconomyActivity { get; set; }

        [JsonProperty("companyClassification1", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue CompanyClassification1 { get; set; }

        [JsonProperty("companyClassification2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue CompanyClassification2 { get; set; }

        [JsonProperty("companyClassification3", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IdValue CompanyClassification3 { get; set; }

        [JsonProperty("regNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RegNumber { get; set; }

        [JsonProperty("taxNumber", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxNumber { get; set; }

        [JsonProperty("taxNumber2", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxNumber2 { get; set; }

        [JsonProperty("taxPayer", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TaxPayer { get; set; }

        [JsonProperty("bankAccount", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BankAccount { get; set; }

        [JsonProperty("birthday", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public DateTime? Birthday { get; set; }

        [JsonProperty("primaryAddress", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ComapnyAddress PrimaryAddress { get; set; }

        [JsonProperty("tags", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<string> Tags { get; set; }

        [JsonProperty("logo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public FileInfo Logo { get; set; }

        [JsonProperty("socialNetworkContact", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public SocialNetwork SocialNetworkContact { get; set; }

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

        [JsonProperty("rowInfo.rowAccess", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_rowAccess { get; set; }

        [JsonProperty("rowInfo.rowState", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string RowInfo_rowState { get; set; }

        [JsonProperty("_version", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? _version { get; set; }

        [JsonProperty("attachments", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<Attachment> Attachments { get; set; }

        [JsonProperty("addresses", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<ComapnyAddress> Addresses { get; set; }

        [JsonProperty("inlineGdpr", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<InlineGdpr> InlineGdpr { get; set; }

        [JsonProperty("originLead", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Lead OriginLead { get; set; }
    }
}
