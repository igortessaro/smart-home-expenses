using Microsoft.AspNetCore.Mvc;
using SmartHome.Expenses.Domain.Commands;
using SmartHome.Expenses.Domain.Repositories;
using SmartHome.Expenses.Domain.Services.Abstractions;

namespace SmartHome.Expenses.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ExpensesController : ControllerBase
{
    private readonly ILogger<ExpensesController> _logger;
    private readonly IExpenseRepository _expenseRepository;
    private readonly IExpenseService _expenseService;

    public ExpensesController(ILogger<ExpensesController> logger, IExpenseRepository expenseRepository, IExpenseService expenseService)
    {
        _expenseRepository = expenseRepository;
        _expenseService = expenseService;
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _expenseRepository.GetAllAsync();
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] CreateExpenseCommand command)
    {
        var result = await _expenseService.Create(command);
        return Ok(result);
    }
}