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
    /// Pøidání pøílohy se souborem
    /// API slouží k vytvoøení záznamu pøílohy, která odkazuje na pøedem uploadovaný soubor. Pøíloha se pøiøadí k vybrané entitì, zadané jejím ID a názvem entity. API ke své funkci potøebuje znát UUID pøedem nahraného souboru spolu s dalšími parametry tohoto souboru.
    /// </summary>
    public class AppendFileAttachment : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public AppendFileAttachment(string entityName, long entityId)
        {
                Actions.Add("attachment");
                Actions.Add(entityName.ToString());
                Actions.Add(entityId.ToString());
        }
        public AppendFileAttachment SetRequestData(Model.Request.Put.FileAttachment body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<int>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Put.FileAttachment, int>(apiClient, this.requestBody);

        private Model.Request.Put.FileAttachment requestBody;

    }
}
