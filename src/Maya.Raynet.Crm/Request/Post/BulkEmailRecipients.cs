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
    public class BulkEmailRecipients : PostRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public BulkEmailRecipients(long massEmailId)
        {
            Actions.Add("massEmail");
            Actions.Add(massEmailId.ToString());
            Actions.Add("recipientBulkDelete");
        }
        public BulkEmailRecipients SetRequestData(List<string> body)
        {
            this.requestBody = body;
            return this;
        }

        public async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteNoResultAsync(apiClient, this.requestBody);

        private List<string> requestBody;

    }
}
