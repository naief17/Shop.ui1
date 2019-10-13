﻿using Shop.Database;
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.ProductAdmin
{
    public class CreatProduct
    {
       public ApplicationDbContext _context;

        public CreatProduct(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task Do(ProductViewModel vm)
        {
            _context.Products.Add(new Product
            {

                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value,
            });
            await _context.SaveChangesAsync();
        }

        public class ProductViewModel
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public decimal Value { get; set; }


        }
    }
} 
    
