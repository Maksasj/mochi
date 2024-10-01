using Microsoft.AspNetCore.Mvc;

namespace Mochi.Service.Controllers
{
    [ApiController]
    public class UtilsController
    {
        [HttpGet]
        [Route("Ping")]
        public async Task<IActionResult> Ping()
        {
            return new OkResult();
        }

        [HttpGet]
        [Route("Health")]
        public async Task<IActionResult> GetHealth()
        {
            return new OkResult();
        }
    }
}
