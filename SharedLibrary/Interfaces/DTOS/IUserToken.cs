namespace SharedLibrary.Interfaces.Entities;

public interface IUserToken
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
}