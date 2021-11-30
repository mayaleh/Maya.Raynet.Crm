using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maya.AnyHttpClient;
using Maya.Raynet.Crm.Helper;

namespace Maya.Raynet.Crm
{
    public class GetRequest : IGetRequest
    {
        protected virtual List<string> Actions { get; set; }

        internal async Task<Model.DataResult<T>> ExecuteAsync<T>(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .GetAsync<T>(uri)
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

        internal async Task<T> ExecuteRequestAsync<T>(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .GetResultAsync<T>(uri)
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

        internal async Task<Model.EmptyResult> ExecuteEmptyAsync(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .GetEmptyAsync<Model.EmptyResult>(uri)
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

        internal async Task<byte[]> ExecuteAsync(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .GetBytesAsync(uri)
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
