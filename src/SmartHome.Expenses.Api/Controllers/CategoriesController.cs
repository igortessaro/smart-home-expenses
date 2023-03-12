using Microsoft.AspNetCore.Mvc;
using SmartHome.Expenses.Domain.Repositories;

namespace SmartHome.Expenses.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class CategoriesController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _categoryRepository.GetAllAsync();
        return Ok(result);
    }
}