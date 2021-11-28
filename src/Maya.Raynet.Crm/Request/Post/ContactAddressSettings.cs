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
    public class ContactAddressSettings : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ContactAddressSettings(long companyId, long addressId)
        {
                Actions.Add("company");
                Actions.Add(companyId.ToString());
                Actions.Add("address");
                Actions.Add(addressId.ToString());
                Actions.Add("setContact");
        }
        public ContactAddressSettings SetRequestData(Model.Request.Post.ContactAddressSettings body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.ContactAddressSettings>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.ContactAddressSettings, Response.Post.ContactAddressSettings>(apiClient, this.requestBody);

        private Model.Request.Post.ContactAddressSettings requestBody;

    }
}