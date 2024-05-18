using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optimus.Api.Configuration;
using Optimus.Api.Controllers.Customers.V1.Models;
using Optimus.Api.Shared;
using Optimus.Application.Features.Customers.GetAll;
using Optimus.Application.Features.Customers.GetById;
using Optimus.Application.Features.Customers.Remove;
using Optimus.Domain.Shared.Errors;

namespace Optimus.Api.Controllers.Customers.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/customers")]
public class CustomersController : OptimusBusControllerBase
{
    public CustomersController(ISender sender) : base(sender) { }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<CustomerListApiResponse>>> GetAll(CancellationToken token = default)
    {
        var customers = await MemoryBus.Send(new GetAllCustomersQuery(), token);
        var result = customers.Select(customer => CustomerListApiResponse.From(customer));

        return Ok(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CustomerApiResponse>> GetById(Guid id, CancellationToken token = default)
    {
        var query = new GetByIdCustomerQuery(id);

        var result = await MemoryBus.Send(query, token);

        return result.HasError<EntityNotFoundError>()
            ? NotFound()
            : Ok(CustomerApiResponse.From(result.Value));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] CreateCustomerRequest request, CancellationToken token = default)
    {
        var result = await MemoryBus.Send(request.ToCommand(), token);

        return result.IsFailed
            ? BadRequest(result.ToProblemDetails())
            : CreatedAtAction(nameof(GetById), new { id = result.Value }, request);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateCustomerRequest request, CancellationToken token = default)
    {
        var command = request.ToCommand() with { Id = id };

        var result = await MemoryBus.Send(command, token);

        if (result.HasError<EntityNotFoundError>())
        {
            return NotFound();
        }

        return result.IsFailed 
            ? BadRequest(result.ToProblemDetails())
            : NoContent();
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(Guid id, CancellationToken token = default)
    {
        var command = new RemoveCustomerCommand(id);

        var result = await MemoryBus.Send(command, token);

        return result.HasError<EntityNotFoundError>()
            ? NotFound()
            : NoContent();
    }
}
