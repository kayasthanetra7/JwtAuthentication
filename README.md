# JwtAuthentication
ASP.NET Core 5.0 JWT Authentication API

The example API has one endpoint/route to demonstrate authenticating with basic http authentication and accessing a restricted route:

/WeatherForecast - secure route that accepts HTTP GET requests and returns weather forecast for five consecutive days if the HTTP Authorization header contains a valid JWT token. If there is no auth token or the token is invalid then a 401 Unauthorized response is returned.
