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
    public class EnumerationItem : PutRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public EnumerationItem(string entityName, string fieldName)
        {
                Actions.Add("customField");
                Actions.Add("enum");
                Actions.Add(entityName.ToString());
                Actions.Add(fieldName.ToString());
        }
        public EnumerationItem SetRequestData(Model.Request.Put.EnumerationItem body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.EmptyResult> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteEmptyResultAsync<Model.Request.Put.EnumerationItem>(apiClient, this.requestBody);

        private Model.Request.Put.EnumerationItem requestBody;

    }
}
