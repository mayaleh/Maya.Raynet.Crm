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
    public class PersonUnlock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PersonUnlock(long personId)
        {
                Actions.Add("person");
                Actions.Add(personId.ToString());
                Actions.Add("unlock");
        }
        public PersonUnlock SetRequestData(Model.Request.Post.PersonUnlock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.PersonUnlock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.PersonUnlock, Response.Post.PersonUnlock>(apiClient, this.requestBody);

        private Model.Request.Post.PersonUnlock requestBody;

    }
}
