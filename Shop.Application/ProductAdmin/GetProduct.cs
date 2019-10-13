﻿using Shop.Database;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Application.ProductAdmin
{
    public class GetProduct
    {
        public ApplicationDbContext _ctx;
        public GetProduct(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public ProductViewModel Do(int Id) =>
            _ctx.Products.Where(x => x.Id == Id).Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value,

            })
            .FirstOrDefault();
        public class ProductViewModel
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public decimal Value { get; set; }
        }
    }
}

