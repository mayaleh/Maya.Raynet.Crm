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
    public class Classification2 : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Classification2(long id)
        {
                Actions.Add("businessCaseClassification2");
                Actions.Add(id.ToString());
        }
        public Classification2 SetRequestData(Model.Request.Delete.Classification2 body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Classification2>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Classification2, Response.Delete.Classification2>(apiClient, this.requestBody);

        private Model.Request.Delete.Classification2 requestBody;

    }
}
