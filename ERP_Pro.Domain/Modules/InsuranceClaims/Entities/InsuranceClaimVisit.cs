using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClaimVisit Entity
/// </summary>
public class InsuranceClaimVisit : Entity<InsuranceClaimVisitId>
{

    private InsuranceClaimVisit() { }

    public InsuranceClaimVisit(InsuranceClaimVisitId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClaimVisit
    /// المعرف الفريد لـ InsuranceClaimVisit
    /// </summary>
    public InsuranceClaimVisitId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the InsuranceClaimVisit
    /// BranchNumber الخاص بـ InsuranceClaimVisit
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the InsuranceClaimVisit
    /// DocNo الخاص بـ InsuranceClaimVisit
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the InsuranceClaimVisit
    /// DocSer الخاص بـ InsuranceClaimVisit
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// VisitNumber of the InsuranceClaimVisit
    /// VisitNumber الخاص بـ InsuranceClaimVisit
    /// </summary>
    public decimal? VisitNumber { get; private set; }

    /// <summary>
    /// VisitDate of the InsuranceClaimVisit
    /// VisitDate الخاص بـ InsuranceClaimVisit
    /// </summary>
    public DateTime? VisitDate { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the InsuranceClaimVisit
    /// ColumnNumberShort الخاص بـ InsuranceClaimVisit
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// VisitDescription of the InsuranceClaimVisit
    /// VisitDescription الخاص بـ InsuranceClaimVisit
    /// </summary>
    public string VisitDescription { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
