using Microsoft.AspNetCore.Mvc;

namespace Core5_VueJs.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController:ControllerBase
    {
        public TestController()
        {
            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test GET API");
        }
    }
}