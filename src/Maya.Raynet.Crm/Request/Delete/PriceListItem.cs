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
    public class PriceListItem : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PriceListItem(long priceListId, long priceListItemId)
        {
                Actions.Add("priceList");
                Actions.Add(priceListId.ToString());
                Actions.Add("item");
                Actions.Add(priceListItemId.ToString());
        }
        public new async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync(apiClient);

    }
}
