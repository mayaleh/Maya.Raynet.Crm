using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.Raynet.Crm.Helper;

namespace Maya.Raynet.Crm
{
    public class PostRequest
    {
        protected virtual List<string> Actions { get; set; }

        protected internal async Task<Model.DataResult<TResponse>> ExecuteAsync<TReqeustBody, TResponse>(ApiClient apiClient, TReqeustBody body)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PostAsync<TReqeustBody, Model.DataResult<TResponse>>(uri, body)
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
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PostEmptyAsync(uri, body)
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
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PostAsync(uri, body)
                    .ConfigureAwait(false);

                if (result.IsFailure)
                {
                    throw result.Failure;
                }

                return Maya.Ext.Unit.Default;
            }
            catch (Exception)
            {
                throw;
            }
        }


        protected internal async Task<Maya.Ext.Unit> ExecuteNoResultNoBodyAsync(ApiClient apiClient)
        {
            try
            {
                var uri = RequestHelper.ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .PostAsync(uri)
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
