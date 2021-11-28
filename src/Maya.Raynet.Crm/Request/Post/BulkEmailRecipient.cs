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
    public class BulkEmailRecipient : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public BulkEmailRecipient(long massEmailId, long recipientId)
        {
                Actions.Add("massEmail");
                Actions.Add(massEmailId.ToString());
                Actions.Add("recipient");
                Actions.Add(recipientId.ToString());
        }
        public BulkEmailRecipient SetRequestData(Model.Request.Post.BulkEmailRecipient body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.BulkEmailRecipient>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.BulkEmailRecipient, Response.Post.BulkEmailRecipient>(apiClient, this.requestBody);

        private Model.Request.Post.BulkEmailRecipient requestBody;

    }
}
