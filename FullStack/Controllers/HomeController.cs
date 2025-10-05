using FullStack.Models;
using FullStack.Services;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }
        [HttpGet("image")]
        public async Task<ActionResult<Home>> GetHomeImageAsync()
        {
            var home = await _homeService.GetHomeImageAsync();
            return Ok(home);
        }
    }
}
