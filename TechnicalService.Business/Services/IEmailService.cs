using TechnicalService.Core.Emails;

namespace TechnicalService.Business.Services
{
    public interface IEmailService
    {
        Task SendMailAsync(MailModel model);
    }
}
