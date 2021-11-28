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
    public class DeletionOfLegalForm : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public DeletionOfLegalForm(long id)
        {
                Actions.Add("legalForm");
                Actions.Add(id.ToString());
        }
        public DeletionOfLegalForm SetRequestData(Model.Request.Delete.DeletionOfLegalForm body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.DeletionOfLegalForm>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.DeletionOfLegalForm, Response.Delete.DeletionOfLegalForm>(apiClient, this.requestBody);

        private Model.Request.Delete.DeletionOfLegalForm requestBody;

    }
}
