using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AdjustInstallmentDetail Entity
/// </summary>
public class AdjustInstallmentDetail : Entity<AdjustInstallmentDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<AdjustInstallmentMaster> _adjustInstallmentMaster = new List<AdjustInstallmentMaster>();

    private AdjustInstallmentDetail() { }

    public AdjustInstallmentDetail(AdjustInstallmentDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AdjustInstallmentDetail
    /// المعرف الفريد لـ AdjustInstallmentDetail
    /// </summary>
    public AdjustInstallmentDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AdjustInstallmentDetail
    /// DocNo الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocTypeRef of the AdjustInstallmentDetail
    /// DocTypeRef الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// CCode of the AdjustInstallmentDetail
    /// CCode الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AdjustInstallmentDetail
    /// CostCenterCode الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AdjustInstallmentDetail
    /// ProjectNumber الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the AdjustInstallmentDetail
    /// AccountCurrency الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocNoRef of the AdjustInstallmentDetail
    /// DocNoRef الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AdjustInstallmentDetail
    /// DocSerRef الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ItemNumber of the AdjustInstallmentDetail
    /// ItemNumber الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// PaidAmountDocument of the AdjustInstallmentDetail
    /// PaidAmountDocument الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? PaidAmountDocument { get; private set; }

    /// <summary>
    /// RecordNumber of the AdjustInstallmentDetail
    /// RecordNumber الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemPaymentYear of the AdjustInstallmentDetail
    /// ItemPaymentYear الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? ItemPaymentYear { get; private set; }

    /// <summary>
    /// PaidAmount of the AdjustInstallmentDetail
    /// PaidAmount الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// InvoiceAmount of the AdjustInstallmentDetail
    /// InvoiceAmount الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// ItemDate of the AdjustInstallmentDetail
    /// ItemDate الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AdjustInstallmentDetail
    /// CompanyNumberShort الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AdjustInstallmentDetail
    /// BranchNumber الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AdjustInstallmentDetail
    /// BranchYear الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AdjustInstallmentDetail
    /// BranchUser الخاص بـ AdjustInstallmentDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AdjustInstallmentMaster> AdjustInstallmentMaster => _adjustInstallmentMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

