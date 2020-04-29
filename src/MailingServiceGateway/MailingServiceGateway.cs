﻿using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using StockportGovUK.NetStandard.Gateways.Response;
using StockportGovUK.NetStandard.Models.Mail;

namespace StockportGovUK.NetStandard.Gateways.MailingServiceGateway
{
    public class MailingServiceGateway : Gateway, IMailingServiceGateway
    {
        private const string MailingEndpoint = "api/mail";
        public MailingServiceGateway(HttpClient httpClient, ILogger<Gateway> logger) : base(httpClient, logger)
        {
        }

        public async Task<HttpResponse<string>> Send(Mail model)
        {
            return await PostAsync<string>(MailingEndpoint, model);
        }
    }
}