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
    public class ModifyTheConnectionToAnotherClient : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ModifyTheConnectionToAnotherClient(long companyId, long relationshipId)
        {
                Actions.Add("company");
                Actions.Add(companyId.ToString());
                Actions.Add("relationship");
                Actions.Add(relationshipId.ToString());
        }
        public ModifyTheConnectionToAnotherClient SetRequestData(Model.Request.Post.ModifyTheConnectionToAnotherClient body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.ModifyTheConnectionToAnotherClient>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.ModifyTheConnectionToAnotherClient, Response.Post.ModifyTheConnectionToAnotherClient>(apiClient, this.requestBody);

        private Model.Request.Post.ModifyTheConnectionToAnotherClient requestBody;

    }
}
