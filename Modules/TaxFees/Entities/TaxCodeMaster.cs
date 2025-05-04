using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxCodeMaster Entity
/// </summary>
public class TaxCodeMaster : Entity<TaxCodeMasterId>
{
    private TaxCodeMaster() { }

    /// <summary>
    /// The unique identifier for the TaxCodeMaster
    /// المعرف الفريد لـ TaxCodeMaster
    /// </summary>
    public TaxCodeMasterId Id { get; private set; }

    /// <summary>
    /// TaxNumber of the TaxCodeMaster
    /// TaxNumber الخاص بـ TaxCodeMaster
    /// </summary>
    public decimal? TaxNumber { get; private set; }

    /// <summary>
    /// TaxLastName of the TaxCodeMaster
    /// TaxLastName الخاص بـ TaxCodeMaster
    /// </summary>
    public string TaxLastName { get; private set; }

    /// <summary>
    /// TaxFirstName of the TaxCodeMaster
    /// TaxFirstName الخاص بـ TaxCodeMaster
    /// </summary>
    public string TaxFirstName { get; private set; }

    /// <summary>
    /// CalcDocumentType of the TaxCodeMaster
    /// CalcDocumentType الخاص بـ TaxCodeMaster
    /// </summary>
    public decimal? CalcDocumentType { get; private set; }

    /// <summary>
    /// AgencyCount of the TaxCodeMaster
    /// AgencyCount الخاص بـ TaxCodeMaster
    /// </summary>
    public decimal? AgencyCount { get; private set; }

    /// <summary>
    /// InactiveFlag of the TaxCodeMaster
    /// InactiveFlag الخاص بـ TaxCodeMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the TaxCodeMaster
    /// InactivatedByUserId الخاص بـ TaxCodeMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the TaxCodeMaster
    /// InactiveDate الخاص بـ TaxCodeMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the TaxCodeMaster
    /// InactiveReason الخاص بـ TaxCodeMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// DfltFlg of the TaxCodeMaster
    /// DfltFlg الخاص بـ TaxCodeMaster
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    /// <summary>
    /// TaxTypeCode of the TaxCodeMaster
    /// TaxTypeCode الخاص بـ TaxCodeMaster
    /// </summary>
    public string TaxTypeCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to RequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<RequestTaxItemMovement> RequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to BranchRequestTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchRequestTaxItemMovement> BranchRequestTaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to TaxCodeDetail
    /// </summary>
    public IReadOnlyCollection<TaxCodeDetail> TaxCodeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to TaxInputMovement
    /// </summary>
    public IReadOnlyCollection<TaxInputMovement> TaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to BranchTaxInputMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxInputMovement> BranchTaxInputMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to TaxItemMovement
    /// </summary>
    public IReadOnlyCollection<TaxItemMovement> TaxItemMovements { get; private set; }
    /// <summary>
    /// One-to-many relationship: TaxCodeMaster to BranchTaxItemMovement
    /// </summary>
    public IReadOnlyCollection<BranchTaxItemMovement> BranchTaxItemMovements { get; private set; }
    #endregion
}
}
