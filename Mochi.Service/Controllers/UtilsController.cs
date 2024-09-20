using Microsoft.AspNetCore.Mvc;

namespace Mochi.Service.Controllers
{
    public class UtilsController : Controller
    {
        [HttpGet]
        [Route("Ping")]
        public async Task<IActionResult> Ping()
        {
            return Ok();
        }

        [HttpGet]
        [Route("Health")]
        public async Task<IActionResult> GetHealth()
        {
            return Ok();
        }
    }
}
