using FluentResults;
using Microsoft.AspNetCore.Mvc;
using Optimus.Domain.Shared;
using static Optimus.Api.Middlewares.ExceptionHandlingMiddleware;

namespace Optimus.Api.Configuration;

public static class ResultExtensions
{
    public static ProblemDetails ToProblemDetails(this Result result)
    {
        var problemDetails = BuildDefaultProblemDetails();

        foreach (var error in result.Errors)
        {
            if (problemDetails.Extensions.ContainsKey("errors"))
            {
                ((List<string>)problemDetails.Extensions["errors"]).Add(error.Message);
            }
            else
            {
                problemDetails.Extensions["errors"] = new List<string> { error.Message };
            }
        }

        return problemDetails;
    }

    public static ProblemDetails ToProblemDetails<T>(this Result<T> result)
    {
        var problemDetails = BuildDefaultProblemDetails();

        foreach (var error in result.Errors)
        {
            if (problemDetails.Extensions.ContainsKey("errors"))
            {
                ((List<string>)problemDetails.Extensions["errors"]).Add(error.Message);
            }
            else
            {
                problemDetails.Extensions["errors"] = new List<string> { error.Message };
            }
        }

        return problemDetails;
    }

    private static ProblemDetails BuildDefaultProblemDetails()
    {
        return new ProblemDetails
        {
            Status = 400,
            Type = "A flow validation has occurred",
            Title = "One or more validation errors occurred.",
            Detail = "See the errors property for details.",
        };
    }
}