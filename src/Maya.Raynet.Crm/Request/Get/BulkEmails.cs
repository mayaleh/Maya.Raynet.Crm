// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class BulkEmails : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public BulkEmails()
        {
            Actions.Add("massEmail");
        }
        public new async Task<Model.DataResult<List<Response.Get.BulkEmail>>> ExecuteAsync(ApiClient apiClient)
        {
            return await base.ExecuteAsync<List<Response.Get.BulkEmail>>(apiClient);
        }

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

        [RaynetUriParam("title")]
        public string Title { get; set; }

        [RaynetUriParam("tags")]
        public string Tags { get; set; }

        [RaynetUriParam("completed")]
        public string Completed { get; set; }

        [RaynetUriParam("campaignName")]
        public string CampaignName { get; set; }

        [RaynetUriParam("source")]
        public string Source { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

        [RaynetUriParam("rowInfo.lastModifiedAt")]
        public string RowInfo_lastModifiedAt { get; set; }

        [RaynetUriParam("view")]
        public string View { get; set; }

    }
}
