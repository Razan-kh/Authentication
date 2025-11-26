using Authentication.Models;

namespace Authentication.Services;

public class AuthService
{
    private readonly JwtGenerator _jwt;

    public AuthService(JwtGenerator jwt)
    {
        _jwt = jwt;
    }

    public string? Authenticate(LoginRequest request)
    {
        if (request.Username == "admin" && request.Password == "password")
            return _jwt.GenerateToken(request.Username);

        return null;
    }
}