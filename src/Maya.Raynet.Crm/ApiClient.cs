using System;
using System.Collections.Generic;

namespace Maya.Raynet.Crm
{
    public class ApiClient
    {
        internal readonly Model.RaynetApiOption raynetApiOption;

        private readonly BaseHttpClient baseHttpClient;

        public const string Endpoint = "https://app.raynet.cz/api/v2";

        public ApiClient(Model.RaynetApiOption raynetApiOption)
        {
            ValidateRaynetOption(raynetApiOption);

            this.raynetApiOption = raynetApiOption;
            var option = InitHttpClient(this.raynetApiOption);
            this.baseHttpClient = new BaseHttpClient(option);
        }

        internal BaseHttpClient GetHttpClient()
        {
            return this.baseHttpClient;
        }

        internal Model.RaynetApiOption GetApiOption()
        {
            return this.raynetApiOption;
        }

        private static void ValidateRaynetOption(Model.RaynetApiOption config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

#pragma warning disable CA2208 // Instantiate argument exceptions correctly
            if (string.IsNullOrEmpty(config.ApiKey))
            {
                throw new ArgumentNullException(nameof(config.ApiKey));
            }

            if (string.IsNullOrEmpty(config.UserName))
            {
                throw new ArgumentNullException(nameof(config.UserName));
            }

            if (string.IsNullOrEmpty(config.InstanceName))
            {
                throw new ArgumentNullException(nameof(config.InstanceName));
#pragma warning restore CA2208 // Instantiate argument exceptions correctly
            }

            // it is ok.
        }

        private static Maya.AnyHttpClient.Model.HttpClientConnector InitHttpClient(Model.RaynetApiOption raynetApiOption)
        {
            try
            {
                var httpConfig = new Maya.AnyHttpClient.Model.HttpClientConnector
                {
                    Headers = new List<Maya.AnyHttpClient.Model.KeyValue>
                    {
                        new AnyHttpClient.Model.KeyValue { Name = "X-Instance-Name", Value = raynetApiOption.InstanceName}
                    },
                    Endpoint = raynetApiOption.Endpoint ?? Endpoint,
                    AuthType = "Basic",
                    UserName = raynetApiOption.UserName,
                    Password = raynetApiOption.ApiKey,
                    TimeoutSeconds = 30,
                };

                return httpConfig;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
