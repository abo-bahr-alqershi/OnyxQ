namespace ERP_Pro.Infrastructure.Shared.Services.Email;

public class EmailSettings
{
    public string From { get; set; } = string.Empty;
    public string Host { get; set; } = string.Empty;
    public int Port { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool EnableSsl { get; set; } = true;
    public bool UseDefaultCredentials { get; set; } = false;
    public string DisplayName { get; set; } = string.Empty;
} 