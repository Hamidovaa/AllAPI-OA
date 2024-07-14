﻿using AllAPI.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryResponse
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public BrandDto Brand { get; set; }
    }
}
