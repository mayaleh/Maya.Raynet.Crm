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
    public class ProductLine : PostRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public ProductLine(long id)
        {
            Actions.Add("productLine");
            Actions.Add(id.ToString());
        }

        public ProductLine SetRequestData(Model.Request.Post.ProductLine body)
        {
            this.requestBody = body;
            return this;
        }

        public async Task<Model.EmptyResult> ExecuteAsync(ApiClient apiClient)
            => await base.ExecuteEmptyResultAsync(apiClient, this.requestBody);

        private Model.Request.Post.ProductLine requestBody;

    }
}
