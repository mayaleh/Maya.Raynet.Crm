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
    public class OPItem : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OPItem(long businessCaseId, long businessCaseItemId)
        {
                Actions.Add("businessCase");
                Actions.Add(businessCaseId.ToString());
                Actions.Add("item");
                Actions.Add(businessCaseItemId.ToString());
        }
        public OPItem SetRequestData(Model.Request.Delete.OPItem body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.OPItem>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.OPItem, Response.Delete.OPItem>(apiClient, this.requestBody);

        private Model.Request.Delete.OPItem requestBody;

    }
}
