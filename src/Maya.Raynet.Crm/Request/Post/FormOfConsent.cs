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
    public class FormOfConsent : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public FormOfConsent(long id)
        {
                Actions.Add("gdprFormAgreement");
                Actions.Add(id.ToString());
        }
        public FormOfConsent SetRequestData(Model.Request.Post.FormOfConsent body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.FormOfConsent>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.FormOfConsent, Response.Post.FormOfConsent>(apiClient, this.requestBody);

        private Model.Request.Post.FormOfConsent requestBody;

    }
}
