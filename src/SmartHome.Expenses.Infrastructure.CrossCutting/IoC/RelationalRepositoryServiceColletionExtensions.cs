using Microsoft.Extensions.DependencyInjection;
using SmartHome.Expenses.Domain.Repositories;
using SmartHome.Expenses.Infrastructure.Repositories.Relational;

namespace SmartHome.Expenses.Infrastructure.CrossCutting.IoC;

public static class RelationalRepositoryServiceColletionExtensions
{
    public static IServiceCollection AddRelationalRepository(this IServiceCollection services)
    {
        _ = services.AddScoped<IUserRepository, UserRepository>();

        return services;
    }
}