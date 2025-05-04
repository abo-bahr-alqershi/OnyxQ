using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Entities
{
/// <summary>
/// LightDocumentBranch Entity
/// </summary>
public class LightDocumentBranch : Entity<LightDocumentBranchId>
{

    private LightDocumentBranch() { }

    public LightDocumentBranch(LightDocumentBranchId id, decimal? branchNumber, decimal? postDocumentType)
    {
        Id = id;
        BranchNumber = branchNumber;
        PostDocumentType = postDocumentType;
    }

    /// <summary>
    /// The unique identifier for the LightDocumentBranch
    /// المعرف الفريد لـ LightDocumentBranch
    /// </summary>
    public LightDocumentBranchId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the LightDocumentBranch
    /// BranchNumber الخاص بـ LightDocumentBranch
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// PostDocumentType of the LightDocumentBranch
    /// PostDocumentType الخاص بـ LightDocumentBranch
    /// </summary>
    public decimal? PostDocumentType { get; private set; }

    /// <summary>
    /// InputCounterBranchType of the LightDocumentBranch
    /// InputCounterBranchType الخاص بـ LightDocumentBranch
    /// </summary>
    public decimal? InputCounterBranchType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
