using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Data;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //Connect to the Database
        private readonly ApplicationDbContext _dbcontext;
        public ProductController(ApplicationDbContext dbContext)
        {
            _dbcontext = dbContext;
        }

        [HttpGet]
        public IActionResult GetallProducts()
        {
            var allProducts = _dbcontext.Products.ToList();
            return Ok(allProducts);
        }
    }
}
