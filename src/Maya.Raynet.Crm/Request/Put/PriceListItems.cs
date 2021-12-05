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
    public class PriceListItems : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PriceListItems(long priceListId)
        {
                Actions.Add("priceList");
                Actions.Add(priceListId.ToString());
                Actions.Add("item");
        }
        public PriceListItems SetRequestData(Model.Request.Put.PriceListItems body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteNoResultAsync<Model.Request.Put.PriceListItems>(apiClient, this.requestBody);

        private Model.Request.Put.PriceListItems requestBody;

    }
}
