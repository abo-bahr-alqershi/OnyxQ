using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;

namespace ERP_Pro.Domain.ERP.GeneralLedger.Entities
{
/// <summary>
/// GeneralLedgerRequestDetail Entity
/// </summary>
public class GeneralLedgerRequestDetail : Entity<GeneralLedgerRequestDetailId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<GeneralLedgerRequestMaster> _generalLedgerRequestMaster = new List<GeneralLedgerRequestMaster>();

    private GeneralLedgerRequestDetail() { }

    public GeneralLedgerRequestDetail(GeneralLedgerRequestDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the GeneralLedgerRequestDetail
    /// المعرف الفريد لـ GeneralLedgerRequestDetail
    /// </summary>
    public GeneralLedgerRequestDetailId Id { get; private set; }

    /// <summary>
    /// DocType of the GeneralLedgerRequestDetail
    /// DocType الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the GeneralLedgerRequestDetail
    /// JournalVoucherTypeFull الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// DocNo of the GeneralLedgerRequestDetail
    /// DocNo الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// AccountCode of the GeneralLedgerRequestDetail
    /// AccountCode الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the GeneralLedgerRequestDetail
    /// AccountDetailCode الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the GeneralLedgerRequestDetail
    /// AccountDetailType الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// AccountCurrency of the GeneralLedgerRequestDetail
    /// AccountCurrency الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// AccountDescription of the GeneralLedgerRequestDetail
    /// AccountDescription الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string AccountDescription { get; private set; }

    /// <summary>
    /// DrAmt of the GeneralLedgerRequestDetail
    /// DrAmt الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? DrAmt { get; private set; }

    /// <summary>
    /// DrAmtF of the GeneralLedgerRequestDetail
    /// DrAmtF الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? DrAmtF { get; private set; }

    /// <summary>
    /// CreditAmount of the GeneralLedgerRequestDetail
    /// CreditAmount الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? CreditAmount { get; private set; }

    /// <summary>
    /// CreditAmountForeignShort of the GeneralLedgerRequestDetail
    /// CreditAmountForeignShort الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? CreditAmountForeignShort { get; private set; }

    /// <summary>
    /// AccountRate of the GeneralLedgerRequestDetail
    /// AccountRate الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the GeneralLedgerRequestDetail
    /// CostCenterCode الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the GeneralLedgerRequestDetail
    /// ProjectNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// CCode of the GeneralLedgerRequestDetail
    /// CCode الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// VendorCode of the GeneralLedgerRequestDetail
    /// VendorCode الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CashBankNumber of the GeneralLedgerRequestDetail
    /// CashBankNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the GeneralLedgerRequestDetail
    /// LetterCreditNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// RecordNumber of the GeneralLedgerRequestDetail
    /// RecordNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// RecordNumberOrder of the GeneralLedgerRequestDetail
    /// RecordNumberOrder الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? RecordNumberOrder { get; private set; }

    /// <summary>
    /// DocDueDate of the GeneralLedgerRequestDetail
    /// DocDueDate الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public DateTime? DocDueDate { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the GeneralLedgerRequestDetail
    /// CompanyNumberShort الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the GeneralLedgerRequestDetail
    /// BranchNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the GeneralLedgerRequestDetail
    /// BranchYear الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the GeneralLedgerRequestDetail
    /// BranchUser الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// RepCode of the GeneralLedgerRequestDetail
    /// RepCode الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// ChequeNumber of the GeneralLedgerRequestDetail
    /// ChequeNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public decimal? ChequeNumber { get; private set; }

    /// <summary>
    /// ReferenceNumber of the GeneralLedgerRequestDetail
    /// ReferenceNumber الخاص بـ GeneralLedgerRequestDetail
    /// </summary>
    public string ReferenceNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<GeneralLedgerRequestMaster> GeneralLedgerRequestMaster => _generalLedgerRequestMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
