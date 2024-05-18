using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optimus.Api.Shared;
using Optimus.Application.Features.Dashboard;

namespace Optimus.Api.Controllers.Dashboard.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/dashboard")]
public sealed class DashboardController : OptimusBusControllerBase
{
    public DashboardController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<DashboardResponse>> Generate(CancellationToken token = default)
    {
        var query = new GenerateDashboardQuery();
        var dashboard = await MemoryBus.Send(query, token);

        return Ok(dashboard);
    }
}
