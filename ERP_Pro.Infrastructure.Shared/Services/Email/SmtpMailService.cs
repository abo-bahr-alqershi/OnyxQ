using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;

namespace ERP_Pro.Infrastructure.Shared.Services.Email;

public class SmtpMailService : IEmailService
{
    private readonly EmailSettings _settings;
    private readonly ILogger<SmtpMailService> _logger;

    public SmtpMailService(IOptions<EmailSettings> settings, ILogger<SmtpMailService> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    public async Task SendAsync(string to, string subject, string body, bool isHtml = true)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_settings.DisplayName, _settings.From));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;

            var builder = new BodyBuilder();
            if (isHtml)
                builder.HtmlBody = body;
            else
                builder.TextBody = body;

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_settings.UserName, _settings.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending email to {To} with subject {Subject}", to, subject);
            throw;
        }
    }

    public async Task SendAsync(string to, string subject, string body, string attachmentPath, bool isHtml = true)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_settings.DisplayName, _settings.From));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;

            var builder = new BodyBuilder();
            if (isHtml)
                builder.HtmlBody = body;
            else
                builder.TextBody = body;

            if (File.Exists(attachmentPath))
                builder.Attachments.Add(attachmentPath);

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_settings.UserName, _settings.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending email with attachment to {To} with subject {Subject}", to, subject);
            throw;
        }
    }

    public async Task SendAsync(string[] to, string subject, string body, bool isHtml = true)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_settings.DisplayName, _settings.From));
            email.To.AddRange(to.Select(x => MailboxAddress.Parse(x)));
            email.Subject = subject;

            var builder = new BodyBuilder();
            if (isHtml)
                builder.HtmlBody = body;
            else
                builder.TextBody = body;

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_settings.UserName, _settings.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending email to multiple recipients with subject {Subject}", subject);
            throw;
        }
    }

    public async Task SendAsync(string[] to, string subject, string body, string[] attachmentPaths, bool isHtml = true)
    {
        try
        {
            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(_settings.DisplayName, _settings.From));
            email.To.AddRange(to.Select(x => MailboxAddress.Parse(x)));
            email.Subject = subject;

            var builder = new BodyBuilder();
            if (isHtml)
                builder.HtmlBody = body;
            else
                builder.TextBody = body;

            foreach (var attachmentPath in attachmentPaths.Where(File.Exists))
            {
                builder.Attachments.Add(attachmentPath);
            }

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(_settings.Host, _settings.Port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_settings.UserName, _settings.Password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error sending email with attachments to multiple recipients with subject {Subject}", subject);
            throw;
        }
    }

    public Task SendWithTemplateAsync(string to, string subject, string templateName, object model)
    {
        // TODO: Implement template rendering logic
        throw new NotImplementedException("Template rendering not implemented yet");
    }
} 