using Authentication.Models;
using Authentication.Services;

namespace Authentication.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this WebApplication app)
    {
        app.MapPost("/login", (LoginRequest request, AuthService authService) =>
        {
            var token = authService.Authenticate(request);
            return token is not null
                ? Results.Ok(new { token })
                : Results.Unauthorized();
        });
    }
}