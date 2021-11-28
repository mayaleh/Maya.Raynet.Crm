// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Delete
{
    public class OrderItem : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OrderItem(long salesOrderId, long salesOrderItemId)
        {
                Actions.Add("salesOrder");
                Actions.Add(salesOrderId.ToString());
                Actions.Add("item");
                Actions.Add(salesOrderItemId.ToString());
        }
        public OrderItem SetRequestData(Model.Request.Delete.OrderItem body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.OrderItem>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.OrderItem, Response.Delete.OrderItem>(apiClient, this.requestBody);

        private Model.Request.Delete.OrderItem requestBody;

    }
}
