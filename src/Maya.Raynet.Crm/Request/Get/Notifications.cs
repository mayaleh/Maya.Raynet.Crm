// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 07.11.2021 14:32:47 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Notifications : GetRequest
    {
        protected override List<string> Actions {get; set;} = new List<string>();

        public Notifications()
        {
                Actions.Add("notification");
        }
        public async Task<Model.DataResult<Response.Notifications>> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync<Response.Notifications>(apiClient);

        [RaynetUriParam("offset")]
        public int Offset { get; set; }

        [RaynetUriParam("limit")]
        public int Limit { get; set; }

        [RaynetUriParam("sortColumn")]
        public string SortColumn { get; set; }

        [RaynetUriParam("sortDirection")]
        public string SortDirection { get; set; }

        [RaynetUriParam("id")]
        public long Id { get; set; }

        [RaynetUriParam("date")]
        public string Date { get; set; }

        [RaynetUriParam("sender")]
        public long Sender { get; set; }

        [RaynetUriParam("recipient")]
        public string Recipient { get; set; }

        [RaynetUriParam("flag")]
        public bool Flag { get; set; }

        [RaynetUriParam("read")]
        public bool Read { get; set; }

        [RaynetUriParam("context")]
        public string Context { get; set; }

    }
}
