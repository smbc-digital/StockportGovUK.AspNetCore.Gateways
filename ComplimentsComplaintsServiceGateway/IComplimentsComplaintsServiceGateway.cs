using System.Threading.Tasks;
using StockportGovUK.AspNetCore.Gateways.Response;
using StockportGovUK.NetStandard.Models.Models.ComplimentsComplaints;

namespace StockportGovUK.AspNetCore.Gateways.ComplimentsComplaintsServiceGateway
{
    public interface IComplimentsComplaintsServiceGateway
    {
        Task<HttpResponse<CreateCaseResponse>> SubmitCompliment(ComplimentDetails model);
        Task<HttpResponse<CreateCaseResponse>> SubmitFeedback(FeedbackDetails model);
    }
}