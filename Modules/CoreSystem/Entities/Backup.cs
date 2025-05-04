using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// Backup Entity
/// </summary>
public class Backup : Entity<BackupId>
{
    private Backup() { }

    /// <summary>
    /// The unique identifier for the Backup
    /// المعرف الفريد لـ Backup
    /// </summary>
    public BackupId Id { get; private set; }

    /// <summary>
    /// BackupNumber of the Backup
    /// BackupNumber الخاص بـ Backup
    /// </summary>
    public decimal? BackupNumber { get; private set; }

    /// <summary>
    /// BackupName of the Backup
    /// BackupName الخاص بـ Backup
    /// </summary>
    public string BackupName { get; private set; }

    /// <summary>
    /// FileName of the Backup
    /// FileName الخاص بـ Backup
    /// </summary>
    public string FileName { get; private set; }

    /// <summary>
    /// BackupDate of the Backup
    /// BackupDate الخاص بـ Backup
    /// </summary>
    public DateTime? BackupDate { get; private set; }

    /// <summary>
    /// EncPasswd of the Backup
    /// EncPasswd الخاص بـ Backup
    /// </summary>
    public string EncPasswd { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the Backup
    /// CompanyNumberShort الخاص بـ Backup
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the Backup
    /// BranchNumber الخاص بـ Backup
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the Backup
    /// BranchYear الخاص بـ Backup
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the Backup
    /// BranchUser الخاص بـ Backup
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
