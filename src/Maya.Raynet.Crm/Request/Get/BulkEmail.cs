// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Request.Get
{
    public class BulkEmail : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public BulkEmail(long massEmailId)
        {
            Actions.Add("massEmail");
            Actions.Add(massEmailId.ToString());
        }
        public new async Task<Model.DataResult<Response.Get.BulkEmail>> ExecuteAsync(ApiClient apiClient)
        {
            return await base.ExecuteAsync<Response.Get.BulkEmail>(apiClient);
        }
    }
}
