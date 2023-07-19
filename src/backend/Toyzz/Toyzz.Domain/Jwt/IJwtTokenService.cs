namespace Toyzz.Domain.SeedWork;

public interface IJwtTokenService
{
    string? CreateJwtToken();

    // bool IsTokenValid(string token);
}