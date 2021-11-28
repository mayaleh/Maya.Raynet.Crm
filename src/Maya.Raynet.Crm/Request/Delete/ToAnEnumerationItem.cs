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
    public class ToAnEnumerationItem : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ToAnEnumerationItem(string entityName, string fieldName)
        {
                Actions.Add("customField");
                Actions.Add("enum");
                Actions.Add(entityName.ToString());
                Actions.Add(fieldName.ToString());
        }
        public ToAnEnumerationItem SetRequestData(Model.Request.Delete.ToAnEnumerationItem body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.ToAnEnumerationItem>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.ToAnEnumerationItem, Response.Delete.ToAnEnumerationItem>(apiClient, this.requestBody);

        private Model.Request.Delete.ToAnEnumerationItem requestBody;

    }
}
