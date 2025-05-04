using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerClaimVisit Entity
/// </summary>
public class CustomerClaimVisit : Entity<CustomerClaimVisitId>
{
    private CustomerClaimVisit() { }

    /// <summary>
    /// The unique identifier for the CustomerClaimVisit
    /// المعرف الفريد لـ CustomerClaimVisit
    /// </summary>
    public CustomerClaimVisitId Id { get; private set; }

    /// <summary>
    /// BranchNumber of the CustomerClaimVisit
    /// BranchNumber الخاص بـ CustomerClaimVisit
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocNo of the CustomerClaimVisit
    /// DocNo الخاص بـ CustomerClaimVisit
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the CustomerClaimVisit
    /// DocSer الخاص بـ CustomerClaimVisit
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// VisitNumber of the CustomerClaimVisit
    /// VisitNumber الخاص بـ CustomerClaimVisit
    /// </summary>
    public decimal? VisitNumber { get; private set; }

    /// <summary>
    /// VisitDate of the CustomerClaimVisit
    /// VisitDate الخاص بـ CustomerClaimVisit
    /// </summary>
    public DateTime? VisitDate { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CustomerClaimVisit
    /// ColumnNumberShort الخاص بـ CustomerClaimVisit
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// VisitDescription of the CustomerClaimVisit
    /// VisitDescription الخاص بـ CustomerClaimVisit
    /// </summary>
    public string VisitDescription { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to CustomerClaimMaster
    /// </summary>
    public CustomerClaimMaster CustomerClaimMaster { get; private set; }
    #endregion
}
}
