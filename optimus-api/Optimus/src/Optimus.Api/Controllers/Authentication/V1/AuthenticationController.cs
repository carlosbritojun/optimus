using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Optimus.Api.Controllers.Authentication.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/auth")]
public class AuthenticationController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GenerateToken([FromBody] object request, CancellationToken token = default)
    {
        return Ok();
    }
}
