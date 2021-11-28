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
    public class OPItems : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OPItems(long businessCaseId)
        {
                Actions.Add("businessCase");
                Actions.Add(businessCaseId.ToString());
                Actions.Add("item");
        }
        public OPItems SetRequestData(Model.Request.Put.OPItems body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.OPItems>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.OPItems, Response.Put.OPItems>(apiClient, this.requestBody);

        private Model.Request.Put.OPItems requestBody;

    }
}
