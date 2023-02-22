using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;

namespace SmartHome.Expenses.Domain.Repositories;

public interface IUserRepository : IBaseRepository<User>
{
    Task<IReadOnlyCollection<UserSummaryDto>> GetAllAsync();
}