using Microsoft.Extensions.DependencyInjection;
using SmartHome.Expenses.Infrastructure.Profiles;

namespace SmartHome.Expenses.Infrastructure.CrossCutting.IoC;

public static class AutoMapperServiceColletionExtensions
{
    public static IServiceCollection AddInfrastructureAutoMapper(this IServiceCollection services)
    {
        _ = services.AddAutoMapper(x => x.AddProfile<UserProfile>());
        _ = services.AddAutoMapper(x => x.AddProfile<CategoryProfile>());
        _ = services.AddAutoMapper(x => x.AddProfile<ExpenseProfile>());

        return services;
    }
}