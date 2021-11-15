// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class ExportOrdersToPDF : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public ExportOrdersToPDF(long salesOrderId)
        {
            Actions.Add("salesOrder");
            Actions.Add(salesOrderId.ToString());
            Actions.Add("pdfExport");
        }
        public new async Task<Response.PdfExportInfo> ExecuteAsync(ApiClient apiClient)
            => await base.ExecuteRequestAsync<Response.PdfExportInfo>(apiClient);

        [RaynetUriParam("locale")]
        public string Locale { get; set; }

    }
}
