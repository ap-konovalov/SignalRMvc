using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace SignalRExample.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class HomeController: ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return File("~/index.html", "text/html");
        }
    }
}