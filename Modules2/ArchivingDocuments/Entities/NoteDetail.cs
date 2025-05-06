using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.ArchivingDocuments.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// NoteDetail Entity
/// </summary>
public class NoteDetail : Entity<NoteDetailId>
{

    private NoteDetail() { }

    public NoteDetail(NoteDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the NoteDetail
    /// المعرف الفريد لـ NoteDetail
    /// </summary>
    public NoteDetailId Id { get; private set; }

    /// <summary>
    /// NoteType of the NoteDetail
    /// NoteType الخاص بـ NoteDetail
    /// </summary>
    public decimal? NoteType { get; private set; }

    /// <summary>
    /// NoteTypeNumber of the NoteDetail
    /// NoteTypeNumber الخاص بـ NoteDetail
    /// </summary>
    public decimal? NoteTypeNumber { get; private set; }

    /// <summary>
    /// NoteNumber of the NoteDetail
    /// NoteNumber الخاص بـ NoteDetail
    /// </summary>
    public decimal? NoteNumber { get; private set; }

    /// <summary>
    /// NoteDescription of the NoteDetail
    /// NoteDescription الخاص بـ NoteDetail
    /// </summary>
    public string NoteDescription { get; private set; }

    /// <summary>
    /// NoteAmount of the NoteDetail
    /// NoteAmount الخاص بـ NoteDetail
    /// </summary>
    public decimal? NoteAmount { get; private set; }

    /// <summary>
    /// NoteAmountForeign of the NoteDetail
    /// NoteAmountForeign الخاص بـ NoteDetail
    /// </summary>
    public decimal? NoteAmountForeign { get; private set; }

    /// <summary>
    /// NoteRate of the NoteDetail
    /// NoteRate الخاص بـ NoteDetail
    /// </summary>
    public decimal? NoteRate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the NoteDetail
    /// CompanyNumberShort الخاص بـ NoteDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the NoteDetail
    /// BranchNumber الخاص بـ NoteDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the NoteDetail
    /// BranchYear الخاص بـ NoteDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the NoteDetail
    /// BranchUser الخاص بـ NoteDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the NoteDetail
    /// ExternalPostFlag الخاص بـ NoteDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Note Note { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

