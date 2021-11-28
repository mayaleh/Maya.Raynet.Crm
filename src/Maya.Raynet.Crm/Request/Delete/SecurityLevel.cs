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
    public class SecurityLevel : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public SecurityLevel(long securityLevelId)
        {
                Actions.Add("securityLevel");
                Actions.Add(securityLevelId.ToString());
        }
        public SecurityLevel SetRequestData(Model.Request.Delete.SecurityLevel body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.SecurityLevel>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.SecurityLevel, Response.Delete.SecurityLevel>(apiClient, this.requestBody);

        private Model.Request.Delete.SecurityLevel requestBody;

    }
}
