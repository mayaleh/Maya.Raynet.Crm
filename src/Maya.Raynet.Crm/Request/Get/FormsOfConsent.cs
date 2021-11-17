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
    public class FormsOfConsent : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public FormsOfConsent()
        {
                Actions.Add("gdprFormAgreement");
        }
        public new async Task<Model.DataResult<List<Response.FormsOfConsent>>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<List<Response.FormsOfConsent>>(apiClient);

    }
}
