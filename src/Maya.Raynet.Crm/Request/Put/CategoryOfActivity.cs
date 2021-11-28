// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Put
{
    public class CategoryOfActivity : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public CategoryOfActivity()
        {
                Actions.Add("activityCategory");
        }
        public CategoryOfActivity SetRequestData(Model.Request.Put.CategoryOfActivity body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<int>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.CategoryOfActivity, int>(apiClient, this.requestBody);

        private Model.Request.Put.CategoryOfActivity requestBody;

    }
}