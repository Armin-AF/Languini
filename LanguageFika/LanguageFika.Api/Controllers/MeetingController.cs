using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MeetingController : ControllerBase
{
    readonly IMeetingService _meetingService;
    
    public MeetingController(IMeetingService meetingService)
    {
        _meetingService = meetingService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var meetings = await _meetingService.All();
        var meetingViewModels = meetings.Where(x=> x.Date > DateTime.Now).Select(m => m.ToViewModel());
        return Ok(meetingViewModels);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var meeting = await _meetingService.GetById(id);
        return Ok(meeting.ToViewModel());
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] MeetingViewModel meetingViewModel)
    {
        meetingViewModel.MeetingId = Guid.NewGuid();
        if (meetingViewModel.Date < DateTime.Now)
        {
            return BadRequest("Meeting date must be in the future");
        }
        var meeting = meetingViewModel.ToModel();
        await _meetingService.Add(meeting);
        return Ok(meeting.ToViewModel());
    }
    
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> Put(Guid id, [FromBody] MeetingViewModel meetingViewModel)
    {
        if (meetingViewModel.Date < DateTime.Now)
        {
            return BadRequest("Meeting date must be in the future");
        }
        var meeting = meetingViewModel.ToModel();
        await _meetingService.Upsert(meeting);
        return Ok(meeting.ToViewModel());
    }
    
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        await _meetingService.Delete(id);
        return Ok();
    }
    
}