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
    public class ProductCategory : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ProductCategory(long id)
        {
                Actions.Add("productCategory");
                Actions.Add(id.ToString());
        }
        public ProductCategory SetRequestData(Model.Request.Post.ProductCategory body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.ProductCategory>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.ProductCategory, Response.Post.ProductCategory>(apiClient, this.requestBody);

        private Model.Request.Post.ProductCategory requestBody;

    }
}
