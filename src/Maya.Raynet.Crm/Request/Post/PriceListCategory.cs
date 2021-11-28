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
    public class PriceListCategory : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PriceListCategory(long id)
        {
                Actions.Add("priceListCategory");
                Actions.Add(id.ToString());
        }
        public PriceListCategory SetRequestData(Model.Request.Post.PriceListCategory body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.PriceListCategory>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.PriceListCategory, Response.Post.PriceListCategory>(apiClient, this.requestBody);

        private Model.Request.Post.PriceListCategory requestBody;

    }
}
