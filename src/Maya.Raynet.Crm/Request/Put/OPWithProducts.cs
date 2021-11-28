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
    public class OPWithProducts : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OPWithProducts()
        {
                Actions.Add("businessCase");
                Actions.Add("createWithItems");
        }
        public OPWithProducts SetRequestData(Model.Request.Put.OPWithProducts body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Put.OPWithProducts>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.OPWithProducts, Response.Put.OPWithProducts>(apiClient, this.requestBody);

        private Model.Request.Put.OPWithProducts requestBody;

    }
}
