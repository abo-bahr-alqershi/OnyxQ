using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// ArchiveDetail Entity
/// </summary>
public class ArchiveDetail : Entity<ArchiveDetailId>
{

    private ArchiveDetail() { }

    public ArchiveDetail(ArchiveDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the ArchiveDetail
    /// المعرف الفريد لـ ArchiveDetail
    /// </summary>
    public ArchiveDetailId Id { get; private set; }

    /// <summary>
    /// FileAttachment of the ArchiveDetail
    /// FileAttachment الخاص بـ ArchiveDetail
    /// </summary>
    public byte[] FileAttachment { get; private set; }

    /// <summary>
    /// FilePath of the ArchiveDetail
    /// FilePath الخاص بـ ArchiveDetail
    /// </summary>
    public string FilePath { get; private set; }

    /// <summary>
    /// FileSequence of the ArchiveDetail
    /// FileSequence الخاص بـ ArchiveDetail
    /// </summary>
    public string FileSequence { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ArchiveDetail
    /// CompanyNumberShort الخاص بـ ArchiveDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ArchiveDetail
    /// BranchNumber الخاص بـ ArchiveDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ArchiveDetail
    /// BranchYear الخاص بـ ArchiveDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ArchiveDetail
    /// BranchUser الخاص بـ ArchiveDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ArchiveMaster ArchiveMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
