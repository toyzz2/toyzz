using Microsoft.AspNetCore.Mvc.Filters;

namespace Toyzz.API.Extensions;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAsyncAuthorizationFilter
{
    public Task OnAuthorizationAsync(AuthorizationFilterContext context)
    {
        throw new NotImplementedException();
    }
}