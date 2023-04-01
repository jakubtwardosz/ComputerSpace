using Microsoft.AspNetCore.Mvc;

namespace ComputerSpace.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<bool>>> SendEmail(Email request)
        {
            _emailService.SendEmail(request);
            return Ok();

        }
    }
}
