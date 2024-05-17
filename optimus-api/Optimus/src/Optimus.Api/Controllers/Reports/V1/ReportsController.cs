using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Optimus.Api.Controllers.Reports.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/reports")]
public sealed class ReportsController : ControllerBase
{
    [HttpGet("products")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> Products(CancellationToken token = default)
    {
        return Ok();
    }
}
