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
    public class SettingUpThePrimaryRelationshipWithTheCompany : PostRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public SettingUpThePrimaryRelationshipWithTheCompany(long personId, long relationshipId)
        {
                Actions.Add("person");
                Actions.Add(personId.ToString());
                Actions.Add("relationship");
                Actions.Add(relationshipId.ToString());
                Actions.Add("setPrimary");
        }
        public SettingUpThePrimaryRelationshipWithTheCompany SetRequestData(Model.Request.Post.SettingUpThePrimaryRelationshipWithTheCompany body)
         {
             this.requestBody = body;
             return this;
         }

        public async Task<Model.DataResult<Response.Post.SettingUpThePrimaryRelationshipWithTheCompany>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Model.Request.Post.SettingUpThePrimaryRelationshipWithTheCompany, Response.Post.SettingUpThePrimaryRelationshipWithTheCompany>(apiClient, this.requestBody);

        private Model.Request.Post.SettingUpThePrimaryRelationshipWithTheCompany requestBody;

    }
}
