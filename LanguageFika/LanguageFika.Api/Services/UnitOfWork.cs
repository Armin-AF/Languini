using LanguageFika.Api.Context;

namespace LanguageFika.Api.Services;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    readonly AppDbContext _context;
    readonly ILogger _logger;
    
    public IUserService Users { get; private set; }
    
    public UnitOfWork(AppDbContext context, ILogger logger)
    {
        _context = context;
        _logger = logger;
        Users = new UserService(_context, _logger);
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