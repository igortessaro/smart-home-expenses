using AutoMapper;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;

namespace SmartHome.Expenses.Infrastructure.Profiles;

public sealed class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserSummaryDto>();
    }
}