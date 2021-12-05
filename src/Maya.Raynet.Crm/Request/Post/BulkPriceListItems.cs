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
    /// <summary>
    /// hromadné pøidání/upravení položek ceníku
    /// Hromadné pøidání/upravení položek na ceník. API je omezeno na 100 souèasnì vkládaných položek.
    /// https://app.raynet.cz/api/v2/priceList/1/itemBulkInsert/
    /// </summary>
    public class BulkPriceListItems : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public BulkPriceListItems(long priceListId)
        {
                Actions.Add("priceList");
                Actions.Add(priceListId.ToString());
                Actions.Add("itemBulkUpsert");
        }
        public BulkPriceListItems SetRequestData(IEnumerable<Model.Request.Post.BulkPriceListItem> body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<IEnumerable<Response.Post.BulkPriceListItem>>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<IEnumerable<Model.Request.Post.BulkPriceListItem>, IEnumerable<Response.Post.BulkPriceListItem>>(apiClient, this.requestBody);

        private IEnumerable<Model.Request.Post.BulkPriceListItem> requestBody;

    }
}
