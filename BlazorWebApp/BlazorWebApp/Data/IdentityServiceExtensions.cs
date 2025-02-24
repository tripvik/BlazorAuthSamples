using Microsoft.AspNetCore.Identity;

public static class IdentityServiceExtensions
{
    public static void IdentityOptions(this IdentityOptions options)
    {
        options.SignIn.RequireConfirmedAccount = false;
        options.Password.RequiredLength = 3;
        options.Password.RequireDigit = false;
        options.Password.RequireUppercase = false;
        options.Password.RequireNonAlphanumeric = false;
    }
}