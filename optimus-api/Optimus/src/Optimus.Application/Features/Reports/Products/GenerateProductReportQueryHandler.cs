using Dapper;
using MediatR;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Optimus.Application.Features.Reports.Products;

internal sealed class GenerateProductReportQueryHandler : IRequestHandler<GenerateProductsReportQuery, IReadOnlyList<ProductReportResponse>>
{
    public GenerateProductReportQueryHandler(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("Database") ?? throw new ArgumentNullException(nameof(configuration));
    }

    private readonly string _connectionString;

    public async Task<IReadOnlyList<ProductReportResponse>> Handle(GenerateProductsReportQuery request, CancellationToken token = default)
    {
        using var connection = new NpgsqlConnection(_connectionString);
        await connection.OpenAsync(token);

        const string sql = """
                 SELECT
                    p.id AS Id,
                    p.name AS Name,
                    p.quantity_in_stock AS QuantityInStock,
                    p.cost_price AS CostPrice,
                    p.sale_price AS SalePrice
                 FROM products p
                 ORDER BY
                    p.name
            """;

        var products = await connection.QueryAsync<ProductReportResponse>(sql, token);

        return products.ToList();
    }
}
