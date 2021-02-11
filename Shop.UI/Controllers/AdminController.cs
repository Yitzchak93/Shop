using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductsAdmin;
using Shop.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.UI.Controllers
{
    [Route("[controller]")]
    public class AdminController : Controller
    {
        private ApplicationDbContext _ctx;

        public AdminController(Database.ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        // Get all products
        [HttpGet("products")]
        public IActionResult GetProducts() => Ok(new GetProducts(_ctx).Do());

        // Get a single product
        [HttpGet("products/{id}")]
        public IActionResult GetProduct(int id) => Ok(new GetProduct(_ctx).Do(id));


        // Create a new product
        [HttpPost("products")]
        public async Task<IActionResult> CreateProducts([FromBody] CreateProduct.Request request) => Ok((await new CreateProduct(_ctx).Do(request)));

        // Delelte a product
        [HttpDelete("products/{id}")]
        public async Task<IActionResult> DeleteProduct(int id) => Ok((await new DeleteProduct(_ctx).Do(id)));

        // Modify a product
        [HttpPut("products")]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProduct.Request request) => Ok((await new UpdateProduct(_ctx).Do(request)));
    }
}
