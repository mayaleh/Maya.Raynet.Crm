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
    public class UserLevelSecurity : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public UserLevelSecurity(long userAccountId, long securityLevelId)
        {
                Actions.Add("userAccount");
                Actions.Add(userAccountId.ToString());
                Actions.Add("securityLevel");
                Actions.Add(securityLevelId.ToString());
        }
        public new async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync(apiClient);
    }
}
