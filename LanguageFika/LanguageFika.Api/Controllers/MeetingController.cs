using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingController : ControllerBase
    {
        readonly IMapper _mapper;
        readonly IMeetingService _meetingService;
        
        public MeetingController(IMapper mapper, IMeetingService meetingService)
        {
            _mapper = mapper;
            _meetingService = meetingService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var meetings = await _meetingService.GetMeetingsAsync();
            var meetingViewModels = _mapper.Map<IEnumerable<MeetingViewModel>>(meetings);
            return Ok(meetingViewModels);
        }
        
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MeetingViewModel meeting)
        {
            var meetingModel = _mapper.Map<Meeting>(meeting);
            await _meetingService.PostMeetingAsync(meetingModel);
            return Ok();
        }
    }
}
