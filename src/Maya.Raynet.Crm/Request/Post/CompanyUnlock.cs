// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Post
{
    public class CompanyUnlock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public CompanyUnlock(long companyId)
        {
                Actions.Add("company");
                Actions.Add(companyId.ToString());
                Actions.Add("unlock");
        }
        public CompanyUnlock SetRequestData(Model.Request.Post.CompanyUnlock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.CompanyUnlock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.CompanyUnlock, Response.Post.CompanyUnlock>(apiClient, this.requestBody);

        private Model.Request.Post.CompanyUnlock requestBody;

    }
}
