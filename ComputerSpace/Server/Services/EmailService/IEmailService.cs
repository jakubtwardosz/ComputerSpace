namespace ComputerSpace.Server.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(Email request);
        void SendVerificationEmail(string Email, string Token);
    }
}
