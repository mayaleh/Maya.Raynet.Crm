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
    public class Phones : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Phones()
        {
                Actions.Add("phonecall");
        }
        public async Task<Model.DataResult<List<Response.Phone>>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<List<Response.Phone>>(apiClient);

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

        [RaynetUriParam("id")]
        public long Id { get; set; }

        [RaynetUriParam("title")]
        public string Title { get; set; }

        [RaynetUriParam("scheduledFrom")]
        public string ScheduledFrom { get; set; }

        [RaynetUriParam("scheduledTill")]
        public string ScheduledTill { get; set; }

        [RaynetUriParam("completed")]
        public string Completed { get; set; }

        [RaynetUriParam("category-id")]
        public long Category_id { get; set; }

        [RaynetUriParam("status")]
        public string Status { get; set; }

        [RaynetUriParam("owner-id")]
        public long Owner_id { get; set; }

        [RaynetUriParam("personFilter")]
        public long PersonFilter { get; set; }

        [RaynetUriParam("companyContextFilter")]
        public long CompanyContextFilter { get; set; }

        [RaynetUriParam("leadContextFilter")]
        public long LeadContextFilter { get; set; }

        [RaynetUriParam("businessCase")]
        public long BusinessCase { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

        [RaynetUriParam("rowInfo.lastModifiedAt")]
        public string RowInfo_lastModifiedAt { get; set; }

        [RaynetUriParam("view")]
        public string View { get; set; }

        [RaynetUriParam("tags")]
        public string Tags { get; set; }

    }
}
