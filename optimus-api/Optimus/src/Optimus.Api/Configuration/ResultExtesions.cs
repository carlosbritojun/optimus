using FluentResults;
using Microsoft.AspNetCore.Mvc;

namespace Optimus.Api.Configuration;

public static class ResultExtensions
{
    public static ProblemDetails ToProblemDetails(this Result result)
    {
        var problemDetails = new ProblemDetails
        {
            Title = "One or more validation errors occurred.",
            Status = 400,
            Detail = "See the errors property for details.",
            Instance = Guid.NewGuid().ToString()
        };

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
        var problemDetails = new ProblemDetails
        {
            Type = "https://tools.ietf.org/html/rfc9110#section-15.5.1",
            Title = "One or more validation errors occurred.",
            Status = 400,
            Detail = "See the errors property for details.",
            
        };

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
}