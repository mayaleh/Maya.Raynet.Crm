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
    public class MergeDuplicateLead : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public MergeDuplicateLead(long leadId, long sourceLeadId)
        {
                Actions.Add("lead");
                Actions.Add(leadId.ToString());
                Actions.Add("merge");
                Actions.Add(sourceLeadId.ToString());
        }
        public MergeDuplicateLead SetRequestData(Model.Request.Post.MergeDuplicateLead body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.MergeDuplicateLead>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.MergeDuplicateLead, Response.Post.MergeDuplicateLead>(apiClient, this.requestBody);

        private Model.Request.Post.MergeDuplicateLead requestBody;

    }
}
