using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
