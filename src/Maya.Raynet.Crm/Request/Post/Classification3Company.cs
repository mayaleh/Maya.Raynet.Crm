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
    public class Classification3Company : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification3Company(long id)
        {
                Actions.Add("companyClassification3");
                Actions.Add(id.ToString());
        }
        public Classification3Company SetRequestData(Model.Request.Post.Classification3Company body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.Classification3Company>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.Classification3Company, Response.Post.Classification3Company>(apiClient, this.requestBody);

        private Model.Request.Post.Classification3Company requestBody;

    }
}
