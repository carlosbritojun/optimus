using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Optimus.Api.Shared;

public abstract class OptimusBusControllerBase : ControllerBase
{
    protected OptimusBusControllerBase(ISender sender)
    {
        MemoryBus = sender;
    }

    protected ISender MemoryBus { get; }
}
