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
    public class Classification3Company : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification3Company()
        {
                Actions.Add("companyClassification3");
        }
        public Classification3Company SetRequestData(Model.Request.Put.Classification3Company body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.Classification3Company>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.Classification3Company, Response.Put.Classification3Company>(apiClient, this.requestBody);

        private Model.Request.Put.Classification3Company requestBody;

    }
}
