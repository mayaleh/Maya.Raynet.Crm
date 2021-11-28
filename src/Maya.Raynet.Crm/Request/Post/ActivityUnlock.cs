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
    public class ActivityUnlock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ActivityUnlock(string activityType, long activityId)
        {
                Actions.Add(activityType.ToString());
                Actions.Add(activityId.ToString());
                Actions.Add("unlock");
        }
        public ActivityUnlock SetRequestData(Model.Request.Post.ActivityUnlock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.ActivityUnlock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.ActivityUnlock, Response.Post.ActivityUnlock>(apiClient, this.requestBody);

        private Model.Request.Post.ActivityUnlock requestBody;

    }
}
