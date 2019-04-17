using System.Net.Http;
using System.Threading.Tasks;
using StockportGovUK.AspNetCore.Gateways;

namespace StockportGovUK.AspNetCore.Gateways.AddressService
{
    public class GazateerGateway : Gateway, IAddressServiceGateway
    {
        private const string HttpClientName = "addressGateway";

        public GazateerGateway(IHttpClientFactory clientFactory) : base(clientFactory)
        {

        }

        public async Task<HttpResponseMessage> GetAsync(string postcode)
        {
            return await GetAsync(HttpClientName, $"v1/gis/{postcode}");
        }
    }
}