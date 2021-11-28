// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Put
{
    public class ExternalIdentifier : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ExternalIdentifier(string entityName, long entityId)
        {
                Actions.Add(entityName.ToString());
                Actions.Add(entityId.ToString());
                Actions.Add("extId");
        }
        public ExternalIdentifier SetRequestData(Model.Request.Put.ExternalIdentifier body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.ExternalIdentifier>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.ExternalIdentifier, Response.Put.ExternalIdentifier>(apiClient, this.requestBody);

        private Model.Request.Put.ExternalIdentifier requestBody;

    }
}
