using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Helper;

namespace Maya.Raynet.Crm
{
    public class DeleteRequest
    {
        protected virtual List<string> Actions { get; set; }

        protected internal async Task<Ext.Unit> ExecuteAsync(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(Actions, this);

                var result = await apiClient.GetHttpClient()
                    .DeleteAsync(uri)
                    .ConfigureAwait(false);

                if (result.IsFailure)
                {
                    throw result.Failure;
                }

                return result.Success;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
