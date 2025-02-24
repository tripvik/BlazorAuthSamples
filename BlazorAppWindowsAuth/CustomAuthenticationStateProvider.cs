using System.Security.Claims;

namespace BlazorAppWindowsAuth;

public class CustomAuthenticationStateProvider : AuthenticationStateProvider
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public CustomAuthenticationStateProvider(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var identity = _httpContextAccessor?.HttpContext?.User.Identity;
        var user = new ClaimsPrincipal(identity!);
        return Task.FromResult(new AuthenticationState(user));
    }
}