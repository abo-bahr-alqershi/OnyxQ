using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Cryptography;

namespace ERP_Pro.Infrastructure.Shared.Services.FileStorage;

public class LocalFileStorageService : IFileStorageService
{
    private readonly FileStorageSettings _settings;
    private readonly ILogger<LocalFileStorageService> _logger;

    public LocalFileStorageService(IOptions<FileStorageSettings> settings, ILogger<LocalFileStorageService> logger)
    {
        _settings = settings.Value;
        _logger = logger;
    }

    public async Task<string> SaveFileAsync(Stream fileStream, string fileName, string? subDirectory = null)
    {
        try
        {
            ValidateFileSize(fileStream.Length);
            ValidateFileType(fileName);

            var filePath = GetFilePath(fileName, subDirectory);
            var directory = Path.GetDirectoryName(filePath);

            if (directory != null && _settings.CreateDirectoryIfNotExists)
                Directory.CreateDirectory(directory);

            if (_settings.UseUniqueFileNames)
                filePath = MakeFilePathUnique(filePath);

            if (File.Exists(filePath) && !_settings.OverwriteExisting)
                throw new InvalidOperationException($"File {filePath} already exists and overwriting is not allowed.");

            using var fileStream2 = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            await fileStream.CopyToAsync(fileStream2);

            return GetRelativePath(filePath);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error saving file {FileName}", fileName);
            throw;
        }
    }

    public async Task<string> SaveFileAsync(byte[] fileData, string fileName, string? subDirectory = null)
    {
        using var stream = new MemoryStream(fileData);
        return await SaveFileAsync(stream, fileName, subDirectory);
    }

    public Task<bool> DeleteFileAsync(string filePath)
    {
        try
        {
            var fullPath = GetFullPath(filePath);
            if (!File.Exists(fullPath))
                return Task.FromResult(false);

            File.Delete(fullPath);
            return Task.FromResult(true);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error deleting file {FilePath}", filePath);
            return Task.FromResult(false);
        }
    }

    public Task<bool> FileExistsAsync(string filePath)
    {
        var fullPath = GetFullPath(filePath);
        return Task.FromResult(File.Exists(fullPath));
    }

    public Task<Stream?> GetFileAsync(string filePath)
    {
        try
        {
            var fullPath = GetFullPath(filePath);
            if (!File.Exists(fullPath))
                return Task.FromResult<Stream?>(null);

            var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
            return Task.FromResult<Stream?>(stream);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting file {FilePath}", filePath);
            return Task.FromResult<Stream?>(null);
        }
    }

    public async Task<byte[]?> GetFileDataAsync(string filePath)
    {
        using var stream = await GetFileAsync(filePath);
        if (stream == null)
            return null;

        using var memoryStream = new MemoryStream();
        await stream.CopyToAsync(memoryStream);
        return memoryStream.ToArray();
    }

    public Task<string> GetFileUrlAsync(string filePath)
    {
        // For local storage, we just return the relative path
        return Task.FromResult(filePath.Replace("\\", "/"));
    }

    public Task<IEnumerable<string>> GetFilesAsync(string? searchPattern = null, string? subDirectory = null)
    {
        try
        {
            var directory = GetFullPath(subDirectory ?? string.Empty);
            if (!Directory.Exists(directory))
                return Task.FromResult(Enumerable.Empty<string>());

            var files = Directory.GetFiles(directory, searchPattern ?? "*.*", SearchOption.AllDirectories)
                .Select(GetRelativePath);

            return Task.FromResult(files);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting files with pattern {SearchPattern} in directory {SubDirectory}", 
                searchPattern, subDirectory);
            return Task.FromResult(Enumerable.Empty<string>());
        }
    }

    public Task<long> GetFileSizeAsync(string filePath)
    {
        try
        {
            var fullPath = GetFullPath(filePath);
            var fileInfo = new FileInfo(fullPath);
            return Task.FromResult(fileInfo.Length);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting file size for {FilePath}", filePath);
            return Task.FromResult(0L);
        }
    }

    public Task<System.DateTime> GetLastModifiedAsync(string filePath)
    {
        try
        {
            var fullPath = GetFullPath(filePath);
            var fileInfo = new FileInfo(fullPath);
            return Task.FromResult(fileInfo.LastWriteTimeUtc);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting last modified date for {FilePath}", filePath);
            return Task.FromResult(System.DateTime.MinValue);
        }
    }

    private string GetFilePath(string fileName, string? subDirectory = null)
    {
        var basePath = Path.GetFullPath(_settings.BasePath);
        if (string.IsNullOrEmpty(subDirectory))
            return Path.Combine(basePath, fileName);

        return Path.Combine(basePath, subDirectory, fileName);
    }

    private string GetFullPath(string relativePath)
    {
        return Path.GetFullPath(Path.Combine(_settings.BasePath, relativePath));
    }

    private string GetRelativePath(string fullPath)
    {
        var basePath = Path.GetFullPath(_settings.BasePath);
        return Path.GetRelativePath(basePath, fullPath);
    }

    private void ValidateFileSize(long fileSize)
    {
        if (fileSize > _settings.MaxFileSizeBytes)
            throw new InvalidOperationException($"File size {fileSize} bytes exceeds maximum allowed size of {_settings.MaxFileSizeBytes} bytes.");
    }

    private void ValidateFileType(string fileName)
    {
        var extension = Path.GetExtension(fileName).ToLowerInvariant();
        if (!_settings.AllowedFileTypes.Contains(extension))
            throw new InvalidOperationException($"File type {extension} is not allowed.");
    }

    private string MakeFilePathUnique(string filePath)
    {
        if (!File.Exists(filePath))
            return filePath;

        var directory = Path.GetDirectoryName(filePath);
        var fileName = Path.GetFileNameWithoutExtension(filePath);
        var extension = Path.GetExtension(filePath);
        var uniqueFileName = $"{fileName}_{System.DateTime.UtcNow.Ticks}{extension}";

        return Path.Combine(directory ?? string.Empty, uniqueFileName);
    }
} 