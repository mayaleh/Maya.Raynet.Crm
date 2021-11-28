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
    public class PrimaryAddressSetting : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PrimaryAddressSetting(long companyId, long addressId)
        {
                Actions.Add("company");
                Actions.Add(companyId.ToString());
                Actions.Add("address");
                Actions.Add(addressId.ToString());
                Actions.Add("setPrimary");
        }
        public PrimaryAddressSetting SetRequestData(Model.Request.Post.PrimaryAddressSetting body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.PrimaryAddressSetting>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.PrimaryAddressSetting, Response.Post.PrimaryAddressSetting>(apiClient, this.requestBody);

        private Model.Request.Post.PrimaryAddressSetting requestBody;

    }
}
