using CustomerPortal.Shared.Responses;

namespace CustomerPortal.Backend.Helpers
{
    public interface IMailHelper
    {
        ActionResponse<string> SendMail(string toName, string toEmail, string subject, string body);
    }
}
