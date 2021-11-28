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
    public class CompanyCategory : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public CompanyCategory(long id)
        {
                Actions.Add("companyCategory");
                Actions.Add(id.ToString());
        }
        public CompanyCategory SetRequestData(Model.Request.Post.CompanyCategory body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.CompanyCategory>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.CompanyCategory, Response.Post.CompanyCategory>(apiClient, this.requestBody);

        private Model.Request.Post.CompanyCategory requestBody;

    }
}
