using FluentAssertions;
using LanguageFika.Api;
using LanguageFika.Api.Controllers;
using LanguageFika.Api.Models;
using LanguageFika.Api.Models.ViewModels;
using LanguageFika.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace FikaTests;

public class MeetingControllerTests
{

    MeetingController _meetingController;
    Mock<IMeetingService> _meetingServiceMock;

    public MeetingControllerTests(){
        _meetingServiceMock = new Mock<IMeetingService>();
        _meetingController = new MeetingController(_meetingServiceMock.Object);
    }


    [Fact]
    public async Task GetMeetingById_ReturnsOkObjectResult(){
        // Arrange
        var meetingId = new Guid();
        var meeting = new Meeting{
            Id = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now + TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        _meetingServiceMock.Setup(x => x.GetById(meetingId)).ReturnsAsync(meeting);

        // Act
        var result = await _meetingController.Get(meetingId);

        // Assert
        Assert.IsType<OkObjectResult>(result);
    }
    
    [Fact]
    public async Task GetAllMeetings_ReturnsOkObjectResult(){
        // Arrange
        var meetingId = new Guid();
        var meeting = new Meeting{
            Id = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now + TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        var meetings = new List<Meeting> {meeting};
        _meetingServiceMock.Setup(x => x.All()).ReturnsAsync(meetings);

        // Act
        var result = await _meetingController.Get();

        // Assert
        Assert.IsType<OkObjectResult>(result);
    }


    [Fact]
    public async Task GetMeetingById_ReturnsCorrectMeeting()
    {
        // Arrange
        var meetingId = new Guid();
        var meeting = new MeetingViewModel()
        {
            MeetingId = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now + TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        _meetingServiceMock.Setup(x => x.GetById(meetingId)).ReturnsAsync(meeting.ToMeetingModel());
    
        // Act
        var result = await _meetingController.Get(meetingId);
    
        // Assert
        Assert.IsType<OkObjectResult>(result);
        var okResult = result as OkObjectResult;
        meeting.Should().BeEquivalentTo(okResult!.Value);
    }
    
    [Fact]
    public async Task PutMeeting_ReturnsNoContentResult()
    {
        // Arrange
        var meetingId = new Guid();
        var meeting = new MeetingViewModel()
        {
            MeetingId = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now + TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        _meetingServiceMock.Setup(x => x.Add(meeting.ToMeetingModel()));
    
        // Act
        var result = await _meetingController.Put(meeting);
    
        // Assert
        result.Should().BeOfType<BadRequestResult>();
    }
    
    [Fact]
    public async Task PostMeeting_ReturnsOk()
    {
        // Arrange
        var meetingId = new Guid();
        var meeting = new MeetingViewModel()
        {
            MeetingId = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now + TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        _meetingServiceMock.Setup(x => x.Upsert(meeting.ToMeetingModel()));
    
        // Act
        var result = await _meetingController.Post(meeting);
    
        // Assert
        result.Should().BeOfType<OkObjectResult>();
    }
    
    [Fact]
    
    public async Task PostMeeting_ReturnsBadRequest_ForInvalidDate()
    {
        // Arrange
        var meetingId = new Guid();
        var meeting = new MeetingViewModel()
        {
            MeetingId = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now - TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        _meetingServiceMock.Setup(x => x.Upsert(meeting.ToMeetingModel()));
    
        // Act
        var result = await _meetingController.Post(meeting);
    
        // Assert
        result.Should().BeOfType<BadRequestObjectResult>();
    }

    [Fact]
    public async Task PostMeetingReturnsCorrectMeeting()
    {
        // Arrange
        var meetingId = new Guid();
        var meeting = new MeetingViewModel()
        {
            MeetingId = meetingId,
            Language = "English",
            Description = "Test Description",
            Date = DateTime.Now + TimeSpan.FromDays(1),
            Location = "Test Location"
        };
        _meetingServiceMock.Setup(x => x.Upsert(meeting.ToMeetingModel()));
    
        // Act
        var result = await _meetingController.Post(meeting);
    
        // Assert
        result.Should().BeOfType<OkObjectResult>();
        var okResult = result as OkObjectResult;
        meeting.Should().BeEquivalentTo(okResult!.Value);
    }
    
    [Fact]
    public async Task DeleteMeeting_ReturnsOkResultForSuccess()
    {
        // Arrange
        var meetingId = new Guid();
        _meetingServiceMock.Setup(x => x.Delete(meetingId));
    
        // Act
        var result = await _meetingController.Delete(meetingId);
    
        // Assert
        result.Should().BeOfType<OkResult>();
    }

}