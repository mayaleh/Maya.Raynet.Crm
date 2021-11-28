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
    public class DiscussionTracker : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public DiscussionTracker(string entityName, long entityId, long personId)
        {
                Actions.Add(entityName.ToString());
                Actions.Add(entityId.ToString());
                Actions.Add("watcher");
                Actions.Add(personId.ToString());
        }
        public DiscussionTracker SetRequestData(Model.Request.Put.DiscussionTracker body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.DiscussionTracker>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.DiscussionTracker, Response.Put.DiscussionTracker>(apiClient, this.requestBody);

        private Model.Request.Put.DiscussionTracker requestBody;

    }
}
