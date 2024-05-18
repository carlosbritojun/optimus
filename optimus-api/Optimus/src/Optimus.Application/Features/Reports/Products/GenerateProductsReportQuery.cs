using MediatR;

namespace Optimus.Application.Features.Reports.Products;

public sealed record GenerateProductsReportQuery: IRequest<IReadOnlyList<ProductReportResponse>>;