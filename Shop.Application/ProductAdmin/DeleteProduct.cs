using Shop.Database;
using Shop.Domain.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class DeleteProduct
    {
       public ApplicationDbContext _context;

        public DeleteProduct(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task Do(int Id)
        {
            var Product = _context.Products.FirstOrDefault(x => x.Id == Id);
            _context.Products.Remove(Product);
            await _context.SaveChangesAsync();
        }
    }
} 
    
