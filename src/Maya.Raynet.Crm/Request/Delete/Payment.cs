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
    public class Payment : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Payment(long invoiceId, long paymentId)
        {
                Actions.Add("invoice");
                Actions.Add(invoiceId.ToString());
                Actions.Add("payment");
                Actions.Add(paymentId.ToString());
        }
        public Payment SetRequestData(Model.Request.Delete.Payment body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Payment>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Payment, Response.Delete.Payment>(apiClient, this.requestBody);

        private Model.Request.Delete.Payment requestBody;

    }
}
