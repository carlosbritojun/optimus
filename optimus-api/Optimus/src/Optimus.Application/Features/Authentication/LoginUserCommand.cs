using FluentResults;
using MediatR;

namespace Optimus.Application.Features.Authentication;

public sealed record LoginUserCommand(string Email, string Password) : IRequest<Result<UserResponse>>;
