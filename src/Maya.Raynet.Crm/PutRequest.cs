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

        protected internal async Task<Model.DataResult<TResponse>> ExecuteNoBodyAsync<TResponse>(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutAsync<Model.DataResult<TResponse>>(uri)
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
        
        protected internal async Task<Model.EmptyResult> ExecuteNoBodyEmptyResultAsync(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutAsync<Model.EmptyResult>(uri)
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

        protected internal async Task<Model.DataResult<TResponse>> ExecuteAsync<TReqeustBody, TResponse>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PutAsync<TReqeustBody, Model.DataResult<TResponse>>(uri, body)
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

        protected internal async Task<Maya.Ext.Unit> ExecuteNoResultAsync<TReqeustBody>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(Actions, this);

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

        protected internal async Task<Model.EmptyResult> ExecuteEmptyResultAsync<TReqeustBody>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(Actions, this);

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
