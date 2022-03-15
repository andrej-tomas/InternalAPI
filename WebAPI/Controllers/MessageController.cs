using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : Controller
    {

        [HttpPost(Name = "GetMessageFromExternalApi")]
        public ActionResult<string> Get(string message)
        {
            return message;
        }
    }
}
