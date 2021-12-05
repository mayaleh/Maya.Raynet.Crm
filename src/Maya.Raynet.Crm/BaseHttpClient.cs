using System;
using System.Threading.Tasks;
using Maya.AnyHttpClient;
using Maya.AnyHttpClient.Model;
using Maya.Ext.Rop;

namespace Maya.Raynet.Crm
{
    internal class BaseHttpClient : BaseApiService
    {
        public BaseHttpClient(IHttpClientConnector httpClientConnenctor) : base(httpClientConnenctor)
        {
        }
        #region GET http
        public async Task<Result<Model.DataResult<T>, Exception>> GetAsync<T>(Uri uri)
        {
            try
            {
                return await this.HttpGet<Model.DataResult<T>>(uri);
            }
            catch (Exception e)
            {
                return Result<Model.DataResult<T>, Exception>.Failed(e);
            }
        }

        public async Task<Result<T, Exception>> GetResultAsync<T>(Uri uri)
        {
            try
            {
                return await this.HttpGet<T>(uri);
            }
            catch (Exception e)
            {
                return Result<T, Exception>.Failed(e);
            }
        }

        public async Task<Result<Model.EmptyResult, Exception>> GetEmptyAsync<T>(Uri uri)
        {
            try
            {
                return await this.HttpGet<Model.EmptyResult>(uri);
            }
            catch (Exception e)
            {
                return Result<Model.EmptyResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<byte[], Exception>> GetBytesAsync(Uri uri)
        {
            try
            {
                return await this.HttpGet<byte[]>(uri);
            }
            catch (Exception e)
            {
                return Result<byte[], Exception>.Failed(e);
            }
        }
        #endregion

        #region PUT http
        public async Task<Result<Maya.Ext.Unit, Exception>> PutAsync(Uri uri)
        {
            try
            {
                return await this.HttpPut<Maya.Ext.Unit>(uri, null);
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> PutAsync<TResult>(Uri uri)
        {
            try
            {
                return await this.HttpPut<TResult>(uri, null);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<Maya.Ext.Unit, Exception>> PutAsync<T>(Uri uri, T body)
        {
            try
            {
                return await this.HttpPut<Maya.Ext.Unit>(uri, body);
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<Model.EmptyResult, Exception>> PutEmptyAsync<T>(Uri uri, T body)
        {
            try
            {
                return await this.HttpPut<Model.EmptyResult>(uri, body);
            }
            catch (Exception e)
            {
                return Result<Model.EmptyResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> PutAsync<TBody, TResult>(Uri uri, TBody body)
        {
            try
            {
                return await this.HttpPut<TResult>(uri, body);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }
        #endregion

        #region POST http

        public async Task<Result<Maya.Ext.Unit, Exception>> PostAsync(Uri uri)
        {
            try
            {
                return await this.HttpPost<Maya.Ext.Unit>(uri, new { });
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<Model.EmptyResult, Exception>> PostEmptyAsync<T>(Uri uri, T body)
        {
            try
            {
                return await this.HttpPost<Model.EmptyResult>(uri, body);
            }
            catch (Exception e)
            {
                return Result<Model.EmptyResult, Exception>.Failed(e);
            }
        }

        public async Task<Result<Maya.Ext.Unit, Exception>> PostAsync<T>(Uri uri, T body)
        {
            try
            {
                return await this.HttpPost<Maya.Ext.Unit>(uri, body);
            }
            catch (Exception e)
            {
                return Result<Maya.Ext.Unit, Exception>.Failed(e);
            }
        }

        public async Task<Result<TResult, Exception>> PostAsync<TBody, TResult>(Uri uri, TBody body)
        {
            try
            {
                return await this.HttpPost<TResult>(uri, body);
            }
            catch (Exception e)
            {
                return Result<TResult, Exception>.Failed(e);
            }
        }
        #endregion
    }
}
