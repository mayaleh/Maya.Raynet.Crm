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
    public class BusinessCaseClassification3 : PostRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public BusinessCaseClassification3(long id)
        {
            Actions.Add("businessCaseClassification3");
            Actions.Add(id.ToString());
        }
        public BusinessCaseClassification3 SetRequestData(Model.Request.Post.BusinessCaseClassification3 body)
        {
            this.requestBody = body;
            return this;
        }

        public async Task<Model.EmptyResult> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteEmptyResultAsync(apiClient, this.requestBody);

        private Model.Request.Post.BusinessCaseClassification3 requestBody;

    }
}
