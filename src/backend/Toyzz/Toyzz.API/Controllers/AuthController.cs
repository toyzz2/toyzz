using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Toyzz.API.Controllers;

[Route("api/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpPost]
    [AllowAnonymous]
    public IActionResult Login()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    [AllowAnonymous]
    public IActionResult Register()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult ForgotPassword()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult ResetPassword()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult Logout()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public IActionResult GetUserInfo()
    {
        throw new NotImplementedException();
    }
}