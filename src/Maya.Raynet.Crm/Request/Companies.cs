// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Companies : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Companies()
        {
                Actions.Add("company");
        }
        public async Task<Model.DataResult<List<Response.Companies>>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<List<Response.Companies>>(apiClient);

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

        [RaynetUriParam("name")]
        public string Name { get; set; }

        [RaynetUriParam("lastName")]
        public string LastName { get; set; }

        [RaynetUriParam("person")]
        public bool Person { get; set; }

        [RaynetUriParam("regNumber")]
        public string RegNumber { get; set; }

        [RaynetUriParam("owner")]
        public long Owner { get; set; }

        [RaynetUriParam("rating")]
        public string Rating { get; set; }

        [RaynetUriParam("role")]
        public string Role { get; set; }

        [RaynetUriParam("state")]
        public string State { get; set; }

        [RaynetUriParam("category")]
        public long Category { get; set; }

        [RaynetUriParam("economyActivity")]
        public long EconomyActivity { get; set; }

        [RaynetUriParam("companyClassification1")]
        public long CompanyClassification1 { get; set; }

        [RaynetUriParam("companyClassification2")]
        public long CompanyClassification2 { get; set; }

        [RaynetUriParam("companyClassification3")]
        public long CompanyClassification3 { get; set; }

        [RaynetUriParam("primaryAddress-contactInfo.email")]
        public string PrimaryAddress_contactInfo_email { get; set; }

        [RaynetUriParam("primaryAddress-contactInfo.email2")]
        public string PrimaryAddress_contactInfo_email2 { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

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
