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
    public class MenuItem : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public MenuItem(long offerId, long offerItemId)
        {
                Actions.Add("offer");
                Actions.Add(offerId.ToString());
                Actions.Add("item");
                Actions.Add(offerItemId.ToString());
        }
        public MenuItem SetRequestData(Model.Request.Delete.MenuItem body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.MenuItem>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.MenuItem, Response.Delete.MenuItem>(apiClient, this.requestBody);

        private Model.Request.Delete.MenuItem requestBody;

    }
}
