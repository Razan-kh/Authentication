using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Authentication.Extensions;
using Authentication.Endpoints;
using Authentication.Models;
using Authentication.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddJwtAuthentication(builder.Configuration);
builder.Services.AddAppServices();

var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();

app.MapAuthEndpoints();
app.MapWeatherEndpoints();

app.Run();