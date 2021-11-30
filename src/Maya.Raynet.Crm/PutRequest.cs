using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Helper;

namespace Maya.Raynet.Crm
{
    public class PutRequest
    {
        protected virtual List<string> Actions { get; set; }

        internal async Task<Model.DataResult<TResponse>> ExecuteNoBodyAsync<TResponse>(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutAsync<TResponse>(uri)
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

        internal async Task<Model.DataResult<TResponse>> ExecuteAsync<TReqeustBody, TResponse>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutAsync<TResponse>(uri, body)
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

        internal async Task ExecuteNoResultAsync<TReqeustBody>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutAsync(uri, body)
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

        internal async Task<Model.EmptyResult> ExecuteEmptyResultAsync<TReqeustBody>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutEmptyAsync(uri, body)
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
