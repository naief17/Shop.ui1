using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.ProductAdmin;
using Shop.Database;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Shop.ui.Controllers
{
    [Route("[Controller]")]
    public class AdminController : Controller
    {
        public ApplicationDbContext _ctx;

        public AdminController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        [HttpGet("Products")]
        public IActionResult GetProducts() => Ok(new GetProductss(_ctx).Do());
        [HttpGet("Products/{Id}")]
        public IActionResult GetProduct(int Id) => Ok(new GetProduct(_ctx).Do(Id));
        [HttpPost("Products")]
        public IActionResult CreatProduct(CreatProduct.ProductViewModel vm) => Ok(new CreatProduct(_ctx).Do(vm));
        [HttpDelete("Products/{Id}")]
        public IActionResult DeleteProduct(int Id) => Ok(new DeleteProduct(_ctx).Do(Id));
        [HttpPut("Products")]
        public IActionResult UpdateProduct(CreatProduct.ProductViewModel vm) => Ok(new CreatProduct(_ctx).Do(vm));
    }
}

