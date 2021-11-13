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
    public class DownloadExportBody : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public DownloadExportBody(string uuid, string accessToken, string instanceName)
        {
                Actions.Add("exportBody");
                Actions.Add(uuid.ToString());
                Actions.Add(accessToken.ToString());
                Actions.Add(instanceName.ToString());
        }

        // TODO: HttpClient.GetByteArrayAsync:
        //      Task<byte[]> GetByteArrayAsync (string? requestUri);
        public new async Task<byte[]> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync(apiClient);

    }
}
