using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// TenderMaster Entity
/// </summary>
public class TenderMaster : Entity<TenderMasterId>
{
    private TenderMaster() { }

    /// <summary>
    /// The unique identifier for the TenderMaster
    /// المعرف الفريد لـ TenderMaster
    /// </summary>
    public TenderMasterId Id { get; private set; }

    /// <summary>
    /// TdType of the TenderMaster
    /// TdType الخاص بـ TenderMaster
    /// </summary>
    public decimal? TdType { get; private set; }

    /// <summary>
    /// TdNumber of the TenderMaster
    /// TdNumber الخاص بـ TenderMaster
    /// </summary>
    public decimal? TdNumber { get; private set; }

    /// <summary>
    /// TdSerial of the TenderMaster
    /// TdSerial الخاص بـ TenderMaster
    /// </summary>
    public decimal? TdSerial { get; private set; }

    /// <summary>
    /// TdDate of the TenderMaster
    /// TdDate الخاص بـ TenderMaster
    /// </summary>
    public DateTime? TdDate { get; private set; }

    /// <summary>
    /// VendorCode of the TenderMaster
    /// VendorCode الخاص بـ TenderMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// VendorName of the TenderMaster
    /// VendorName الخاص بـ TenderMaster
    /// </summary>
    public string VendorName { get; private set; }

    /// <summary>
    /// AccountCurrency of the TenderMaster
    /// AccountCurrency الخاص بـ TenderMaster
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// CostCenterCode of the TenderMaster
    /// CostCenterCode الخاص بـ TenderMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the TenderMaster
    /// ProjectNumber الخاص بـ TenderMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the TenderMaster
    /// ActivityNumber الخاص بـ TenderMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// TdProcessed of the TenderMaster
    /// TdProcessed الخاص بـ TenderMaster
    /// </summary>
    public decimal? TdProcessed { get; private set; }

    /// <summary>
    /// TdDescription of the TenderMaster
    /// TdDescription الخاص بـ TenderMaster
    /// </summary>
    public string TdDescription { get; private set; }

    /// <summary>
    /// InactiveFlag of the TenderMaster
    /// InactiveFlag الخاص بـ TenderMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// ReservationInactive of the TenderMaster
    /// ReservationInactive الخاص بـ TenderMaster
    /// </summary>
    public string ReservationInactive { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the TenderMaster
    /// CompanyNumberShort الخاص بـ TenderMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the TenderMaster
    /// BranchNumber الخاص بـ TenderMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the TenderMaster
    /// BranchYear الخاص بـ TenderMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the TenderMaster
    /// BranchUser الخاص بـ TenderMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: TenderMaster to TenderDetail
    /// </summary>
    public IReadOnlyCollection<TenderDetail> TenderDetails { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to TenderType
    /// </summary>
    public TenderType TenderType { get; private set; }
    #endregion
}
}
