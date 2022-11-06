using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace ComputerSpace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> SendEmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("kristopher3@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("kristopher3@ethereal.email"));
            email.Subject = "Test Email Subject";
            
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            using var smtp = new SmtpClient();

            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("kristopher3@ethereal.email", "x1vK4rZSKXXaNS655v");
            smtp.Send(email);
            smtp.Disconnect(true);

            return Ok();

        }
    }
}
