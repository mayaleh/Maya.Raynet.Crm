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
    public class LegalTitle : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public LegalTitle(long gdprId)
        {
                Actions.Add("gdpr");
                Actions.Add(gdprId.ToString());
        }
        public LegalTitle SetRequestData(Model.Request.Post.LegalTitle body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.LegalTitle>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.LegalTitle, Response.Post.LegalTitle>(apiClient, this.requestBody);

        private Model.Request.Post.LegalTitle requestBody;

    }
}
