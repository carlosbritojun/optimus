using MediatR;
using Microsoft.EntityFrameworkCore;
using Optimus.Domain.Entities.Customers;
using Optimus.Infrastructure.Data;

namespace Optimus.Application.Features.Customers.GetAll;

internal sealed class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IReadOnlyList<CustomerListResponse>>
{
    private readonly OptimusDbContext _context;

    public GetAllCustomersQueryHandler(OptimusDbContext context)
    {
        _context = context;
    }

    public async Task<IReadOnlyList<CustomerListResponse>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
    {
        return await _context.Set<Customer>()
            .AsNoTracking()
            .OrderBy(customer => customer.Name)
            .Select(customer => new CustomerListResponse(
                customer.Id,
                customer.Name.Value,
                customer.Email.Address))
            .ToListAsync();
    }
}
