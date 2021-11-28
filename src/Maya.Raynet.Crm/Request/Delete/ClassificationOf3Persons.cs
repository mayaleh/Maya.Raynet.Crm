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
    public class ClassificationOf3Persons : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public ClassificationOf3Persons(long id)
        {
                Actions.Add("personClassification3");
                Actions.Add(id.ToString());
        }
        public ClassificationOf3Persons SetRequestData(Model.Request.Delete.ClassificationOf3Persons body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.ClassificationOf3Persons>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.ClassificationOf3Persons, Response.Delete.ClassificationOf3Persons>(apiClient, this.requestBody);

        private Model.Request.Delete.ClassificationOf3Persons requestBody;

    }
}
