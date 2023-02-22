using Microsoft.Extensions.DependencyInjection;
using SmartHome.Expenses.Infrastructure.Profiles;

namespace SmartHome.Expenses.Infrastructure.CrossCutting.IoC;

public static class AutoMapperServiceColletionExtensions
{
    public static IServiceCollection AddInfrastructureAutoMapper(this IServiceCollection services)
    {
        _ = services.AddAutoMapper(x => x.AddProfile<UserProfile>());

        return services;
    }
}