using LanguageFika.Api.Context;

namespace LanguageFika.Api.Services;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    readonly AppDbContext _context;

    public IUserService Users { get; private set; }
    public IMeetingService Meetings { get; private set; }
    
    public IParticipantService Participants { get; private set; }
    
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        Users = new UserService(_context);
        Meetings = new MeetingService(_context);
        Participants = new ParticipantService(_context);
    }
    
    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
    
    public void Dispose()
    {
        _context.Dispose();
    }
}