namespace ERP_Pro.Server.Middlewares;

public class TenantMiddleware
{
    private readonly RequestDelegate _next;

    public TenantMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var tenantId = GetTenantId(context);
        if (!string.IsNullOrEmpty(tenantId))
        {
            context.Items["TenantId"] = tenantId;
        }

        await _next(context);
    }

    private string? GetTenantId(HttpContext context)
    {
        // Try to get from header
        var tenantFromHeader = context.Request.Headers["X-Tenant-Id"].ToString();
        if (!string.IsNullOrEmpty(tenantFromHeader))
        {
            return tenantFromHeader;
        }

        // Try to get from claim
        var user = context.User;
        if (user.Identity?.IsAuthenticated == true)
        {
            var tenantFromClaim = user.Claims.FirstOrDefault(x => x.Type == "tenant_id")?.Value;
            if (!string.IsNullOrEmpty(tenantFromClaim))
            {
                return tenantFromClaim;
            }
        }

        // Try to get from query string
        var tenantFromQuery = context.Request.Query["tenant_id"].ToString();
        if (!string.IsNullOrEmpty(tenantFromQuery))
        {
            return tenantFromQuery;
        }

        return null;
    }
} 