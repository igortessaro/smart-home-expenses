using AutoMapper;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;
using SmartHome.Expenses.Domain.Repositories;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational;

public sealed class ExpenseRepository : BaseRepository<Expense>, IExpenseRepository
{
    public ExpenseRepository(SmartHomeContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public async Task<IReadOnlyCollection<ExpenseSummaryDto>> GetAllAsync()
    {
        var result = await this.GetAllAsync<ExpenseSummaryDto>();

        return result;
    }
}