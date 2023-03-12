using AutoMapper;
using SmartHome.Expenses.Domain.Commands;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Queries;

namespace SmartHome.Expenses.Infrastructure.Profiles;

public sealed class ExpenseProfile: Profile
{
    public ExpenseProfile()
    {
        CreateMap<Expense, ExpenseSummaryDto>()
            .ForMember(
            dest => dest.CreateBy,
            opt => opt.MapFrom(src => $"{src.CreateByUser.Name} {src.CreateByUser.Surname}")
            )
            .ForMember(
                dest => dest.Category,
                opt => opt.MapFrom(src => src.Category.Name)
            );
        CreateMap<CreateExpenseCommand, Expense>();
    }
}