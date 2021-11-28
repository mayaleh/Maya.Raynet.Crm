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
    public class OrderLock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OrderLock(long salesOrderId)
        {
                Actions.Add("salesOrder");
                Actions.Add(salesOrderId.ToString());
                Actions.Add("lock");
        }
        public OrderLock SetRequestData(Model.Request.Post.OrderLock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.OrderLock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.OrderLock, Response.Post.OrderLock>(apiClient, this.requestBody);

        private Model.Request.Post.OrderLock requestBody;

    }
}
