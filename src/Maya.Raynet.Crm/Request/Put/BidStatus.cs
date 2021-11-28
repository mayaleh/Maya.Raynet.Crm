// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Put
{
    public class BidStatus : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public BidStatus()
        {
                Actions.Add("offerStatus");
        }
        public BidStatus SetRequestData(Model.Request.Put.BidStatus body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<int>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.BidStatus, int>(apiClient, this.requestBody);

        private Model.Request.Put.BidStatus requestBody;

    }
}
