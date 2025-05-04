using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// PaymentDetail Entity
/// </summary>
public class PaymentDetail : Entity<PaymentDetailId>
{

    private PaymentDetail() { }

    public PaymentDetail(PaymentDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PaymentDetail
    /// المعرف الفريد لـ PaymentDetail
    /// </summary>
    public PaymentDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the PaymentDetail
    /// DocNo الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the PaymentDetail
    /// DocSer الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// DocDate of the PaymentDetail
    /// DocDate الخاص بـ PaymentDetail
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocType of the PaymentDetail
    /// DocType الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the PaymentDetail
    /// JournalVoucherTypeFull الخاص بـ PaymentDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PaymentDetail
    /// AccountDetailCode الخاص بـ PaymentDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PaymentDetail
    /// AccountDetailType الخاص بـ PaymentDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// VendorCode of the PaymentDetail
    /// VendorCode الخاص بـ PaymentDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the PaymentDetail
    /// AccountCurrency الخاص بـ PaymentDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DocDesc of the PaymentDetail
    /// DocDesc الخاص بـ PaymentDetail
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// DrAmt of the PaymentDetail
    /// DrAmt الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// CreditAmount of the PaymentDetail
    /// CreditAmount الخاص بـ PaymentDetail
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the PaymentDetail
    /// RecordNumber الخاص بـ PaymentDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocTypeRef of the PaymentDetail
    /// DocTypeRef الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DocTypeRef { get; private set; }

    /// <summary>
    /// DocNoRef of the PaymentDetail
    /// DocNoRef الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DocNoRef { get; private set; }

    /// <summary>
    /// DocSerRef of the PaymentDetail
    /// DocSerRef الخاص بـ PaymentDetail
    /// </summary>
    public decimal? DocSerRef { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PaymentDetail
    /// CompanyNumberShort الخاص بـ PaymentDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PaymentDetail
    /// BranchNumber الخاص بـ PaymentDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PaymentDetail
    /// BranchYear الخاص بـ PaymentDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PaymentDetail
    /// BranchUser الخاص بـ PaymentDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
