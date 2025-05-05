namespace ERP_Pro.Infrastructure.Shared.Services.FileStorage;

public class FileStorageSettings
{
    public string BasePath { get; set; } = "uploads";
    public long MaxFileSizeBytes { get; set; } = 10 * 1024 * 1024; // 10MB default
    public string[] AllowedFileTypes { get; set; } = new[] { ".jpg", ".jpeg", ".png", ".gif", ".pdf", ".doc", ".docx", ".xls", ".xlsx" };
    public bool CreateDirectoryIfNotExists { get; set; } = true;
    public bool OverwriteExisting { get; set; } = false;
    public bool UseUniqueFileNames { get; set; } = true;
} 