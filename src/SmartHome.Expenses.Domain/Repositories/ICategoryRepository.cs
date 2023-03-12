using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;

namespace SmartHome.Expenses.Domain.Repositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    CategoryIdDto GetByCode(string code);
    Task<IReadOnlyCollection<CategorySummaryDto>> GetAllAsync();
}