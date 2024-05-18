using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optimus.Api.Controllers.Reports.V1.Models;
using Optimus.Api.Shared;
using Optimus.Application.Features.Reports.Products;

namespace Optimus.Api.Controllers.Reports.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/reports")]
public sealed class ReportsController : OptimusBusControllerBase
{
    public ReportsController(ISender sender) : base(sender)
    {
    }

    [HttpGet("products")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Products(CancellationToken token = default)
    {
        var query = new GenerateProductsReportQuery();
        var report = await MemoryBus.Send(query, token);
        var result = report.Select(product => ProductReportApiReponse.From(product));

        return Ok(result);
    }
}
