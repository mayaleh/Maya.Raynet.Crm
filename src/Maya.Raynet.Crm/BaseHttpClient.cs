﻿using System;
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

        public async Task<Result<Model.EmtpyResult, Exception>> GetEmptyAsync<T>(Uri uri)
        {
            try
            {
                return await this.HttpGet<Model.EmtpyResult>(uri);
            }
            catch (Exception e)
            {
                return Result<Model.EmtpyResult, Exception>.Failed(e);
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
        public async Task PutAsync(Uri uri)
        {

        }

        public async Task PutAsync<T>(Uri uri, T body)
        {

        }
        #endregion
    }
}
