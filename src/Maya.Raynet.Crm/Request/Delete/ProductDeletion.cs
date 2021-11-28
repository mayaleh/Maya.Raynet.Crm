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
    public class ProductDeletion : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ProductDeletion(long productId)
        {
                Actions.Add("product");
                Actions.Add(productId.ToString());
        }
        public ProductDeletion SetRequestData(Model.Request.Delete.ProductDeletion body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.ProductDeletion>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.ProductDeletion, Response.Delete.ProductDeletion>(apiClient, this.requestBody);

        private Model.Request.Delete.ProductDeletion requestBody;

    }
}
