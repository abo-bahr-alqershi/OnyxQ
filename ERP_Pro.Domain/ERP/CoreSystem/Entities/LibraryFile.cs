using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a library file
/// يمثل ملف المكتبة
/// </summary>
public class LibraryFile : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the file
    /// المعرف الفريد للملف
    /// </summary>
    public LibraryFileId Id { get; private set; }

    /// <summary>
    /// The file name
    /// اسم الملف
    /// </summary>
    public string FileName { get; private set; }

    /// <summary>
    /// The file description
    /// وصف الملف
    /// </summary>
    public string FileDescription { get; private set; }

    /// <summary>
    /// The file path
    /// مسار الملف
    /// </summary>
    public string FilePath { get; private set; }

    /// <summary>
    /// The file type
    /// نوع الملف
    /// </summary>
    public string FileType { get; private set; }

    /// <summary>
    /// Whether the file is inactive
    /// ما إذا كان الملف غير نشط
    /// </summary>
    public bool IsInactive { get; private set; }

    private LibraryFile() { } // For EF Core

    public LibraryFile(
        string fileName,
        string fileDescription,
        string filePath,
        string fileType)
    {
        Id = new LibraryFileId(Guid.NewGuid());
        FileName = fileName;
        FileDescription = fileDescription;
        FilePath = filePath;
        FileType = fileType;
        IsInactive = false;

        AddDomainEvent(new LibraryFileCreatedEvent(this));
    }

    public void Update(
        string fileName,
        string fileDescription,
        string filePath,
        string fileType)
    {
        FileName = fileName;
        FileDescription = fileDescription;
        FilePath = filePath;
        FileType = fileType;

        AddDomainEvent(new LibraryFileUpdatedEvent(this));
    }

    public void Deactivate()
    {
        if (!IsInactive)
        {
            IsInactive = true;
            AddDomainEvent(new LibraryFileDeactivatedEvent(this));
        }
    }

    public void Activate()
    {
        if (IsInactive)
        {
            IsInactive = false;
            AddDomainEvent(new LibraryFileActivatedEvent(this));
        }
    }
} 