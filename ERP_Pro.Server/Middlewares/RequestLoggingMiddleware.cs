// RequestLoggingMiddleware.cs
// تم إنشاؤه تلقائيًا.

using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace ERP_Pro.Server.Middlewares;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<RequestLoggingMiddleware> _logger;

    public RequestLoggingMiddleware(RequestDelegate next, ILogger<RequestLoggingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var sw = Stopwatch.StartNew();
        try
        {
            await _next(context);
            sw.Stop();

            var statusCode = context.Response?.StatusCode;
            var level = statusCode > 499 ? LogLevel.Error : LogLevel.Information;

            _logger.Log(level,
                "HTTP {RequestMethod} {RequestPath} responded {StatusCode} in {Elapsed:0.0000} ms",
                context.Request.Method,
                context.Request.Path,
                statusCode,
                sw.Elapsed.TotalMilliseconds);
        }
        catch (Exception ex)
        {
            sw.Stop();
            _logger.LogError(
                ex,
                "HTTP {RequestMethod} {RequestPath} failed in {Elapsed:0.0000} ms",
                context.Request.Method,
                context.Request.Path,
                sw.Elapsed.TotalMilliseconds);
            throw;
        }
    }
}