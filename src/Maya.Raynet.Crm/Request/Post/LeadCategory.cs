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
    public class LeadCategory : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public LeadCategory(long id)
        {
                Actions.Add("leadCategory");
                Actions.Add(id.ToString());
        }
        public LeadCategory SetRequestData(Model.Request.Post.LeadCategory body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.LeadCategory>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.LeadCategory, Response.Post.LeadCategory>(apiClient, this.requestBody);

        private Model.Request.Post.LeadCategory requestBody;

    }
}
