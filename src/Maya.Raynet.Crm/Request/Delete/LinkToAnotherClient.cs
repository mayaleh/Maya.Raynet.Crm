// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Delete
{
    public class LinkToAnotherClient : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public LinkToAnotherClient(long companyId, long relationshipId)
        {
                Actions.Add("company");
                Actions.Add(companyId.ToString());
                Actions.Add("relationship");
                Actions.Add(relationshipId.ToString());
        }
        public LinkToAnotherClient SetRequestData(Model.Request.Delete.LinkToAnotherClient body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.LinkToAnotherClient>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.LinkToAnotherClient, Response.Delete.LinkToAnotherClient>(apiClient, this.requestBody);

        private Model.Request.Delete.LinkToAnotherClient requestBody;

    }
}
