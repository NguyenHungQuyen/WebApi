using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : BaseController
    {
        [HttpGet("hello")]
        public string Hello()
        {
            return "Welcome Ladies and Gentlemen";
        }
        public IEnumerable<Category> GetCategories(){
            return Provider.Category.GetCategories();
}

    }
}
