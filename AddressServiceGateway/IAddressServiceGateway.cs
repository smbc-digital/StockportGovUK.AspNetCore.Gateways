using System.Net.Http;
using System.Threading.Tasks;
using StockportGovUK.AspNetCore.Gateways;

namespace StockportGovUK.AspNetCore.Gateways.AddressService
{
    public interface IAddressServiceGateway : IGateway
    {
        Task<HttpResponseMessage> GetAddressesAsync(string postcode);
        Task<HttpResponseMessage> GetPropertyDetailsAsync(string uprn);
    }
}