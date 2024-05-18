using FluentResults;
using MediatR;
using Optimus.Domain.Entities.Users;
using Optimus.Domain.Shared;

namespace Optimus.Application.Features.Authentication;

internal sealed class LoginUserCommandHandler : IRequestHandler<LoginUserCommand, Result<UserResponse>>
{
    public LoginUserCommandHandler(IUserRepository repository)
    {
        _repository = repository;
    }

    private readonly IUserRepository _repository;

    public async Task<Result<UserResponse>> Handle(LoginUserCommand request, CancellationToken token = default)
    {
        var email = new Email(request.Email);

        var user = await _repository.GetByEmailAsync(email, token);

        if (user is null)
        {
            return Result.Fail(UserErrors.NotFound);
        }

        if (!user.CheckPassword(request.Password))
        {
            return Result.Fail(UserErrors.Password);
        }

        return Result.Ok(new UserResponse(
            user.Id,
            user.Email.Address));
    }
}
