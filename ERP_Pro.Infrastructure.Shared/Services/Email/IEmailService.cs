namespace ERP_Pro.Infrastructure.Shared.Services.Email;

public interface IEmailService
{
    Task SendAsync(string to, string subject, string body, bool isHtml = true);
    Task SendAsync(string to, string subject, string body, string attachmentPath, bool isHtml = true);
    Task SendAsync(string[] to, string subject, string body, bool isHtml = true);
    Task SendAsync(string[] to, string subject, string body, string[] attachmentPaths, bool isHtml = true);
    Task SendWithTemplateAsync(string to, string subject, string templateName, object model);
} 