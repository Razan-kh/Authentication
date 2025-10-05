using Authentication.Models;

namespace Authentication.Services;

public class AuthService
{
    private readonly JwtTokenGenerator _jwt;

    public AuthService(JwtTokenGenerator jwt)
    {
        _jwt = jwt;
    }

    public string? Authenticate(LoginRequest request)
    {
        if (request.Username == "test" && request.Password == "password123")
            return _jwt.GenerateToken(request.Username);

        return null;
    }
}