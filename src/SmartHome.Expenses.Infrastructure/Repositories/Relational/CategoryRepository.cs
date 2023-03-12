using AutoMapper;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;
using SmartHome.Expenses.Domain.Repositories;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational;

public sealed class CategoryRepository : BaseRepository<Category>, ICategoryRepository
{
    public CategoryRepository(SmartHomeContext context, IMapper mapper) : base(context, mapper)
    {
    }

    public CategoryIdDto GetByCode(string code)
    {
        return this.Query<CategoryIdDto>(x => code.Equals(x.Code)).First();
    }

    public async Task<IReadOnlyCollection<CategorySummaryDto>> GetAllAsync()
    {
        var result = await this.GetAllAsync<CategorySummaryDto>();

        return result;
    }
}