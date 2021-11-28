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
    public class Classification1BusinessCase : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification1BusinessCase()
        {
                Actions.Add("businessCaseClassification1");
        }
        public Classification1BusinessCase SetRequestData(Model.Request.Put.Classification1BusinessCase body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.IdResult>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.Classification1BusinessCase, Response.Put.IdResult>(apiClient, this.requestBody);

        private Model.Request.Put.Classification1BusinessCase requestBody;

    }
}
