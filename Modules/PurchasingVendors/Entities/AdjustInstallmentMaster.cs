using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AdjustInstallmentMaster Entity
/// </summary>
public class AdjustInstallmentMaster : Entity<AdjustInstallmentMasterId>
{
    private AdjustInstallmentMaster() { }

    /// <summary>
    /// The unique identifier for the AdjustInstallmentMaster
    /// المعرف الفريد لـ AdjustInstallmentMaster
    /// </summary>
    public AdjustInstallmentMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AdjustInstallmentMaster
    /// DocNo الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AdjustInstallmentMaster
    /// DocSer الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the AdjustInstallmentMaster
    /// DocDate الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocTypeRef of the AdjustInstallmentMaster
    /// DocTypeRef الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the AdjustInstallmentMaster
    /// DocNoRef الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the AdjustInstallmentMaster
    /// DocSerRef الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// DocDateRef of the AdjustInstallmentMaster
    /// DocDateRef الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public DateTime? DocDateRef { get; private set; }

    /// <summary>
    /// CCode of the AdjustInstallmentMaster
    /// CCode الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CostCenterCode of the AdjustInstallmentMaster
    /// CostCenterCode الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AdjustInstallmentMaster
    /// ProjectNumber الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AdjustInstallmentMaster
    /// ActivityNumber الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// AccountCurrency of the AdjustInstallmentMaster
    /// AccountCurrency الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocAmtRef of the AdjustInstallmentMaster
    /// DocAmtRef الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocAmtRef { get; private set; }

    /// <summary>
    /// DocDesc of the AdjustInstallmentMaster
    /// DocDesc الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AdjustInstallmentMaster
    /// ReferenceNumber الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// DocSeq of the AdjustInstallmentMaster
    /// DocSeq الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AdjustInstallmentMaster
    /// CompanyNumberShort الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AdjustInstallmentMaster
    /// BranchNumber الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AdjustInstallmentMaster
    /// BranchYear الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AdjustInstallmentMaster
    /// BranchUser الخاص بـ AdjustInstallmentMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: AdjustInstallmentMaster to AdjustInstallmentDetail
    /// </summary>
    public IReadOnlyCollection<AdjustInstallmentDetail> AdjustInstallmentDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
