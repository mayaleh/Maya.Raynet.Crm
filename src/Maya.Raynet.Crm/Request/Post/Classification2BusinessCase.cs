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
    public class Classification2BusinessCase : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification2BusinessCase(long id)
        {
                Actions.Add("businessCaseClassification2");
                Actions.Add(id.ToString());
        }
        public Classification2BusinessCase SetRequestData(Model.Request.Post.Classification2BusinessCase body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.Classification2BusinessCase>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.Classification2BusinessCase, Response.Post.Classification2BusinessCase>(apiClient, this.requestBody);

        private Model.Request.Post.Classification2BusinessCase requestBody;

    }
}
