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
    public class Letter : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Letter(long letterId)
        {
                Actions.Add("letter");
                Actions.Add(letterId.ToString());
        }
        public Letter SetRequestData(Model.Request.Delete.Letter body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Letter>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Letter, Response.Delete.Letter>(apiClient, this.requestBody);

        private Model.Request.Delete.Letter requestBody;

    }
}
