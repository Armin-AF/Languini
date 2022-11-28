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
            var participants = _context.ParticipantsModel!.ToList();
            return Ok(participants);
        }
        
        [HttpGet("{meetingId:guid}")]
        public IActionResult Get(Guid meetingId)
        {
            var participants = _context.ParticipantsModel!.Where(x => x.MeetingId == meetingId).ToList();
            return Ok(participants);
        }
        
        [HttpPost]
        public IActionResult Post([FromBody] Participant participant)
        {
            if (_context.ParticipantsModel!.Any(x => x.MeetingId == participant.MeetingId && x.ParticipantEmail == participant.ParticipantEmail))
            {
                return BadRequest("Participant already exists");
            }
            _context.ParticipantsModel!.Add(participant);
            _context.SaveChanges();
            return Ok(participant);
        }
        
        [HttpDelete]
        public IActionResult Delete(string participantEmail, Guid meetingId)
        {
            var participant = _context.ParticipantsModel!.FirstOrDefault(x => x.MeetingId == meetingId && x.ParticipantEmail == participantEmail);
            if (participant == null)
            {
                return BadRequest("Participant does not exist");
            }
            _context.ParticipantsModel!.Remove(participant);
            _context.SaveChanges();
            return Ok(participant);
        }
    }
}
