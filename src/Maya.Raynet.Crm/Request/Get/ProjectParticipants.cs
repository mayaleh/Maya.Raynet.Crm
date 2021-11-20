// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class ProjectParticipants : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public ProjectParticipants()
        {
            Actions.Add("project");
            Actions.Add("participants");
        }
        public new async Task<Model.DataResult<List<Response.Get.ProjectParticipant>>> ExecuteAsync(ApiClient apiClient)
        {
            return await base.ExecuteAsync<List<Response.Get.ProjectParticipant>>(apiClient);
        }

        [RaynetUriParam("offset")]
        public int Offset { get; set; }

        [RaynetUriParam("limit")]
        public int Limit { get; set; }

        [RaynetUriParam("sortColumn")]
        public string SortColumn { get; set; }

        [RaynetUriParam("sortDirection")]
        public string SortDirection { get; set; }

        [RaynetUriParam("note")]
        public string Note { get; set; }

        [RaynetUriParam("company")]
        public string Company { get; set; }

        [RaynetUriParam("company-name")]
        public long Company_name { get; set; }

        [RaynetUriParam("person")]
        public string Person { get; set; }

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
