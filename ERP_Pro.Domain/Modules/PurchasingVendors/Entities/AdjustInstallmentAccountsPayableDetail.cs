using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AdjustInstallmentAccountsPayableDetail Entity
/// </summary>
public class AdjustInstallmentAccountsPayableDetail : Entity<AdjustInstallmentAccountsPayableDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<AdjustInstallmentAccountsPayableMaster> _adjustInstallmentAccountsPayableMaster = new List<AdjustInstallmentAccountsPayableMaster>();

    private AdjustInstallmentAccountsPayableDetail() { }

    public AdjustInstallmentAccountsPayableDetail(AdjustInstallmentAccountsPayableDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AdjustInstallmentAccountsPayableDetail
    /// المعرف الفريد لـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public AdjustInstallmentAccountsPayableDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AdjustInstallmentAccountsPayableDetail
    /// DocNo الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocTypeRef of the AdjustInstallmentAccountsPayableDetail
    /// DocTypeRef الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// VendorCode of the AdjustInstallmentAccountsPayableDetail
    /// VendorCode الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AdjustInstallmentAccountsPayableDetail
    /// CostCenterCode الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AdjustInstallmentAccountsPayableDetail
    /// ProjectNumber الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the AdjustInstallmentAccountsPayableDetail
    /// AccountCurrency الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocNoRef of the AdjustInstallmentAccountsPayableDetail
    /// DocNoRef الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AdjustInstallmentAccountsPayableDetail
    /// DocSerRef الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// ItemNumber of the AdjustInstallmentAccountsPayableDetail
    /// ItemNumber الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// PaidAmountDocument of the AdjustInstallmentAccountsPayableDetail
    /// PaidAmountDocument الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? PaidAmountDocument { get; private set; }

    /// <summary>
    /// RecordNumber of the AdjustInstallmentAccountsPayableDetail
    /// RecordNumber الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ItemPaymentYear of the AdjustInstallmentAccountsPayableDetail
    /// ItemPaymentYear الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? ItemPaymentYear { get; private set; }

    /// <summary>
    /// PaidAmount of the AdjustInstallmentAccountsPayableDetail
    /// PaidAmount الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? PaidAmount { get; private set; }

    /// <summary>
    /// InvoiceAmount of the AdjustInstallmentAccountsPayableDetail
    /// InvoiceAmount الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? InvoiceAmount { get; private set; }

    /// <summary>
    /// ItemDate of the AdjustInstallmentAccountsPayableDetail
    /// ItemDate الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public DateTime? ItemDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AdjustInstallmentAccountsPayableDetail
    /// CompanyNumberShort الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AdjustInstallmentAccountsPayableDetail
    /// BranchNumber الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AdjustInstallmentAccountsPayableDetail
    /// BranchYear الخاص بـ AdjustInstallmentAccountsPayableDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AdjustInstallmentAccountsPayableDetail
    /// BranchUser الخاص بـ AdjustInstallmentAccountsPayableDetail
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
    public ICollection<AdjustInstallmentAccountsPayableMaster> AdjustInstallmentAccountsPayableMaster => _adjustInstallmentAccountsPayableMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

