using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Toyzz.Domain.SeedWork;

namespace Toyzz.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class JwtController : ControllerBase
{
    private readonly IJwtTokenService _jwtTokenService;

    public JwtController(IJwtTokenService jwtTokenService)
    {
        _jwtTokenService = jwtTokenService;
    }

    [HttpPost("/security/createToken")]
    [AllowAnonymous]
    public IActionResult CreateToken()
    {
        var jwtToken = _jwtTokenService.CreateJwtToken();

        return Ok(jwtToken);
    }
}