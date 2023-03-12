using SmartHome.Expenses.Domain.Commands;

namespace SmartHome.Expenses.Domain.Services.Abstractions;

public interface IExpenseService
{
    Task<Notification> Create(CreateExpenseCommand command);
}