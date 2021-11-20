using Xunit;

namespace Maya.Raynet.Crm.Tests.Request.Get
{
    public class CompanyTests
    {

        [Fact]
        public void Execute_ShouldCreateGetReqeuest()
        {
            var options = new Model.RaynetApiOption()
            {
                InstanceName = "test",
                ApiKey = "123",
                UserName = "admin"
            };
            var apiClient = new ApiClient(options);

            var request = new Maya.Raynet.Crm.Request.Get.Company(123);
            _ = request.ExecuteAsync(apiClient)
                .GetAwaiter()
                .GetResult();
        }
    }
}
