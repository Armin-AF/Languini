namespace LanguageFika.Api.Services;

public interface IUnitOfWork
{
    IUserService Users { get; }
    
    Task CompleteAsync();
}