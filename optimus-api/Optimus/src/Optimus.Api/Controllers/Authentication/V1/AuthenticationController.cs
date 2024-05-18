using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optimus.Api.Configuration;
using Optimus.Api.Shared;

namespace Optimus.Api.Controllers.Authentication.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/auth")]
public class AuthenticationController : OptimusBusControllerBase
{
    public AuthenticationController(ISender sender) : base(sender)
    {
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GenerateToken([FromBody] LoginUserRequest request, CancellationToken token = default)
    {
        var response = await MemoryBus.Send(request.ToCommand(), token);

        return response.IsFailed
            ? BadRequest(response.ToProblemDetails())
            : Ok(UserApiResponse.From(response.Value));
    }
}
