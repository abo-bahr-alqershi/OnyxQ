using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.TrackingMonitoring.ValueObjects;
namespace ERP_Pro.Domain.ERP.TrackingMonitoring.Entities
{
/// <summary>
/// AuditAccountDetail Entity
/// </summary>
public class AuditAccountDetail : Entity<AuditAccountDetailId>
{

    private AuditAccountDetail() { }

    public AuditAccountDetail(AuditAccountDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AuditAccountDetail
    /// المعرف الفريد لـ AuditAccountDetail
    /// </summary>
    public AuditAccountDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the AuditAccountDetail
    /// DocType الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AuditAccountDetail
    /// JournalVoucherTypeFull الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the AuditAccountDetail
    /// DocNo الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AuditAccountDetail
    /// DocSer الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AccountCode of the AuditAccountDetail
    /// AccountCode الخاص بـ AuditAccountDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the AuditAccountDetail
    /// AccountDetailCode الخاص بـ AuditAccountDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the AuditAccountDetail
    /// AccountDetailType الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the AuditAccountDetail
    /// AccountCurrency الخاص بـ AuditAccountDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountRate of the AuditAccountDetail
    /// AccountRate الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CCode of the AuditAccountDetail
    /// CCode الخاص بـ AuditAccountDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the AuditAccountDetail
    /// VendorCode الخاص بـ AuditAccountDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// Amount of the AuditAccountDetail
    /// Amount الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountForeign of the AuditAccountDetail
    /// AmountForeign الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? AmountForeign { get; private set; }

    /// <summary>
    /// AccountDescription of the AuditAccountDetail
    /// AccountDescription الخاص بـ AuditAccountDetail
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// CostCenterCode of the AuditAccountDetail
    /// CostCenterCode الخاص بـ AuditAccountDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the AuditAccountDetail
    /// LetterCreditNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AuditAccountDetail
    /// ReferenceNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// RepCode of the AuditAccountDetail
    /// RepCode الخاص بـ AuditAccountDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CashNumber of the AuditAccountDetail
    /// CashNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ChequeNumber of the AuditAccountDetail
    /// ChequeNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ValueDate of the AuditAccountDetail
    /// ValueDate الخاص بـ AuditAccountDetail
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the AuditAccountDetail
    /// ExternalPostFlag الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// TerminalName of the AuditAccountDetail
    /// TerminalName الخاص بـ AuditAccountDetail
    /// </summary>
    public string TerminalName { get; private set; }

    /// <summary>
    /// RecordNumber of the AuditAccountDetail
    /// RecordNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// DocDueDate of the AuditAccountDetail
    /// DocDueDate الخاص بـ AuditAccountDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// BillNumber of the AuditAccountDetail
    /// BillNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the AuditAccountDetail
    /// BillSerial الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ItemNumber of the AuditAccountDetail
    /// ItemNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? ItemNumber { get; private set; }

    /// <summary>
    /// WorkOrderNumber of the AuditAccountDetail
    /// WorkOrderNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? WorkOrderNumber { get; private set; }

    /// <summary>
    /// WorkOrderSerial of the AuditAccountDetail
    /// WorkOrderSerial الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? WorkOrderSerial { get; private set; }

    /// <summary>
    /// KNumber of the AuditAccountDetail
    /// KNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? KNumber { get; private set; }

    /// <summary>
    /// KSerial of the AuditAccountDetail
    /// KSerial الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? KSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AuditAccountDetail
    /// CompanyNumberShort الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AuditAccountDetail
    /// BranchNumber الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AuditAccountDetail
    /// BranchYear الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AuditAccountDetail
    /// BranchUser الخاص بـ AuditAccountDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AuditAccountMaster AuditAccountMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

