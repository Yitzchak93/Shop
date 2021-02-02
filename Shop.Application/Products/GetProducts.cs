﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shop.Database;

namespace Shop.Application.GetProducts
{
    public class GetProducts
    {
        private ApplicationDbContext _ctx;

        public GetProducts(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<ProductViewModel> Do() =>
            _ctx.Products.ToList().Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = $"${ x.Value.ToString("N2")}" // 1,100.50  => 1,100.50 => $ 1,100.50
            });

    }
    public class ProductViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }

}
