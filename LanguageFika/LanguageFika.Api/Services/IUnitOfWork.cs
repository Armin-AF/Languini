namespace LanguageFika.Api.Services;

public interface IUnitOfWork
{
    IUserService Users { get; }
    IMeetingService Meetings { get; }
    
    Task CompleteAsync();
}