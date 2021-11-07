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
    public class PriceLists : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PriceLists()
        {
                Actions.Add("priceList");
        }
        public async Task<Model.DataResult<Response.PriceLists>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Response.PriceLists>(apiClient);

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

        [RaynetUriParam("primary")]
        public string Primary { get; set; }

        [RaynetUriParam("currency")]
        public long Currency { get; set; }

        [RaynetUriParam("validFrom")]
        public string ValidFrom { get; set; }

        [RaynetUriParam("validTill")]
        public string ValidTill { get; set; }

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
