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
    public class Invoice : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Invoice(long invoiceId)
        {
                Actions.Add("invoice");
                Actions.Add(invoiceId.ToString());
        }
        public Invoice SetRequestData(Model.Request.Delete.Invoice body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Invoice>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Invoice, Response.Delete.Invoice>(apiClient, this.requestBody);

        private Model.Request.Delete.Invoice requestBody;

    }
}
