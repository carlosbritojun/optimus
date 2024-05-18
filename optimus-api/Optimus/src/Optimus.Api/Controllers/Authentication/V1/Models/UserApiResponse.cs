using Optimus.Application.Features.Authentication;

namespace Optimus.Api.Controllers.Authentication.V1.Models;

public sealed record UserApiResponse(
    Guid Id,
    string Email,
    string Type)
{
    public static UserApiResponse From(UserResponse response) => new UserApiResponse(
        response.Id,
        response.Email,
        response.Type);
}
