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
    public class VATRate : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public VATRate()
        {
                Actions.Add("taxRate");
        }
        public VATRate SetRequestData(Model.Request.Put.VATRate body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.VATRate>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.VATRate, Response.Put.VATRate>(apiClient, this.requestBody);

        private Model.Request.Put.VATRate requestBody;

    }
}
