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
    public class Classification1 : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification1(long id)
        {
                Actions.Add("businessCaseClassification1");
                Actions.Add(id.ToString());
        }
        public Classification1 SetRequestData(Model.Request.Delete.Classification1 body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Classification1>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Classification1, Response.Delete.Classification1>(apiClient, this.requestBody);

        private Model.Request.Delete.Classification1 requestBody;

    }
}
