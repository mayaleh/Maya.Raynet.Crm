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
    public class OfferCategory : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OfferCategory(long id)
        {
                Actions.Add("offerCategory");
                Actions.Add(id.ToString());
        }
        public OfferCategory SetRequestData(Model.Request.Delete.OfferCategory body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.OfferCategory>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.OfferCategory, Response.Delete.OfferCategory>(apiClient, this.requestBody);

        private Model.Request.Delete.OfferCategory requestBody;

    }
}
