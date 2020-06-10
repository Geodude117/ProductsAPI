using MediatR;
using Microsoft.EntityFrameworkCore;
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
    public class GetAllProductsHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly ProductsContext _context;
        public GetAllProductsHandler(ProductsContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.ToListAsync();
        }
    }
}
