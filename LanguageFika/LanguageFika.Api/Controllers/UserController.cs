using AutoMapper;
using LanguageFika.Api.Models;
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
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id){
        var user = await _userService.GetUserAsync(id);
        var userDto = _mapper.Map<UserViewModel>(user);
        return Ok(userDto);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] UserViewModel userDto){
        var user = _mapper.Map<User>(userDto);
        await _userService.CreateUserAsync(user);
        return Ok();
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] UserViewModel userDto){
        var user = _mapper.Map<User>(userDto);
        await _userService.UpdateUserAsync(id, user);
        return Ok();
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id){
        await _userService.DeleteUserAsync(id);
        return Ok();
    }
    
}