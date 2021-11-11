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
    public class PhoneTypes : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public PhoneTypes()
        {
                Actions.Add("telType");
        }
        public async Task<Model.DataResult<List<Response.PhoneTypes>>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<List<Response.PhoneTypes>>(apiClient);

    }
}