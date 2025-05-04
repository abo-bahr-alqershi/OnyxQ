using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// PaymentTrustMaster Entity
/// </summary>
public class PaymentTrustMaster : Entity<PaymentTrustMasterId>
{
    private PaymentTrustMaster() { }

    /// <summary>
    /// The unique identifier for the PaymentTrustMaster
    /// المعرف الفريد لـ PaymentTrustMaster
    /// </summary>
    public PaymentTrustMasterId Id { get; private set; }

    /// <summary>
    /// PaymentTrustNumber of the PaymentTrustMaster
    /// PaymentTrustNumber الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? PaymentTrustNumber { get; private set; }

    /// <summary>
    /// PaymentTrustSerial of the PaymentTrustMaster
    /// PaymentTrustSerial الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? PaymentTrustSerial { get; private set; }

    /// <summary>
    /// PaymentTrustDate of the PaymentTrustMaster
    /// PaymentTrustDate الخاص بـ PaymentTrustMaster
    /// </summary>
    public DateTime? PaymentTrustDate { get; private set; }

    /// <summary>
    /// AccountDescription of the PaymentTrustMaster
    /// AccountDescription الخاص بـ PaymentTrustMaster
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// WarehouseCode of the PaymentTrustMaster
    /// WarehouseCode الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ReferenceNumber of the PaymentTrustMaster
    /// ReferenceNumber الخاص بـ PaymentTrustMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// EmpNo of the PaymentTrustMaster
    /// EmpNo الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// TrustNumber of the PaymentTrustMaster
    /// TrustNumber الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? TrustNumber { get; private set; }

    /// <summary>
    /// TrustSerial of the PaymentTrustMaster
    /// TrustSerial الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? TrustSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PaymentTrustMaster
    /// CompanyNumberShort الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PaymentTrustMaster
    /// BranchNumber الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PaymentTrustMaster
    /// BranchYear الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PaymentTrustMaster
    /// BranchUser الخاص بـ PaymentTrustMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PaymentTrustMaster to PaymentTrustDetail
    /// </summary>
    public IReadOnlyCollection<PaymentTrustDetail> PaymentTrustDetails { get; private set; }
    #endregion
}
}
