using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandsService.API.Controllers
{
    //c in reference of Command
    [Route("api/c/[controller]")]
    [ApiController]
    public class PlatformsController : Controller
    {
        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("Inbound POST CommandService");
            return Ok("Inbound test from Platforms Controller");
        }
    }
}
