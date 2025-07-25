﻿using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Data.DataOrEntity
{
    public class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }
    }
}