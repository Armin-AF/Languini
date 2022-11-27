using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFika.Api.Context;
using LanguageFika.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFika.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        readonly AppDbContext _context;
        
        public ParticipantController(AppDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            var participants = _context.Participants!.ToList();
            return Ok(participants);
        }
        
        [HttpGet("{meetingId:guid}")]
        public IActionResult Get(Guid meetingId)
        {
            var participants = _context.Participants!.Where(x => x.MeetingId == meetingId).ToList();
            return Ok(participants);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Participant participant)
        {
            _context.Participants!.Add(participant);
            _context.SaveChanges();
            return Ok(participant);
        }
        
        [HttpDelete("ParticipantId")]
        public IActionResult Delete(string participantId)
        {
            var participant = _context.Participants!.FirstOrDefault(x => x.ParticipantId == participantId);
            if (participant == null)
            {
                return NotFound();
            }
            _context.Participants!.Remove(participant);
            _context.SaveChanges();
            return Ok();
        }
    }
}
