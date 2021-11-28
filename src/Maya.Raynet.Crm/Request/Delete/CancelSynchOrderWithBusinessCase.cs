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
    public class CancelSynchOrderWithBusinessCase : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public CancelSynchOrderWithBusinessCase(long salesOrderId)
        {
                Actions.Add("salesOrder");
                Actions.Add(salesOrderId.ToString());
                Actions.Add("sync");
        }
        public CancelSynchOrderWithBusinessCase SetRequestData(Model.Request.Delete.CancelSynchOrderWithBusinessCase body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.CancelSynchOrderWithBusinessCase>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.CancelSynchOrderWithBusinessCase, Response.Delete.CancelSynchOrderWithBusinessCase>(apiClient, this.requestBody);

        private Model.Request.Delete.CancelSynchOrderWithBusinessCase requestBody;

    }
}