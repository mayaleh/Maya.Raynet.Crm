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
    public class DocumentLock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public DocumentLock(long documentId)
        {
                Actions.Add("dms");
                Actions.Add("document");
                Actions.Add(documentId.ToString());
                Actions.Add("lock");
        }
        public DocumentLock SetRequestData(Model.Request.Post.DocumentLock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.DocumentLock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.DocumentLock, Response.Post.DocumentLock>(apiClient, this.requestBody);

        private Model.Request.Post.DocumentLock requestBody;

    }
}