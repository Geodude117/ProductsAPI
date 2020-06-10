using System;
using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Price { get; set; }
    }
}
