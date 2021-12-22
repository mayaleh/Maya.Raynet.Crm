# Get it

Install Maya.Rayanet.Crm from the nuget.org using package manager console:

```
PM> Install-Package Maya.Rayanet.Crm
```

## Usages

```csharp
using Maya.Raynet.Crm;


        // configuration
        Model.RaynetApiOption apiOptions = new()
        {
            InstanceName = "test",
            ApiKey = "123",
            UserName = "admin"
        };

        // create API client
        var raynetClient = new ApiClient(this.integrationFixture.apiOptions);

        // create request (load companies)
        var request = new Maya.Raynet.Crm.Request.Get.Companies()
        {
            Offset = 0,
            Limit = 10
        };

        try
        {
            
                // execute request and get the result
                var result = await request.ExecuteAsync(apiClient);

                // work with the result
                if(result.IsSuccess)
                {
                    // result.Data is type of List<Company>
                }
                else
                {
                    // error
                    var errorMessage = result.Message;
                }
        }
        catch (Exception)
        {
            throw;
        }
```