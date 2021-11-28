// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Post
{
    public class OrderCancellation : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OrderCancellation(long salesOrderId)
        {
                Actions.Add("salesOrder");
                Actions.Add(salesOrderId.ToString());
                Actions.Add("invalid");
        }
        public OrderCancellation SetRequestData(Model.Request.Post.OrderCancellation body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.OrderCancellation>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.OrderCancellation, Response.Post.OrderCancellation>(apiClient, this.requestBody);

        private Model.Request.Post.OrderCancellation requestBody;

    }
}
