using Microsoft.AspNetCore.Mvc;
using Mochi.Service.Models;
using System.Diagnostics;

namespace Mochi.Service.Controllers
{
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return Ok();
        }
    }
}
