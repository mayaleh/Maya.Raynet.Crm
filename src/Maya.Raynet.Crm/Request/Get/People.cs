// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:32:47 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class People : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public People()
        {
                Actions.Add("person");
        }
        public async Task<Model.DataResult<Response.People>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Response.People>(apiClient);

        [RaynetUriParam("offset")]
        public int Offset { get; set; }

        [RaynetUriParam("limit")]
        public int Limit { get; set; }

        [RaynetUriParam("sortColumn")]
        public string SortColumn { get; set; }

        [RaynetUriParam("sortDirection")]
        public string SortDirection { get; set; }

        [RaynetUriParam("fulltext")]
        public string Fulltext { get; set; }

        [RaynetUriParam("firstName")]
        public string FirstName { get; set; }

        [RaynetUriParam("lastName")]
        public string LastName { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

        [RaynetUriParam("owner")]
        public long Owner { get; set; }

        [RaynetUriParam("primaryRelationship-company-name")]
        public string PrimaryRelationship_company_name { get; set; }

        [RaynetUriParam("primaryRelationship-company-id")]
        public long PrimaryRelationship_company_id { get; set; }

        [RaynetUriParam("personRelationship")]
        public long PersonRelationship { get; set; }

        [RaynetUriParam("userAccount-id")]
        public long UserAccount_id { get; set; }

        [RaynetUriParam("contactInfo.email")]
        public string ContactInfo_email { get; set; }

        [RaynetUriParam("contactInfo.email2")]
        public string ContactInfo_email2 { get; set; }

        [RaynetUriParam("rowInfo.lastModifiedAt")]
        public string RowInfo_lastModifiedAt { get; set; }

        [RaynetUriParam("rowInfo.rowAccess")]
        public string RowInfo_rowAccess { get; set; }

        [RaynetUriParam("gdprTemplate")]
        public string GdprTemplate { get; set; }

        [RaynetUriParam("withoutGdpr")]
        public string WithoutGdpr { get; set; }

        [RaynetUriParam("view")]
        public string View { get; set; }

        [RaynetUriParam("tags")]
        public string Tags { get; set; }

    }
}
