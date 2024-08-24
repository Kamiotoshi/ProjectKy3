using Microsoft.AspNetCore.Mvc;
using ProjectKy3.Models;

namespace ProjectKy3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private static List<Category> categories = new List<Category>
        {
            new Category { Id = 1, Name = "Shoes", Description = "All types of shoes" },
            new Category { Id = 2, Name = "Apparel", Description = "Clothing and accessories" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public ActionResult<Category> GetCategory(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]
        public ActionResult<Category> CreateCategory([FromBody] Category newCategory)
        {
            newCategory.Id = categories.Count + 1;
            categories.Add(newCategory);
            return CreatedAtAction(nameof(GetCategory), new { id = newCategory.Id }, newCategory);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, [FromBody] Category updatedCategory)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            category.Name = updatedCategory.Name;
            category.Description = updatedCategory.Description;

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            categories.Remove(category);

            return NoContent();
        }
    }
}
