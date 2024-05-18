namespace Optimus.Application.Features.Authentication;

public sealed record UserResponse(
    Guid Id,
    string Email,
    string Type);
