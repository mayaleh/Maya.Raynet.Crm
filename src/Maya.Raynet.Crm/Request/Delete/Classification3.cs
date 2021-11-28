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
    public class Classification3 : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification3(long id)
        {
                Actions.Add("businessCaseClassification3");
                Actions.Add(id.ToString());
        }
        public Classification3 SetRequestData(Model.Request.Delete.Classification3 body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Classification3>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Classification3, Response.Delete.Classification3>(apiClient, this.requestBody);

        private Model.Request.Delete.Classification3 requestBody;

    }
}
