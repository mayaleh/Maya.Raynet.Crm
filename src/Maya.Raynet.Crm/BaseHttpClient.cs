using System;
using System.Threading.Tasks;
using Maya.AnyHttpClient;
using Maya.AnyHttpClient.Model;
using Maya.Ext.Rop;

namespace Maya.Raynet.Crm
{
    internal class BaseHttpClient : ApiService
    {
        public BaseHttpClient(IHttpClientConnector httpClientConnenctor) : base(httpClientConnenctor)
        {
        }

        #region GET http
        public async Task<Result<Model.DataResult<T>, Exception>> GetAsync<T>(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpGet<Model.DataResult<T>>(uriRequest);
            }
            catch (Exception e)
            {
                return Result<Model.DataResult<T>, Exception>.Failed(e);
            }
        }

        public async Task<Result<T, Exception>> GetResultAsync<T>(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpGet<T>(uriRequest);
            }
            catch (Exception e)
            {
                return Result<T, Exception>.Failed(e);
            }
        }

        public async Task<Result<Model.EmptyResult, Exception>> GetEmptyAsync<T>(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpGet<Model.EmptyResult>(uriRequest);
            }
            catch (Exception e)
            {
                return Result<Model.EmptyResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<byte[], Exception>> GetBytesAsync(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpGet<byte[]>(uriRequest);
            }
            catch (Exception e)
            {
                return Result<byte[], Exception>.Failed(e);
            }
        }
        #endregion

        #region PUT http
        public async Task<Result<Maya.Ext.Unit, Exception>> PutAsync(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpPut<Maya.Ext.Unit>(uriRequest, null);
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> PutAsync<TResult>(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpPut<TResult>(uriRequest, null);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<Maya.Ext.Unit, Exception>> PutAsync<T>(UriRequest uriRequest, T body)
        {
            try
            {
                return await this.HttpPut<Maya.Ext.Unit>(uriRequest, body);
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<Model.EmptyResult, Exception>> PutEmptyAsync<T>(UriRequest uriRequest, T body)
        {
            try
            {
                return await this.HttpPut<Model.EmptyResult>(uriRequest, body);
            }
            catch (Exception e)
            {
                return Result<Model.EmptyResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> PutAsync<TBody, TResult>(UriRequest uriRequest, TBody body)
        {
            try
            {
                return await this.HttpPut<TResult>(uriRequest, body);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }
        #endregion

        #region POST http

        public async Task<Result<Maya.Ext.Unit, Exception>> PostAsync(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpPost<Maya.Ext.Unit>(uriRequest, new { });
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<Model.EmptyResult, Exception>> PostEmptyAsync<T>(UriRequest uriRequest, T body)
        {
            try
            {
                return await this.HttpPost<Model.EmptyResult>(uriRequest, body);
            }
            catch (Exception e)
            {
                return Result<Model.EmptyResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<Maya.Ext.Unit, Exception>> PostAsync<T>(UriRequest uriRequest, T body)
        {
            try
            {
                return await this.HttpPost<Maya.Ext.Unit>(uriRequest, body);
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> PostAsync<TBody, TResult>(UriRequest uriRequest, TBody body)
        {
            try
            {
                return await this.HttpPost<TResult>(uriRequest, body);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }
        #endregion

        #region DELETE http
        public async Task<Result<Ext.Unit, Exception>> DeleteAsync(UriRequest uriRequest)
        {
            try
            {
                return await this.HttpDelete<Ext.Unit>(uriRequest);
            }
            catch (Exception e)
            {
                return Result<Ext.Unit, Exception>.Failed(e);
            }
        }
        #endregion
    }
}
