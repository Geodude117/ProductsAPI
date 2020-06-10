using MediatR;
using ProductsAPI.DatabaseContext;
using ProductsAPI.Models;
using ProductsAPI.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProductsAPI.Handlers
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Product>
    {

        private readonly ProductsContext _context;
        public GetProductByIdHandler(ProductsContext context)
        {
            _context = context;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product =  await _context.Products.FindAsync(request.Id);

            return product ?? null;

        }
    }
}
