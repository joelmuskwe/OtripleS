using System.Net.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using RESTFulSense.Clients;

namespace OtripleS.Web.Api.Tests.Acceptance.Brokers
{
    public class OtripleSApiBroker
    {
        private readonly WebApplicationFactory<Startup> _webApplicationFactory;
        private readonly HttpClient _httpClient;
        private readonly IRESTFulApiFactoryClient _apiFactoryClient;

        public OtripleSApiBroker()
        {
            _webApplicationFactory = new WebApplicationFactory<Startup>();
            _httpClient = _webApplicationFactory.CreateClient();
            _apiFactoryClient = new RESTFulApiFactoryClient(_httpClient);
        }
    }
}