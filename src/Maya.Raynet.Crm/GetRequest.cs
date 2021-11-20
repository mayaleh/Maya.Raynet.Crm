using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maya.AnyHttpClient;

namespace Maya.Raynet.Crm
{
    public class GetRequest : IGetRequest
    {
        protected virtual List<string> Actions { get; set; }

        protected static Uri ComposeUri<T>(string endpoint, IEnumerable<string> actions, T uriParameters)
        {
            var _dict = new Dictionary<string, string>();

            var props = uriParameters.GetType().GetProperties();
            foreach (var prop in props)
            {
                var attrs = prop.GetCustomAttributes(true);
                foreach (var attr in attrs)
                {
                    if (attr is Attribute.RaynetUriParam authAttr)
                    {
                        var name = authAttr.Name;
                        var val = prop.GetValue(uriParameters);
                        if (val != null)
                        {
                            _dict.Add(name, val.ToString());
                        }
                    }
                }
            }

            return BaseApiService.ComposeUri(endpoint, actions, _dict.ToArray());
        }

        internal async Task<Model.DataResult<T>> ExecuteAsync<T>(ApiClient apiClient)
        {
            try
            {
                var uri = ComposeUri(ApiClient.Endpoint, Actions, this);

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
                var uri = ComposeUri(ApiClient.Endpoint, Actions, this);

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

        internal async Task<Model.EmtpyResult> ExecuteEmptyAsync(ApiClient apiClient)
        {
            try
            {
                var uri = ComposeUri(ApiClient.Endpoint, Actions, this);

                var result = await apiClient.GetHttpClient()
                    .GetEmptyAsync<Model.EmtpyResult>(uri)
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
                var uri = ComposeUri(ApiClient.Endpoint, Actions, this);

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
