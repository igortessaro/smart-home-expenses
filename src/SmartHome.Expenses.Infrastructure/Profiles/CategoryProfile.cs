using AutoMapper;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;

namespace SmartHome.Expenses.Infrastructure.Profiles;

public sealed class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategorySummaryDto>();
        CreateMap<Category, CategoryIdDto>();
    }
}