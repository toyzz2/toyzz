using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Toyzz.Infrastructure.Options;

namespace Toyzz.Domain.SeedWork;

public class JwtTokenService : IJwtTokenService
{
    private readonly ILogger<JwtTokenService> _logger;
    private readonly JwtOptions _options;

    public JwtTokenService(IOptions<JwtOptions> options, ILogger<JwtTokenService> logger)
    {
        _logger = logger;
        _options = options.Value;
        _logger.LogInformation("JwtTokenService");
    }

    public string? CreateJwtToken()
    {
        var key = Encoding.ASCII.GetBytes(_options.Key);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[]
            {
                new Claim("Id", Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Sub, "Toyzz"),
                new Claim(JwtRegisteredClaimNames.Email, "Toyzz@"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            }),
            Expires = DateTime.UtcNow.AddMinutes(5),
            Issuer = _options.Issuer,
            Audience = _options.Audience,
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
        };

        var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        var token = jwtSecurityTokenHandler.CreateToken(tokenDescriptor);
        var jwtToken = jwtSecurityTokenHandler.WriteToken(token);
        _logger.LogInformation("CreateJwtToken");
        return jwtToken;
    }

    // public bool IsTokenValid(string token)
    // {
    //     var tokenHandler = new JwtSecurityTokenHandler();
    //     tokenHandler.ValidateToken(token, new TokenValidationParameters()
    //     {
    //         ValidateIssuerSigningKey = true,
    //         ValidateIssuer = true,
    //         ValidateAudience = true,
    //         ValidIssuer = _options.Issuer,
    //         ValidAudience = _options.Audience,
    //         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.Key)),
    //     }, out var validatedToken);
    //
    //     return true;
    // }
}