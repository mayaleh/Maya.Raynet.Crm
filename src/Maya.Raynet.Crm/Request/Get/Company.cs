using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using Maya.Raynet.Crm.Attribute;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Request.Get
{
    public class Company : GetRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public Company(long companyId)
        {
            Actions.Add("company");
            Actions.Add(companyId.ToString());
        }

        public async Task<Model.DataResult<Response.Company>> ExecuteAsync(ApiClient apiClient)
            => await base.ExecuteAsync<Response.Company>(apiClient);

        [RaynetUriParam("companyId")]
        public long CompanyId { get; set; }

    }
}