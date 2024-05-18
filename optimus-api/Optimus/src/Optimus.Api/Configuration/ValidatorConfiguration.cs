using Caelum.Stella.CSharp.Validation;
using FluentValidation;
using FluentValidation.AspNetCore;
using V1 = Optimus.Api.Controllers.Customers.V1;

namespace Optimus.Api.Configuration;

public static class ValidatorConfiguration
{
    public static IServiceCollection AddValidators(this IServiceCollection services)
    {
        AddV1Validators(services);
        services.AddFluentValidationAutoValidation();

        return services;
    }

    private static IServiceCollection AddV1Validators(this IServiceCollection services)
    {
        services.AddValidatorsFromAssemblyContaining<V1.Validatons.CreateCustomerRequestValidator>();
        return services;
    }

    public static IRuleBuilderOptions<T, string> Cpf<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.Must(cpf => new CPFValidator().IsValid(cpf));
    }
}
