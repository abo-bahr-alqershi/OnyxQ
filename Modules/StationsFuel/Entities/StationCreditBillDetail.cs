using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.StationsFuel.Entities
{
/// <summary>
/// StationCreditBillDetail Entity
/// </summary>
public class StationCreditBillDetail : Entity<StationCreditBillDetailId>
{
    private StationCreditBillDetail() { }

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
    /// DocSer of the StationCreditBillDetail
    /// DocSer الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

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
    /// CCode of the StationCreditBillDetail
    /// CCode الخاص بـ StationCreditBillDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// FuelTypeNumber of the StationCreditBillDetail
    /// FuelTypeNumber الخاص بـ StationCreditBillDetail
    /// </summary>
    public decimal? FuelTypeNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to StationCreditBillMaster
    /// </summary>
    public StationCreditBillMaster StationCreditBillMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
