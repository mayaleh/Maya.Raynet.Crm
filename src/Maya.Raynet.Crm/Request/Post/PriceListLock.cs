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
    public class PriceListLock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PriceListLock(long priceListId)
        {
                Actions.Add("priceList");
                Actions.Add(priceListId.ToString());
                Actions.Add("lock");
        }
        public PriceListLock SetRequestData(Model.Request.Post.PriceListLock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.PriceListLock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.PriceListLock, Response.Post.PriceListLock>(apiClient, this.requestBody);

        private Model.Request.Post.PriceListLock requestBody;

    }
}
