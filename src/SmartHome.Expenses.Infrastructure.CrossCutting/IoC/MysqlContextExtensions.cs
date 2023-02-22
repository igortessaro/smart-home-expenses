using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SmartHome.Expenses.Infrastructure.Repositories.Relational;

namespace SmartHome.Expenses.Infrastructure.CrossCutting.IoC;

public static class MysqlContextExtensions
{
    public static IServiceCollection AddMysqlDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SmartHomeDb");

        _ = services.AddDbContext<SmartHomeContext>(options =>
        {
            _ = options.UseMySql(connectionString, serverVersion: ServerVersion.AutoDetect(connectionString));
        });

        return services;
    }
}