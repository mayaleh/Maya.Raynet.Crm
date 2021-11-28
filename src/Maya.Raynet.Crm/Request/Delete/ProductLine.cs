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
    public class ProductLine : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ProductLine(long id)
        {
                Actions.Add("productLine");
                Actions.Add(id.ToString());
        }
        public ProductLine SetRequestData(Model.Request.Delete.ProductLine body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.ProductLine>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.ProductLine, Response.Delete.ProductLine>(apiClient, this.requestBody);

        private Model.Request.Delete.ProductLine requestBody;

    }
}