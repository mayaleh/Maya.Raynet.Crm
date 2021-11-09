// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class User : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public User(long userAccountId)
        {
                Actions.Add("userAccount");
                Actions.Add(userAccountId.ToString());
        }
        public async Task<Model.DataResult<Response.User>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Response.User>(apiClient);

    }
}
