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
    public class Leads : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Leads()
        {
                Actions.Add("lead");
        }
        public new async Task<Model.DataResult<List<Response.Lead>>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<List<Response.Lead>>(apiClient);

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

        [RaynetUriParam("code")]
        public string Code { get; set; }

        [RaynetUriParam("companyName")]
        public string CompanyName { get; set; }

        [RaynetUriParam("lastName")]
        public string LastName { get; set; }

        [RaynetUriParam("contactInfo.email")]
        public string ContactInfo_email { get; set; }

        [RaynetUriParam("contactInfo.email2")]
        public string ContactInfo_email2 { get; set; }

        [RaynetUriParam("regNumber")]
        public string RegNumber { get; set; }

        [RaynetUriParam("owner")]
        public long Owner { get; set; }

        [RaynetUriParam("leadDate")]
        public string LeadDate { get; set; }

        [RaynetUriParam("status")]
        public string Status { get; set; }

        [RaynetUriParam("leadPhase")]
        public long LeadPhase { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

        [RaynetUriParam("rowInfo.lastModifiedAt")]
        public string RowInfo_lastModifiedAt { get; set; }

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
