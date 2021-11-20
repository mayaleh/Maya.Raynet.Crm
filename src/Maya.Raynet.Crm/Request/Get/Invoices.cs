// Copyright (c) 2021 Salim Mayaleh. All Rights Reserved
// Licensed under the BSD-3-Clause License
// Generated at 08.11.2021 21:25:55 by RaynetApiDocToDotnet.ApiDocParser, created by Salim Mayaleh. 

using System.Collections.Generic;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Attribute;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Invoices : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public Invoices()
        {
            Actions.Add("invoice");
        }
        public new async Task<Model.DataResult<List<Response.Get.Invoice>>> ExecuteAsync(ApiClient apiClient)
        {
            return await base.ExecuteAsync<List<Response.Get.Invoice>>(apiClient);
        }

        [RaynetUriParam("offset")]
        public int Offset { get; set; }

        [RaynetUriParam("limit")]
        public int Limit { get; set; }

        [RaynetUriParam("sortColumn")]
        public string SortColumn { get; set; }

        [RaynetUriParam("sortDirection")]
        public string SortDirection { get; set; }

        [RaynetUriParam("fulltext")]
        public string Fulltext { get; set; }

        [RaynetUriParam("title")]
        public string Title { get; set; }

        [RaynetUriParam("code")]
        public string Code { get; set; }

        [RaynetUriParam("company")]
        public long Company { get; set; }

        [RaynetUriParam("owner")]
        public long Owner { get; set; }

        [RaynetUriParam("businessCase")]
        public long BusinessCase { get; set; }

        [RaynetUriParam("issueDate")]
        public string IssueDate { get; set; }

        [RaynetUriParam("invoiceType")]
        public string InvoiceType { get; set; }

        [RaynetUriParam("taxableSupplyDate")]
        public string TaxableSupplyDate { get; set; }

        [RaynetUriParam("dueDate")]
        public string DueDate { get; set; }

        [RaynetUriParam("paymentDate")]
        public string PaymentDate { get; set; }

        [RaynetUriParam("variableSymbol")]
        public string VariableSymbol { get; set; }

        [RaynetUriParam("specificSymbol")]
        public string SpecificSymbol { get; set; }

        [RaynetUriParam("constantSymbol")]
        public string ConstantSymbol { get; set; }

        [RaynetUriParam("rowInfo.createdAt")]
        public string RowInfo_createdAt { get; set; }

        [RaynetUriParam("rowInfo.updatedAt")]
        public string RowInfo_updatedAt { get; set; }

        [RaynetUriParam("rowInfo.lastModifiedAt")]
        public string RowInfo_lastModifiedAt { get; set; }

        [RaynetUriParam("view")]
        public string View { get; set; }

        [RaynetUriParam("tags")]
        public string Tags { get; set; }

    }
}
