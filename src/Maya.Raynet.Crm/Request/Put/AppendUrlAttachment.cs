// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 28.11.2021 16:31:27 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Put
{
    /// <summary>
    /// Pøidání pøílohy s odkazem na URL
    /// API slouží k vytvoøení záznamu pøílohy odkazující na libovolné URL, napø. na webové stránky.Pøíloha se pøiøadí k vybrané entitì, zadané jejím ID a názvem entity.API ke své funkci potøebuje znát URL odkazu a název odkazu.
    /// </summary>
    public class AppendUrlAttachment : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public AppendUrlAttachment(string entityName, long entityId)
        {
                Actions.Add("attachment");
                Actions.Add(entityName.ToString());
                Actions.Add(entityId.ToString());
        }
        public AppendUrlAttachment SetRequestData(Model.Request.Put.UrlAttachment body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<int>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.UrlAttachment, int>(apiClient, this.requestBody);

        private Model.Request.Put.UrlAttachment requestBody;

    }
}
