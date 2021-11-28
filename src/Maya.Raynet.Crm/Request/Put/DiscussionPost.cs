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
    public class DiscussionPost : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public DiscussionPost(string entityName, long entityId)
        {
                Actions.Add(entityName.ToString());
                Actions.Add(entityId.ToString());
                Actions.Add("post");
        }
        public DiscussionPost SetRequestData(Model.Request.Put.DiscussionPost body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.DiscussionPost>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.DiscussionPost, Response.Put.DiscussionPost>(apiClient, this.requestBody);

        private Model.Request.Put.DiscussionPost requestBody;

    }
}