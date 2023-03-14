using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseApiController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            
            return Ok();
        }
    }
}