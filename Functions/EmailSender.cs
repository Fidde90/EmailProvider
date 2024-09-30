using System;
using System.Threading.Tasks;
using Azure.Communication.Email;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace EmailProvider.Functions
{
    public class EmailSender
    {
        private readonly ILogger<EmailSender> _logger;
        private readonly EmailClient _emailClient;

        public EmailSender(ILogger<EmailSender> logger, EmailClient emailClient)
        {
            _logger = logger;
            _emailClient = emailClient;
        }

        [Function(nameof(EmailSender))]
        public async Task Run([ServiceBusTrigger("email_request", Connection = "ServiceBusConnection")]ServiceBusReceivedMessage message,ServiceBusMessageActions messageActions)
        {
            
        }
    }
}
