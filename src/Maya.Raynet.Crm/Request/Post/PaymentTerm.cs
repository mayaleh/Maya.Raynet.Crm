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
    public class PaymentTerm : PostRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public PaymentTerm(long id)
        {
            Actions.Add("paymentTerm");
            Actions.Add(id.ToString());
        }
        public PaymentTerm SetRequestData(Model.Request.Post.PaymentTerm body)
        {
            this.requestBody = body;
            return this;
        }

        public async Task<Model.EmptyResult> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteEmptyResultAsync(apiClient, this.requestBody);

        private Model.Request.Post.PaymentTerm requestBody;

    }
}
