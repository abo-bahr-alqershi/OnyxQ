using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// ArchiveMaster Entity
/// </summary>
public class ArchiveMaster : Entity<ArchiveMasterId>
{

    private ArchiveMaster() { }

    public ArchiveMaster(ArchiveMasterId id, decimal? fileNumber)
    {
        Id = id;
        FileNumber = fileNumber;
    }

    /// <summary>
    /// The unique identifier for the ArchiveMaster
    /// المعرف الفريد لـ ArchiveMaster
    /// </summary>
    public ArchiveMasterId Id { get; private set; }

    /// <summary>
    /// FileNumber of the ArchiveMaster
    /// FileNumber الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? FileNumber { get; private set; }

    /// <summary>
    /// FileDate of the ArchiveMaster
    /// FileDate الخاص بـ ArchiveMaster
    /// </summary>
    public DateTime? FileDate { get; private set; }

    /// <summary>
    /// FileDescription of the ArchiveMaster
    /// FileDescription الخاص بـ ArchiveMaster
    /// </summary>
    public string FileDescription { get; private set; }

    /// <summary>
    /// FileNote of the ArchiveMaster
    /// FileNote الخاص بـ ArchiveMaster
    /// </summary>
    public string FileNote { get; private set; }

    /// <summary>
    /// DocType of the ArchiveMaster
    /// DocType الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// DocNo of the ArchiveMaster
    /// DocNo الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the ArchiveMaster
    /// DocSer الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the ArchiveMaster
    /// CompanyNumberShort الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the ArchiveMaster
    /// BranchNumber الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the ArchiveMaster
    /// BranchYear الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the ArchiveMaster
    /// BranchUser الخاص بـ ArchiveMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

