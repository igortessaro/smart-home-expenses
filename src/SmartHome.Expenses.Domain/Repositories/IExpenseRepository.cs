using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;

namespace SmartHome.Expenses.Domain.Repositories;

public interface IExpenseRepository
{
    Task<IReadOnlyCollection<ExpenseSummaryDto>> GetAllAsync();
    Task<int> InsertAsync(Expense entity);
}