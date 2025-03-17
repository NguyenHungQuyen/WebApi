using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        [HttpGet("hello")]
        public string Hello()
        {
            return "Welcome Ladies and Gentlemen";
        }
    }
}
