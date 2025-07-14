﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Services.Model_View
{
    public class UpdateProductVM
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? Description { get; set; }

        public int StockQuantity { get; set; }

        public List<int> ProductTypeIds { get; set; } = new List<int>();

        public decimal? Discount { get; set; }
    }
}