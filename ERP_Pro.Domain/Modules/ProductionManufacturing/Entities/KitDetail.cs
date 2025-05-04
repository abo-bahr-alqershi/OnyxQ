using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.ProductionManufacturing.Entities
{
/// <summary>
/// KitDetail Entity
/// </summary>
public class KitDetail : Entity<KitDetailId>
{

    private KitDetail() { }

    public KitDetail(KitDetailId id, decimal? kSerial)
    {
        Id = id;
        KSerial = kSerial;
    }

    /// <summary>
    /// The unique identifier for the KitDetail
    /// المعرف الفريد لـ KitDetail
    /// </summary>
    public KitDetailId Id { get; private set; }

    /// <summary>
    /// BillNumber of the KitDetail
    /// BillNumber الخاص بـ KitDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the KitDetail
    /// BillSerial الخاص بـ KitDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillAmount of the KitDetail
    /// BillAmount الخاص بـ KitDetail
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// BillDate of the KitDetail
    /// BillDate الخاص بـ KitDetail
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// CCode of the KitDetail
    /// CCode الخاص بـ KitDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// WarehouseCode of the KitDetail
    /// WarehouseCode الخاص بـ KitDetail
    /// </summary>
    public decimal? WarehouseCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the KitDetail
    /// CostCenterCode الخاص بـ KitDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// KNumber of the KitDetail
    /// KNumber الخاص بـ KitDetail
    /// </summary>
    public decimal? KNumber { get; private set; }

    /// <summary>
    /// KSerial of the KitDetail
    /// KSerial الخاص بـ KitDetail
    /// </summary>
    public decimal? KSerial { get; private set; }

    /// <summary>
    /// KDate of the KitDetail
    /// KDate الخاص بـ KitDetail
    /// </summary>
    public DateTime? KDate { get; private set; }

    /// <summary>
    /// KAmount of the KitDetail
    /// KAmount الخاص بـ KitDetail
    /// </summary>
    public decimal? KAmount { get; private set; }

    /// <summary>
    /// PaidAmount of the KitDetail
    /// PaidAmount الخاص بـ KitDetail
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// PaidAmountOther of the KitDetail
    /// PaidAmountOther الخاص بـ KitDetail
    /// </summary>
    public decimal? PaidAmountOther { get; private set; }

    /// <summary>
    /// KNote of the KitDetail
    /// KNote الخاص بـ KitDetail
    /// </summary>
    public string KNote { get; private set; }

    /// <summary>
    /// KPaymentYear of the KitDetail
    /// KPaymentYear الخاص بـ KitDetail
    /// </summary>
    public decimal? KPaymentYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the KitDetail
    /// CompanyNumberShort الخاص بـ KitDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the KitDetail
    /// BranchNumber الخاص بـ KitDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the KitDetail
    /// BranchYear الخاص بـ KitDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the KitDetail
    /// BranchUser الخاص بـ KitDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountCurrency AccountCurrency { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
