using MediatR;
using ProductsAPI.Commands;
using ProductsAPI.DatabaseContext;
using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsAPI.Handlers
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Product>
    {
        private readonly ProductsContext _context;
        public CreateProductHandler(ProductsContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product product = new Product
            {
                ProductName = request.ProductName,
                Quantity = request.Quantity,
                Price = request.Price
            };

            _context.Products.Add(product);
            await _context.SaveChangesAsync();

            return product;

        }
    }
}
