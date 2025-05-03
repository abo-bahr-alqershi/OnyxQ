using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.CoreSystem.Events;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities;

/// <summary>
/// Represents a journal file master
/// يمثل ملف اليومية الرئيسي
/// </summary>
public class JournalFileMaster : AuditableEntity
{
    /// <summary>
    /// The unique identifier for the master
    /// المعرف الفريد للرئيسي
    /// </summary>
    public JournalFileMasterId Id { get; private set; }

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
    /// The file type
    /// نوع الملف
    /// </summary>
    public string FileType { get; private set; }

    /// <summary>
    /// Whether the file is inactive
    /// ما إذا كان الملف غير نشط
    /// </summary>
    public bool IsInactive { get; private set; }

    /// <summary>
    /// Collection of journal file details
    /// مجموعة تفاصيل ملف اليومية
    /// </summary>
    private readonly List<JournalFileDetail> _journalFileDetails = new();
    public IReadOnlyList<JournalFileDetail> JournalFileDetails => _journalFileDetails.AsReadOnly();

    private JournalFileMaster() { } // For EF Core

    public JournalFileMaster(
        string fileName,
        string fileDescription,
        string fileType)
    {
        Id = new JournalFileMasterId(Guid.NewGuid());
        FileName = fileName;
        FileDescription = fileDescription;
        FileType = fileType;
        IsInactive = false;

        AddDomainEvent(new JournalFileMasterCreatedEvent(this));
    }

    public void Update(
        string fileName,
        string fileDescription,
        string fileType)
    {
        FileName = fileName;
        FileDescription = fileDescription;
        FileType = fileType;

        AddDomainEvent(new JournalFileMasterUpdatedEvent(this));
    }

    public void Deactivate()
    {
        if (!IsInactive)
        {
            IsInactive = true;
            AddDomainEvent(new JournalFileMasterDeactivatedEvent(this));
        }
    }

    public void Activate()
    {
        if (IsInactive)
        {
            IsInactive = false;
            AddDomainEvent(new JournalFileMasterActivatedEvent(this));
        }
    }

    public void AddDetail(JournalFileDetail detail)
    {
        _journalFileDetails.Add(detail);
    }
} 