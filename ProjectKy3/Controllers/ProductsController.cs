using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectKy3.Data;
using ProjectKy3.Models;

namespace ProjectKy3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize] // Bảo vệ tất cả các hành động trong controller này
    public class ProductsController : ControllerBase
    {
        private readonly ShopRunnerDbContext _context;

        public ProductsController(ShopRunnerDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous] // Mở rộng cho phép truy cập không cần đăng nhập với phương thức này
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await _context.Products.Include(p => p.Category).ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await _context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct([FromBody] Product newProduct)
        {
            _context.Products.Add(newProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProduct), new { id = newProduct.Id }, newProduct);
        }
    }
}
