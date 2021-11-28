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
    public class Participant : DeleteRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Participant(long businessCaseId, long participantId)
        {
                Actions.Add("businessCase");
                Actions.Add(businessCaseId.ToString());
                Actions.Add("participants");
                Actions.Add(participantId.ToString());
        }
        public Participant SetRequestData(Model.Request.Delete.Participant body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Delete.Participant>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Delete.Participant, Response.Delete.Participant>(apiClient, this.requestBody);

        private Model.Request.Delete.Participant requestBody;

    }
}