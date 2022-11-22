using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    readonly IUnitOfWork _userService;

    public UserController(IUnitOfWork userService)
    {
        _userService = userService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(){
        var users = await _userService.Users.All();
        var userViewModels = users.Select(u => u.ToViewModel());
        return Ok(userViewModels);
    }
    
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id){
        var user = await _userService.Users.GetById(id);
        return Ok(user.ToViewModel());
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] UserViewModel userViewModel){
        var user = userViewModel.ToModel();
        await _userService.Users.Add(user);
        return CreatedAtAction(nameof(Get), new { id = user.UserId }, user.ToViewModel());
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] UserViewModel userViewModel){
        var user = await _userService.Users.GetById(id);
        userViewModel.UpdateModel(user);
        await _userService.Users.Upsert(user);
        return NoContent();
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id){
        var user = await _userService.Users.GetById(id);
        await _userService.Users.Delete(id);
        return NoContent();
    }
}