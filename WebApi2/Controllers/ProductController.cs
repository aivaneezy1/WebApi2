using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi2.Data;
using WebApi2.Model;
using WebApi2.Model.Entities;

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

        // GET ALL Product
        [HttpGet]
        public IActionResult GetallProducts()
        {
            var allProducts = _dbcontext.Products.ToList();
            return Ok(allProducts);
        }
        // Create a product
        [HttpPost]
        public IActionResult CreateProduct(ProductDto productDto)
        {
            var productEntity = new Product()
            {
                name = productDto.name, 
                price = productDto.price,
                featured = productDto.featured,
                rating = productDto.rating,
                company = productDto.company,
            };

            Console.WriteLine($"productEntity : {productEntity}");

            // save the changes into the db
            _dbcontext.Products.Add(productEntity);
            _dbcontext.SaveChanges();
            return Ok(productEntity);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public IActionResult GetProduct(Guid id)
        {
            var Product = _dbcontext.Products.Find(id);
            if(Product == null)
            {
                return NotFound();
            }
            return Ok(Product); 
        }
    }
}
