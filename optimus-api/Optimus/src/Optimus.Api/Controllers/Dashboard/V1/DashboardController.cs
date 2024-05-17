using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Optimus.Api.Controllers.Dashboard.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/dashboard")]
public sealed class DashboardController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<DashboardResponse>> Gerar(CancellationToken token = default)
    {
        return Ok();
    }
}
