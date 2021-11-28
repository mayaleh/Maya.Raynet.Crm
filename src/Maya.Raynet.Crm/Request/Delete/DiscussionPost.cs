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
    public class DiscussionPost : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public DiscussionPost(string entityName, long entityId, long postId)
        {
                Actions.Add(entityName.ToString());
                Actions.Add(entityId.ToString());
                Actions.Add("post");
                Actions.Add(postId.ToString());
        }
        public DiscussionPost SetRequestData(Model.Request.Delete.DiscussionPost body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.DiscussionPost>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.DiscussionPost, Response.Delete.DiscussionPost>(apiClient, this.requestBody);

        private Model.Request.Delete.DiscussionPost requestBody;

    }
}
