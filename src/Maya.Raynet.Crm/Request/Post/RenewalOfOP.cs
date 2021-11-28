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
    public class RenewalOfOP : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public RenewalOfOP(long businessCaseId)
        {
                Actions.Add("businessCase");
                Actions.Add(businessCaseId.ToString());
                Actions.Add("valid");
        }
        public RenewalOfOP SetRequestData(Model.Request.Post.RenewalOfOP body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.RenewalOfOP>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.RenewalOfOP, Response.Post.RenewalOfOP>(apiClient, this.requestBody);

        private Model.Request.Post.RenewalOfOP requestBody;

    }
}
