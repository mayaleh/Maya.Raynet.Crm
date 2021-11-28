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
    public class BulkPriceListItems : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public BulkPriceListItems(long priceListId)
        {
                Actions.Add("priceList");
                Actions.Add(priceListId.ToString());
                Actions.Add("itemBulkUpsert");
        }
        public BulkPriceListItems SetRequestData(Model.Request.Post.BulkPriceListItems body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.BulkPriceListItems>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.BulkPriceListItems, Response.Post.BulkPriceListItems>(apiClient, this.requestBody);

        private Model.Request.Post.BulkPriceListItems requestBody;

    }
}
