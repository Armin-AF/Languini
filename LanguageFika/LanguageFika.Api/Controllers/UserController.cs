using AutoMapper;
using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    readonly IMapper _mapper;
    readonly IUserService _userService;
    
    public UserController(IMapper mapper, IUserService userService)
    {
        _mapper = mapper;
        _userService = userService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(){
        var users = await _userService.GetUsersAsync();
        var usersDto = _mapper.Map<IEnumerable<UserViewModel>>(users);
        return Ok(usersDto);
    }
    
}