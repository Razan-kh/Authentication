namespace Authentication.Endpoints;

public static class WeatherEndpoints
{
    public static void MapWeatherEndpoints(this WebApplication app)
    {
        app.MapGet("/weather", () =>
        {
            var weather = new[] { "Sunny", "Cloudy", "Rainy" };
            var today = weather[new Random().Next(weather.Length)];
            return Results.Ok(new { Today = today });
        }).RequireAuthorization();

        app.MapGet("/", () => "Welcome! No authentication required.");
    }
}