using Microsoft.AspNetCore.Mvc;
using Mochi.Service.Models;
using System.Diagnostics;

namespace Mochi.Service.Controllers
{
    [ApiController]
    public class LoggerController : Controller
    {
        public LoggerController()
        {

        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
