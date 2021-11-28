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
    public class Classification2PerPerson : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification2PerPerson(long id)
        {
                Actions.Add("personClassification2");
                Actions.Add(id.ToString());
        }
        public Classification2PerPerson SetRequestData(Model.Request.Post.Classification2PerPerson body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.Classification2PerPerson>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.Classification2PerPerson, Response.Post.Classification2PerPerson>(apiClient, this.requestBody);

        private Model.Request.Post.Classification2PerPerson requestBody;

    }
}
