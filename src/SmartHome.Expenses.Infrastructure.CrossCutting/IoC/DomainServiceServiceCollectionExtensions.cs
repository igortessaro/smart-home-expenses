using Microsoft.Extensions.DependencyInjection;
using SmartHome.Expenses.Domain.Services;
using SmartHome.Expenses.Domain.Services.Abstractions;

namespace SmartHome.Expenses.Infrastructure.CrossCutting.IoC;

public static class DomainServiceServiceCollectionExtensions
{
    public static IServiceCollection AddDomainService(this IServiceCollection services)
    {
        _ = services.AddScoped<IExpenseService, ExpenseService>();

        return services;
    }
}