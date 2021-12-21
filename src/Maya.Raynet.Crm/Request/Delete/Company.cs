using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Request.Delete
{
    public class Company : DeleteRequest
    {
        protected override List<string> Actions { get; set; } = new List<string>();

        public Company(long companyId)
        {
            Actions.Add("company");
            Actions.Add(companyId.ToString());
        }
        public new async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
                => await base.ExecuteAsync(apiClient);
    }
}
