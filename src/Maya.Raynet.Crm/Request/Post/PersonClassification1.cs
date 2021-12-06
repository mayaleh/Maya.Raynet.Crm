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
    public class PersonClassification1 : PostRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public PersonClassification1(long id)
        {
            Actions.Add("personClassification1");
            Actions.Add(id.ToString());
        }
        public PersonClassification1 SetRequestData(Model.Request.Post.PersonClassification1 body)
        {
            this.requestBody = body;
            return this;
        }

        public async Task<Model.EmptyResult> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteEmptyResultAsync<Model.Request.Post.PersonClassification1>(apiClient, this.requestBody);

        private Model.Request.Post.PersonClassification1 requestBody;

    }
}
