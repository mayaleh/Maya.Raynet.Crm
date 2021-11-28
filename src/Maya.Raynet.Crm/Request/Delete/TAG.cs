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
    public class TAG : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public TAG(long personId)
        {
                Actions.Add("person");
                Actions.Add(personId.ToString());
                Actions.Add("tag");
        }
        public TAG SetRequestData(Model.Request.Delete.TAG body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.TAG>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.TAG, Response.Delete.TAG>(apiClient, this.requestBody);

        private Model.Request.Delete.TAG requestBody;

    }
}