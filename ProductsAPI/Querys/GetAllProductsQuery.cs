using MediatR;
using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Querys
{
    public class GetAllProductsQuery : IRequest <List<Product>>
    {
    }
}
