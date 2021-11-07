// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:32:47 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Email : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Email(long emailId)
        {
                Actions.Add("email");
                Actions.Add(emailId.ToString());
        }
        public async Task<Model.DataResult<Response.Email>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Response.Email>(apiClient);

    }
}