// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Webhooks : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public Webhooks()
        {
            Actions.Add("webhook");
        }
        public new async Task<Model.DataResult<List<Response.Get.WebhookList>>> ExecuteAsync(ApiClient apiClient)
        {
            return await base.ExecuteAsync<List<Response.Get.WebhookList>>(apiClient);
        }
    }
}
