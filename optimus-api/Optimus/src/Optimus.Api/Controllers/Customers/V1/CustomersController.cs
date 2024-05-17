using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace Optimus.Api.Controllers.Customers.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/customers")]
public class CustomersController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<CustomerListResponse>>> GetAll(CancellationToken token = default)
    {
        return Ok();
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CustomerResponse>> GetById(Guid id, CancellationToken token = default)
    {
        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] object request, CancellationToken token = default)
    {
        return CreatedAtAction(nameof(GetById), new { id = Guid.NewGuid() }, request);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(Guid id, [FromBody] object request, CancellationToken token = default)
    {
        return NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken token = default)
    {
        return NoContent();
    }
}
