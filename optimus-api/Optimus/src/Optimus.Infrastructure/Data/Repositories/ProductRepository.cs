using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Products;
using Optimus.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optimus.Infrastructure.Data.Repositories;

public sealed class ProductRepository : IProductRepository
{
    public ProductRepository(OptimusDbContext context)
    {
        _context = context;
    }

    private OptimusDbContext _context;

    public async Task AddAsync(Product product, CancellationToken token = default)
    {
        await _context.Set<Product>().AddAsync(product, token);
    }

    public async Task<bool> NameExistsAsync(Name name, CancellationToken token = default)
    {
        return await _context
            .Set<Product>()
            .AnyAsync(product => product.Name == name, token);
    }
}
