﻿using Asp.Versioning;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Optimus.Api.Configuration;
using Optimus.Api.Controllers.Products.V1.Models;
using Optimus.Api.Shared;
using Optimus.Application.Features.Products.GetAll;
using Optimus.Application.Features.Products.GetById;
using Optimus.Application.Features.Products.Remove;
using Optimus.Domain.Shared.Errors;

namespace Optimus.Api.Controllers.Products.V1;

[ApiVersion("1.0")]
[ApiController]
[Route("api/v{version:apiVersion}/products")]
public class ProductsController : OptimusBusControllerBase
{
    public ProductsController(ISender sender) : base(sender)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<ProductListApiResponse>>> GetAll(CancellationToken token = default)
    {
        var products = await MemoryBus.Send(new GetAllProductsQuery(), token);
        var result = products.Select(product => ProductListApiResponse.From(product));

        return Ok(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<ProductApiResponse>> GetById(Guid id, CancellationToken token = default)
    {
        var query = new GetByIdProductQuery(id);

        var result = await MemoryBus.Send(query, token);

        return result.HasError<EntityNotFoundError>()
            ? NotFound()
            : Ok(ProductApiResponse.From(result.Value));
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Add([FromBody] CreateProductRequest request, CancellationToken token = default)
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
    public async Task<IActionResult> Update(Guid id, [FromBody] UpdateProductRequest request, CancellationToken token = default)
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
        var command = new RemoveProductCommand(id);

        var result = await MemoryBus.Send(command, token);

        return result.HasError<EntityNotFoundError>()
            ? NotFound()
            : NoContent();
    }
}
