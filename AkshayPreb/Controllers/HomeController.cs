using test = Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace AkshayPreb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [test.Inject]
        public ILogger _logger { get; set; }
        [HttpGet]
        public IActionResult Index()
        {
            _logger.Log();
            return Ok();
        }
    }
}
