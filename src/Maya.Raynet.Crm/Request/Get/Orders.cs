// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Orders : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public Orders()
        {
            Actions.Add("salesOrder");
        }
        public new async Task<Model.DataResult<List<Response.Get.Order>>> ExecuteAsync(ApiClient apiClient)
        {
            return await base.ExecuteAsync<List<Response.Get.Order>>(apiClient);
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

        [RaynetUriParam("code")]
        public string Code { get; set; }

        [RaynetUriParam("name")]
        public string Name { get; set; }

        [RaynetUriParam("company")]
        public long Company { get; set; }

        [RaynetUriParam("person")]
        public long Person { get; set; }

        [RaynetUriParam("businessCase")]
        public long BusinessCase { get; set; }

        [RaynetUriParam("owner")]
        public long Owner { get; set; }

        [RaynetUriParam("expirationDate")]
        public string ExpirationDate { get; set; }

        [RaynetUriParam("requestDeliveryDate")]
        public string RequestDeliveryDate { get; set; }

        [RaynetUriParam("validFrom")]
        public string ValidFrom { get; set; }

        [RaynetUriParam("validTill")]
        public string ValidTill { get; set; }

        [RaynetUriParam("status")]
        public string Status { get; set; }

        [RaynetUriParam("salesOrderStatus")]
        public long SalesOrderStatus { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

        [RaynetUriParam("rowInfo.lastModifiedAt")]
        public string RowInfo_lastModifiedAt { get; set; }

        [RaynetUriParam("rowInfo.rowAccess")]
        public string RowInfo_rowAccess { get; set; }

        [RaynetUriParam("view")]
        public string View { get; set; }

        [RaynetUriParam("tags")]
        public string Tags { get; set; }

    }
}
