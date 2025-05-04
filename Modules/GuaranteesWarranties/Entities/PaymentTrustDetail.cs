using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// PaymentTrustDetail Entity
/// </summary>
public class PaymentTrustDetail : Entity<PaymentTrustDetailId>
{
    private PaymentTrustDetail() { }

    /// <summary>
    /// The unique identifier for the PaymentTrustDetail
    /// المعرف الفريد لـ PaymentTrustDetail
    /// </summary>
    public PaymentTrustDetailId Id { get; private set; }

    /// <summary>
    /// PaymentTrustNumber of the PaymentTrustDetail
    /// PaymentTrustNumber الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? PaymentTrustNumber { get; private set; }

    /// <summary>
    /// PaymentTrustSerial of the PaymentTrustDetail
    /// PaymentTrustSerial الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? PaymentTrustSerial { get; private set; }

    /// <summary>
    /// ItemCode of the PaymentTrustDetail
    /// ItemCode الخاص بـ PaymentTrustDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the PaymentTrustDetail
    /// WarehouseCode الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the PaymentTrustDetail
    /// ItemQuantity الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the PaymentTrustDetail
    /// ItemUnit الخاص بـ PaymentTrustDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the PaymentTrustDetail
    /// PSize الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// RecordNumber of the PaymentTrustDetail
    /// RecordNumber الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PaymentTrustDetail
    /// CompanyNumberShort الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PaymentTrustDetail
    /// BranchNumber الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PaymentTrustDetail
    /// BranchYear الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PaymentTrustDetail
    /// BranchUser الخاص بـ PaymentTrustDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to PaymentTrustMaster
    /// </summary>
    public PaymentTrustMaster PaymentTrustMaster { get; private set; }
    #endregion
}
}
