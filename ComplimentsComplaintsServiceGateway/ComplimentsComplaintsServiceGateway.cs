using System.Net.Http;
using System.Threading.Tasks;
using StockportGovUK.AspNetCore.Gateways.Response;
using StockportGovUK.NetStandard.Models.Models.ComplimentsComplaints;

namespace StockportGovUK.AspNetCore.Gateways.ComplimentsComplaintsServiceGateway
{
    public class ComplimentsComplaintsServiceGateway : Gateway, IComplimentsComplaintsServiceGateway
    {
        private const string HttpClientName = "complimentsComplaintsGateway";
        private const string ComplimentEndpoint = "api/v1/Compliments";
        private const string ComplaintEndpoint = "api/v1/Complaints";

        public ComplimentsComplaintsServiceGateway(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<HttpResponse<CreateCaseResponse>> SubmitCompliment(ComplimentDetails model)
        {
            return await PostAsync<CreateCaseResponse>($"{ComplimentEndpoint}/submit-compliment", model);
        }

        public async Task<HttpResponse<CreateCaseResponse>> SubmitComplaint(ComplaintDetails model)
        {
            return await PostAsync<CreateCaseResponse>($"{ComplaintEndpoint}/submit-complaint", model);
        }
    }
}