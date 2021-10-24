using System;
using System.Collections.Generic;

namespace Maya.Raynet.Crm
{
    public class ApiClient
    {
        private readonly Model.RaynetApiOption raynetApiOption;

        public ApiClient(Model.RaynetApiOption raynetApiOption)
        {
            ValidateRaynetOption(raynetApiOption);

            this.raynetApiOption = raynetApiOption;
        }

        private static void ValidateRaynetOption(Model.RaynetApiOption config)
        {
            if (config == null)
            {
                throw new ArgumentNullException(nameof(Model.RaynetApiOption));
            }

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
                    Endpoint = "https://app.raynet.cz/api/v2/company/",
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
