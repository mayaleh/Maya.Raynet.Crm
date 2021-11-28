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
    public class PersonCategory : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PersonCategory(long id)
        {
                Actions.Add("personCategory");
                Actions.Add(id.ToString());
        }
        public PersonCategory SetRequestData(Model.Request.Post.PersonCategory body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.PersonCategory>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.PersonCategory, Response.Post.PersonCategory>(apiClient, this.requestBody);

        private Model.Request.Post.PersonCategory requestBody;

    }
}