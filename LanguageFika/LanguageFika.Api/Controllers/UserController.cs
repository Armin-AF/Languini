using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(){
        var users = await _userService.All();
        var userViewModels = users.Select(u => u.ToViewModel());
        return Ok(userViewModels);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id){
        var user = await _userService.GetById(id);
        return Ok(user.ToViewModel());
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] UserViewModel userViewModel){
        var user = userViewModel.ToModel();
        await _userService.Add(user);
        return CreatedAtAction(nameof(Get), new { id = user.UserId }, user.ToViewModel());
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] UserViewModel userViewModel){
        var user = await _userService.GetById(id);
        userViewModel.UpdateModel(user);
        await _userService.Upsert(user);
        return NoContent();
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id){
        var user = await _userService.GetById(id);
        await _userService.Delete(id);
        return NoContent();
    }
}