using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Maya.Raynet.Crm.Tests
{
    public class IntegrationFixture
    {
        public Model.RaynetApiOption apiOptions = new Model.RaynetApiOption()
        {
            InstanceName = "test",
            ApiKey = "123",
            UserName = "admin",
            Endpoint = "https://localhost:7187/api/v2" // mock Raynet API
        };
    }

    public class Integration : IClassFixture<IntegrationFixture>
    {
        private readonly IntegrationFixture integrationFixture;

        public Integration(IntegrationFixture integrationFixture)
        {
            this.integrationFixture = integrationFixture;
        }

        private ApiClient GetClient()
        {
            return new ApiClient(this.integrationFixture.apiOptions);
        }

        [Fact]
        public async Task GetCompaniesTest()
        {
            var expResponseObj = JsonConvert.DeserializeObject<Model.DataResult<List<Response.Get.Company>>>("{\"success\":\"true\",\"totalCount\":1,\"data\":[{\"id\":2,\"name\":\"Tests.r.o.\",\"titleBefore\":null,\"firstName\":null,\"lastName\":null,\"titleAfter\":null,\"person\":false,\"role\":\"B_PARTNER\",\"state\":\"B_ACTUAL\",\"rating\":\"A\",\"owner\":{\"id\":1,\"fullName\":\"RAYNETCRM\"},\"regNumber\":\"123456789\",\"taxNumber\":\"CZ123456789\",\"taxNumber2\":null,\"taxPayer\":\"YES\",\"primaryAddress\":{\"id\":2,\"primary\":true,\"contactAddress\":false,\"address\":{\"id\":2,\"city\":\"Ostrava - Slezsk\u00e1Ostrava\",\"country\":\"\u010cesk\u00e1republika\",\"name\":\"S\u00eddlofirmy\",\"province\":\"Moravskoslezsk\u00fdkraj\",\"street\":\"T\u011b\u0161\u00ednsk\u00e1\",\"zipCode\":\"71000\",\"lat\":49.2499446,\"lng\":13.703011},\"territory\":{\"id\":91,\"value\":\"Morava\"},\"contactInfo\":{\"email\":\"test@test.cz\",\"email2\":\"test2@test.cz\",\"primary\":true,\"tel1\":\"123456789\",\"tel1Type\":\"mobil\",\"tel2\":\"987654321\",\"tel2Type\":\"pevn\u00e1linka\",\"www\":\"www.test.cz\",\"otherContact\":null}},\"contactAddress\":{\"id\":3,\"primary\":false,\"contactAddress\":true,\"address\":{\"id\":3,\"city\":\"Ostrava - Moravsk\u00e1Ostrava\",\"country\":\"\u010cesk\u00e1republika\",\"name\":\"Provozovna\",\"province\":\"Moravskoslezsk\u00fdkraj\",\"street\":\"\u010ceskobratrsk\u00e1113\",\"zipCode\":\"70200\",\"lat\":null,\"lng\":null},\"territory\":{\"id\":91,\"value\":\"Morava\"},\"contactInfo\":{\"email\":\"provozovna@test.cz\",\"email2\":null,\"primary\":true,\"tel1\":\"444444444\",\"tel1Type\":\"mobil\",\"tel2\":\"111111111\",\"tel2Type\":\"pevn\u00e1linka\",\"www\":null,\"otherContact\":null}},\"category\":{\"id\":15,\"value\":\"Z\u00e1kazn\u00edk\"},\"turnover\":{\"id\":82,\"value\":\"do1mil.K\u010d\"},\"economyActivity\":{\"id\":92,\"value\":\"obor1\"},\"companyClassification1\":{\"id\":93,\"value\":\"kla1\"},\"companyClassification2\":{\"id\":94,\"value\":\"kla2\"},\"companyClassification3\":{\"id\":95,\"value\":\"kla3\"},\"paymentTerm\":{\"id\":64,\"value\":\"7dn\u00ed\"},\"contactSource\":{\"id\":62,\"value\":\"e - mail\"},\"birthday\":null,\"notice\":\"poznamkakfirme\",\"tags\":[\"stitek1\",\"stitek2\"],\"customFields\":null,\"rowInfo.createdAt\":\"2014 - 06 - 1813:19\",\"rowInfo.createdBy\":\"demo @raynet.cz\",\"rowInfo.updatedAt\":\"2017 - 09 - 2214:17\",\"rowInfo.updatedBy\":\"demo @raynet.cz\",\"rowInfo.rowAccess\":null,\"rowInfo.rowState\":null,\"securityLevel\":{\"id\":1,\"name\":\"Sd\u00edlen\u00e1\"},\"inlineGdpr\":[{\"id\":1,\"validFrom\":\"2018 - 01 - 01\",\"validTill\":\"2019 - 01 - 01\",\"legalTitle\":\"LEGITIMATE_INTEREST\",\"templateName\":\"Opravn\u011bn\u00fdz\u00e1jem\",\"gdprTemplate\":1}],\"_version\":16}]}");
            var expResponseStr = JsonConvert.SerializeObject(expResponseObj);

            var apiClient = this.GetClient();
            var request = new Maya.Raynet.Crm.Request.Get.Companies();
            var result = await request.ExecuteAsync(apiClient);
            var actResponseSrt = JsonConvert.SerializeObject(result);

            Assert.Equal(expResponseStr, actResponseSrt);
        }

        [Fact]
        public async Task GetCompanyTest()
        {
            var expResponseRaw = "{\n  \"success\": \"true\",\n  \"data\": {\n    \"id\": 2,\n    \"name\": \"Test s.r.o.\",\n    \"person\": false,\n    \"firstName\": null,\n    \"lastName\": null,\n    \"titleBefore\": null,\n    \"titleAfter\": null,\n    \"salutation\": null,\n    \"owner\": {\n      \"id\": 1,\n      \"fullName\": \"RAYNET CRM\"\n    },\n    \"rating\": \"A\",\n    \"state\": \"B_ACTUAL\",\n    \"role\": \"B_PARTNER\",\n    \"notice\": \"poznamka k firme\",\n    \"category\": {\n      \"id\": 15,\n      \"value\": \"Z\u00e1kazn\u00edk\"\n    },\n    \"contactSource\": {\n      \"id\": 62,\n      \"value\": \"e-mail\"\n    },\n    \"employeesNumber\": {\n      \"id\": 64,\n      \"value\": \"1 - 10\"\n    },\n    \"legalForm\": {\n      \"id\": 64,\n      \"value\": \"s.r.o.\"\n    },\n    \"paymentTerm\": {\n      \"id\": 64,\n      \"value\": \"7 dn\u00ed\"\n    },\n    \"turnover\": {\n      \"id\": 82,\n      \"value\": \"do 1 mil. K\u010d\"\n    },\n    \"economyActivity\": {\n      \"id\": 92,\n      \"value\": \"obor 1\"\n    },\n    \"companyClassification1\": {\n      \"id\": 93,\n      \"value\": \"kla 1\"\n    },\n    \"companyClassification2\": {\n      \"id\": 94,\n      \"value\": \"kla 2\"\n    },\n    \"companyClassification3\": {\n      \"id\": 95,\n      \"value\": \"kla 3\"\n    },\n    \"regNumber\": \"123456789\",\n    \"taxNumber\": \"CZ123456789\",\n    \"taxNumber2\": null,\n    \"taxPayer\": \"YES\",\n    \"bankAccount\": \"123456\\/1111\",\n    \"birthday\": null,\n    \"primaryAddress\": {\n      \"id\": 2,\n      \"primary\": true,\n      \"contactAddress\": false,\n      \"address\": {\n        \"id\": 2,\n        \"city\": \"Ostrava-Slezsk\u00e1 Ostrava\",\n        \"country\": \"\u010cesk\u00e1 republika\",\n        \"name\": \"S\u00eddlo firmy\",\n        \"province\": \"Moravskoslezsk\u00fd kraj\",\n        \"street\": \"T\u011b\u0161\u00ednsk\u00e1\",\n        \"zipCode\": \"710 00\",\n        \"lat\": null,\n        \"lng\": null\n      },\n      \"territory\": {\n        \"id\": 91,\n        \"value\": \"Morava\"\n      },\n      \"contactInfo\": {\n        \"email\": \"test@test.cz\",\n        \"email2\": \"test2@test.cz\",\n        \"primary\": true,\n        \"tel1\": \"123 456 789\",\n        \"tel1Type\": \"mobil\",\n        \"tel2\": \"987 654 321\",\n        \"tel2Type\": \"pevn\u00e1 linka\",\n        \"www\": \"www.test.cz\",\n        \"otherContact\": null\n      }\n    },\n    \"tags\": [\n      \"stitek1\",\n      \"stitek 2\"\n    ],\n    \"logo\": {\n      \"id\": 428,\n      \"contentType\": \"image\\/png\",\n      \"fileName\": \"logo.png\",\n      \"size\": 17485\n    },\n    \"socialNetworkContact\": {\n      \"facebook\": \"abcd\",\n      \"googleplus\": null,\n      \"twitter\": null,\n      \"linkedin\": null,\n      \"pinterest\": null,\n      \"instagram\": null,\n      \"skype\": null,\n      \"youtube\": null\n    },\n    \"customFields\": {\n      \"Cislo_klie_cd702\": \"AB123\",\n      \"Lonsky_zis_7aac1\": 500,\n      \"Spoluprace_2aa2c\": \"2016-02-02\"\n    },\n    \"rowInfo.createdAt\": \"2014-06-18 13:19\",\n    \"rowInfo.createdBy\": \"demo@raynet.cz\",\n    \"rowInfo.updatedAt\": \"2017-01-23 09:50\",\n    \"rowInfo.updatedBy\": \"demo@raynet.cz\",\n    \"rowInfo.rowAccess\": null,\n    \"rowInfo.rowState\": null,\n    \"_version\": 14,\n    \"attachments\": [\n      {\n        \"id\": 213,\n        \"link\": null,\n        \"linkName\": null,\n        \"file\": {\n          \"id\": 631,\n          \"contentType\": \"application\\/zip\",\n          \"fileName\": \"test_zip.zip\",\n          \"size\": 4413\n        },\n        \"folder\": \"Test\"\n      }\n    ],\n    \"addresses\": [\n      {\n        \"id\": 2,\n        \"primary\": true,\n        \"contactAddress\": false,\n        \"address\": {\n          \"id\": 2,\n          \"city\": \"Ostrava-Slezsk\u00e1 Ostrava\",\n          \"country\": \"\u010cesk\u00e1 republika\",\n          \"name\": \"S\u00eddlo firmy\",\n          \"province\": \"Moravskoslezsk\u00fd kraj\",\n          \"street\": \"T\u011b\u0161\u00ednsk\u00e1\",\n          \"zipCode\": \"710 00\",\n          \"lat\": null,\n          \"lng\": null\n        },\n        \"territory\": {\n          \"id\": 91,\n          \"value\": \"Morava\"\n        },\n        \"contactInfo\": {\n          \"email\": \"test@test.cz\",\n          \"email2\": \"test2@test.cz\",\n          \"primary\": true,\n          \"tel1\": \"123 456 789\",\n          \"tel1Type\": \"mobil\",\n          \"tel2\": \"987 654 321\",\n          \"tel2Type\": \"pevn\u00e1 linka\",\n          \"www\": \"www.test.cz\",\n          \"otherContact\": null\n        }\n      },\n      {\n        \"id\": 3,\n        \"primary\": false,\n        \"contactAddress\": true,\n        \"address\": {\n          \"id\": 3,\n          \"city\": \"Ostrava-Moravsk\u00e1 Ostrava\",\n          \"country\": \"\u010cesk\u00e1 republika\",\n          \"name\": \"Provozovna\",\n          \"province\": \"Moravskoslezsk\u00fd kraj\",\n          \"street\": \"\u010ceskobratrsk\u00e1 113\",\n          \"zipCode\": \"702 00\",\n          \"lat\": null,\n          \"lng\": null\n        },\n        \"territory\": {\n          \"id\": 91,\n          \"value\": \"Morava\"\n        },\n        \"contactInfo\": {\n          \"email\": \"provozovna@test.cz\",\n          \"email2\": null,\n          \"primary\": true,\n          \"tel1\": \"444 444 444\",\n          \"tel1Type\": \"mobil\",\n          \"tel2\": \"111 111 111\",\n          \"tel2Type\": \"pevn\u00e1 linka\",\n          \"www\": null,\n          \"otherContact\": null\n        }\n      }\n    ],\n    \"inlineGdpr\": [\n      {\n        \"id\": 1,\n        \"validFrom\": \"2018-01-01\",\n        \"validTill\": \"2019-01-01\",\n        \"legalTitle\": \"LEGITIMATE_INTEREST\",\n        \"templateName\": \"Opravn\u011bn\u00fd z\u00e1jem\",\n        \"gdprTemplate\": 1\n      }\n    ],\n    \"originLead\": {\n      \"id\": 4,\n      \"code\": \"L-18-002\",\n      \"topic\": \"M\u016fj lead\"\n    }\n  }\n}";
            var expResponseObj = JsonConvert.DeserializeObject<Model.DataResult<Response.Get.Company>>(expResponseRaw);
            var expResponseStr = JsonConvert.SerializeObject(expResponseObj);

            var apiClient = this.GetClient();
            var request = new Maya.Raynet.Crm.Request.Get.Company(5);
            var result = await request.ExecuteAsync(apiClient);
            var actResponseSrt = JsonConvert.SerializeObject(result);

            Assert.Equal(expResponseStr, actResponseSrt);
        }

        [Fact]
        public async Task CreateCompanyTest()
        {
            var expResponseRaw = "{\n  \"success\": true,\n  \"data\": {\n    \"id\": 5\n  }\n}";
            var expResponseObj = JsonConvert.DeserializeObject<Model.DataResult<Response.Put.IdResult>>(expResponseRaw);
            var expResponseStr = JsonConvert.SerializeObject(expResponseObj);

            var apiClient = this.GetClient();
            var request = new Maya.Raynet.Crm.Request.Put.Company();
            request.SetRequestData(new Model.Request.Put.Company { Name = "custom" });
            var result = await request.ExecuteAsync(apiClient);
            var actResponseSrt = JsonConvert.SerializeObject(result);

            Assert.Equal(expResponseStr, actResponseSrt);
        }

        [Fact]
        public async Task UpdateCompanyTest()
        {
            var expResponse = Ext.Unit.Default;

            var apiClient = this.GetClient();
            var request = new Maya.Raynet.Crm.Request.Post.Company(5);
            request.SetRequestData(new Model.Request.Post.Company { Name = "custom edited" });
            var result = await request.ExecuteAsync(apiClient);

            Assert.Equal(expResponse, result);
        }

        [Fact]
        public async Task DeleteCompanyTest()
        {
            var expResponse = Ext.Unit.Default;

            var apiClient = this.GetClient();
            var request = new Maya.Raynet.Crm.Request.Delete.Company(5);
            var result = await request.ExecuteAsync(apiClient);

            Assert.Equal(expResponse, result);
        }
    }
}
