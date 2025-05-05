namespace ERP_Pro.Infrastructure.Shared.Services.FileStorage;

public interface IFileStorageService
{
    Task<string> SaveFileAsync(Stream fileStream, string fileName, string? subDirectory = null);
    Task<string> SaveFileAsync(byte[] fileData, string fileName, string? subDirectory = null);
    Task<bool> DeleteFileAsync(string filePath);
    Task<bool> FileExistsAsync(string filePath);
    Task<Stream?> GetFileAsync(string filePath);
    Task<byte[]?> GetFileDataAsync(string filePath);
    Task<string> GetFileUrlAsync(string filePath);
    Task<IEnumerable<string>> GetFilesAsync(string? searchPattern = null, string? subDirectory = null);
    Task<long> GetFileSizeAsync(string filePath);
    Task<DateTime> GetLastModifiedAsync(string filePath);
} 