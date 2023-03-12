using Microsoft.AspNetCore.Mvc;
using SmartHome.Expenses.Domain.Queries;
using SmartHome.Expenses.Domain.Repositories;

namespace SmartHome.Expenses.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UsersController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        var result = await _userRepository.GetAllAsync();
        return Ok(result);
    }
}