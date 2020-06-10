using MediatR;
using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Commands
{ 
    public class CreateProductCommand  : IRequest<Product>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Price { get; set; }

    }
}
