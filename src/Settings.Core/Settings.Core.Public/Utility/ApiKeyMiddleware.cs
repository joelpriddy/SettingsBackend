using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;

namespace Settings.Core.Public.Utility
{
    public class ApiKeyMiddleware
    {
        private const string ApiKeyHeaderName = "X-PA-API-KEY";
        private readonly RequestDelegate _next;
        private readonly ISecurityService _Security;

        public ApiKeyMiddleware(RequestDelegate next, ISecurityService security)
        {
            _next = next;
            _Security = security;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Request.Headers.TryGetValue(ApiKeyHeaderName, out var extractedApiKey))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("No API Key found.");
                return;
            }

            if (!_Security.IsAuthorized(extractedApiKey!, context.GetEndpoint()))
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Unauthorized client.");
                return;
            }

            await _next(context);
        }
    }
}
