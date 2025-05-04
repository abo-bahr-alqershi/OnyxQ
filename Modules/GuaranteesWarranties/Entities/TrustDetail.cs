using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// TrustDetail Entity
/// </summary>
public class TrustDetail : Entity<TrustDetailId>
{
    private TrustDetail() { }

    /// <summary>
    /// The unique identifier for the TrustDetail
    /// المعرف الفريد لـ TrustDetail
    /// </summary>
    public TrustDetailId Id { get; private set; }

    /// <summary>
    /// TrustNumber of the TrustDetail
    /// TrustNumber الخاص بـ TrustDetail
    /// </summary>
    public decimal? TrustNumber { get; private set; }

    /// <summary>
    /// TrustSerial of the TrustDetail
    /// TrustSerial الخاص بـ TrustDetail
    /// </summary>
    public decimal? TrustSerial { get; private set; }

    /// <summary>
    /// ItemCode of the TrustDetail
    /// ItemCode الخاص بـ TrustDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the TrustDetail
    /// WarehouseCode الخاص بـ TrustDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// ItemQuantity of the TrustDetail
    /// ItemQuantity الخاص بـ TrustDetail
    /// </summary>
    public decimal? ItemQuantity { get; private set; }

    /// <summary>
    /// ItemUnit of the TrustDetail
    /// ItemUnit الخاص بـ TrustDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the TrustDetail
    /// PSize الخاص بـ TrustDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// RecordNumber of the TrustDetail
    /// RecordNumber الخاص بـ TrustDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TrustDetail
    /// CompanyNumberShort الخاص بـ TrustDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TrustDetail
    /// BranchNumber الخاص بـ TrustDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TrustDetail
    /// BranchYear الخاص بـ TrustDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TrustDetail
    /// BranchUser الخاص بـ TrustDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to TrustMaster
    /// </summary>
    public TrustMaster TrustMaster { get; private set; }
    #endregion
}
}
