using System.Collections.ObjectModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;
using SmartHome.Expenses.Domain.Repositories;

namespace SmartHome.Expenses.Infrastructure.Repositories.Relational;

public sealed class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(SmartHomeContext context, IMapper mapper) : base(context, mapper)
    {
    }
    
    public async Task<IReadOnlyCollection<UserSummaryDto>> GetAllAsync()
    {
        var result = await this.GetAllAsync<UserSummaryDto>();

        return result;
    }
    
}