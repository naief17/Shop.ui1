using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Shop.Application.Products;
using Shop.Database;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Shop.Application.ProductAdmin;

namespace Shop.ui.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _ctx;

        public IndexModel(ApplicationDbContext ctx)
        {

            _ctx = ctx;
        }

        [BindProperty]
        public CreatProduct.ProductViewModel Product { get; set; }
        public IEnumerable<GetProducts.ProductViewModel> Products { get; set; }
        public void OnGet()
        {
            Products = new GetProducts(_ctx).Do();
        }
        public async Task<IActionResult> OnPost()
        {
            // await new CreatProduct(_ctx).Do(Product);
            return RedirectToPage("index");
        }
    }
}
       