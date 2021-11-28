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
    public class NumberDecimalPlacesChange : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public NumberDecimalPlacesChange(long invoiceId)
        {
                Actions.Add("invoice");
                Actions.Add(invoiceId.ToString());
                Actions.Add("changeDecimalPrecision");
        }
        public NumberDecimalPlacesChange SetRequestData(Model.Request.Post.NumberDecimalPlacesChange body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.NumberDecimalPlacesChange>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.NumberDecimalPlacesChange, Response.Post.NumberDecimalPlacesChange>(apiClient, this.requestBody);

        private Model.Request.Post.NumberDecimalPlacesChange requestBody;

    }
}
