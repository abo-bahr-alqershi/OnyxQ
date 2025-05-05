using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

using ERP_Pro.Domain.ERP.StationsFuel.ValueObjects;
namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCreditBillDetail Entity
/// </summary>
public class StationCreditBillDetail : Entity<StationCreditBillDetailId>
{
    private readonly List<StationCreditBillMaster> _stationCreditBillMaster = new List<StationCreditBillMaster>();
    private readonly List<Customer> _customer = new List<Customer>();

    private StationCreditBillDetail() { }

    public StationCreditBillDetail(StationCreditBillDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the StationCreditBillDetail
    /// المعرف الفريد لـ StationCreditBillDetail
    /// </summary>
    public StationCreditBillDetailId Id { get; private set; }

    /// <summary>
    /// BillNumber of the StationCreditBillDetail
    /// BillNumber الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// DocNo of the StationCreditBillDetail
    /// DocNo الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ProcessedFlag of the StationCreditBillDetail
    /// ProcessedFlag الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? ProcessedFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the StationCreditBillDetail
    /// InactiveFlag الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the StationCreditBillDetail
    /// InactivatedByUserId الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the StationCreditBillDetail
    /// InactiveDate الخاص بـ StationCreditBillDetail
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the StationCreditBillDetail
    /// InactiveReason الخاص بـ StationCreditBillDetail
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// MoveBillPaymentYear of the StationCreditBillDetail
    /// MoveBillPaymentYear الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? MoveBillPaymentYear { get; private set; }

    /// <summary>
    /// DocNoPy of the StationCreditBillDetail
    /// DocNoPy الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? DocNoPy { get; private set; }

    /// <summary>
    /// DocSerPy of the StationCreditBillDetail
    /// DocSerPy الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? DocSerPy { get; private set; }

    /// <summary>
    /// PYear of the StationCreditBillDetail
    /// PYear الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? PYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the StationCreditBillDetail
    /// CompanyNumberShort الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the StationCreditBillDetail
    /// BranchNumber الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the StationCreditBillDetail
    /// BranchYear الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the StationCreditBillDetail
    /// BranchUser الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationCreditBillDetail
    /// FuelTypeNumber الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<StationCreditBillMaster> StationCreditBillMaster => _stationCreditBillMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

