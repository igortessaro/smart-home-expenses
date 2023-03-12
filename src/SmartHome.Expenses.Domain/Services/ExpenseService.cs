using AutoMapper;
using Microsoft.Extensions.Logging;
using SmartHome.Expenses.Domain.Commands;
using SmartHome.Expenses.Domain.Entities;
using SmartHome.Expenses.Domain.Repositories;
using SmartHome.Expenses.Domain.Services.Abstractions;

namespace SmartHome.Expenses.Domain.Services;

public sealed class ExpenseService : IExpenseService
{
    private readonly ILogger<ExpenseService> _logger;
    private readonly IMapper _mapper;
    private readonly IExpenseRepository _expenseRepository;
    private readonly ICategoryRepository _categoryRepository;

    public ExpenseService(ILogger<ExpenseService> logger, IMapper mapper, IExpenseRepository expenseRepository, ICategoryRepository categoryRepository)
    {
        _logger = logger;
        _mapper = mapper;
        _expenseRepository = expenseRepository;
        _categoryRepository = categoryRepository;
    }

    public async Task<Notification> Create(CreateExpenseCommand command)
    {
        if (command == null)
        {
            throw new ArgumentNullException(nameof(command));
        }

        var category = _categoryRepository.GetByCode(command.CategoryCode);
        command.CategoryId = category.Id;
        var entity = _mapper.Map<Expense>(command);
        var result = await _expenseRepository.InsertAsync(entity);

        return result > 0 ? new Notification("success") : new Notification(null, "error-message");
    }
}