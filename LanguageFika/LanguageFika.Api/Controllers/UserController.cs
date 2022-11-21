using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    readonly ILogger<UserController> _logger;
    readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(){
        var users = await _userService.All();
        var userViewModels = users.Select(u => u.ToViewModel());
        return Ok(userViewModels);
    }

}