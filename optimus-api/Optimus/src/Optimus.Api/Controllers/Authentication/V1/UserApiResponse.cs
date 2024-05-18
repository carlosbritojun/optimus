using Optimus.Application.Features.Authentication;

namespace Optimus.Api.Controllers.Authentication.V1;

public sealed record UserApiResponse(
    Guid Id, 
    string Email)
{
    public static UserApiResponse From(UserResponse response) => new UserApiResponse(
        response.Id,
        response.Email);
}
