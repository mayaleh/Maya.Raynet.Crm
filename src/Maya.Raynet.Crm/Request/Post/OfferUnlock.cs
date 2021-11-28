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
    public class OfferUnlock : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public OfferUnlock(long offerId)
        {
                Actions.Add("offer");
                Actions.Add(offerId.ToString());
                Actions.Add("unlock");
        }
        public OfferUnlock SetRequestData(Model.Request.Post.OfferUnlock body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.OfferUnlock>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.OfferUnlock, Response.Post.OfferUnlock>(apiClient, this.requestBody);

        private Model.Request.Post.OfferUnlock requestBody;

    }
}
