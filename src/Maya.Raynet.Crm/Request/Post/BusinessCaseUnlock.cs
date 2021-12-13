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
    public class BusinessCaseUnlock : PostRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public BusinessCaseUnlock(long businessCaseId)
        {
            Actions.Add("businessCase");
            Actions.Add(businessCaseId.ToString());
            Actions.Add("unlock");
        }

        public async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteNoResultNoBodyAsync(apiClient);
    }
}
