using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableKimbDetail Entity
/// </summary>
public class AccountsPayableKimbDetail : Entity<AccountsPayableKimbDetailId>
{

    private AccountsPayableKimbDetail() { }

    public AccountsPayableKimbDetail(AccountsPayableKimbDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableKimbDetail
    /// المعرف الفريد لـ AccountsPayableKimbDetail
    /// </summary>
    public AccountsPayableKimbDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableKimbDetail
    /// DocNo الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// KilometerType of the AccountsPayableKimbDetail
    /// KilometerType الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? KilometerType { get; private set; }

    /// <summary>
    /// KilometerNumber of the AccountsPayableKimbDetail
    /// KilometerNumber الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? KilometerNumber { get; private set; }

    /// <summary>
    /// KilometerSerial of the AccountsPayableKimbDetail
    /// KilometerSerial الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? KilometerSerial { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the AccountsPayableKimbDetail
    /// LetterCreditNumber الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// LetterCreditSerial of the AccountsPayableKimbDetail
    /// LetterCreditSerial الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? LetterCreditSerial { get; private set; }

    /// <summary>
    /// BillNumber of the AccountsPayableKimbDetail
    /// BillNumber الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the AccountsPayableKimbDetail
    /// BillSerial الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// RecordNumber of the AccountsPayableKimbDetail
    /// RecordNumber الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// KilometerAmount of the AccountsPayableKimbDetail
    /// KilometerAmount الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? KilometerAmount { get; private set; }

    /// <summary>
    /// ValueDate of the AccountsPayableKimbDetail
    /// ValueDate الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public DateTime? ValueDate { get; private set; }

    /// <summary>
    /// ValuedFlag of the AccountsPayableKimbDetail
    /// ValuedFlag الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? ValuedFlag { get; private set; }

    /// <summary>
    /// KilometerDescription of the AccountsPayableKimbDetail
    /// KilometerDescription الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string KilometerDescription { get; private set; }

    /// <summary>
    /// KilometerPaymentYear of the AccountsPayableKimbDetail
    /// KilometerPaymentYear الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? KilometerPaymentYear { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableKimbDetail
    /// CompanyNumberShort الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableKimbDetail
    /// BranchNumber الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableKimbDetail
    /// BranchYear الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableKimbDetail
    /// BranchUser الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// ExpenseAmount of the AccountsPayableKimbDetail
    /// ExpenseAmount الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableKimbDetail
    /// CostCenterCode الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// BillAmount of the AccountsPayableKimbDetail
    /// BillAmount الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? BillAmount { get; private set; }

    /// <summary>
    /// KilometerCurrency of the AccountsPayableKimbDetail
    /// KilometerCurrency الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string KilometerCurrency { get; private set; }

    /// <summary>
    /// ValueAccountCode of the AccountsPayableKimbDetail
    /// ValueAccountCode الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string ValueAccountCode { get; private set; }

    /// <summary>
    /// ValueAccountCodeDetail of the AccountsPayableKimbDetail
    /// ValueAccountCodeDetail الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string ValueAccountCodeDetail { get; private set; }

    /// <summary>
    /// ValueDescription of the AccountsPayableKimbDetail
    /// ValueDescription الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public string ValueDescription { get; private set; }

    /// <summary>
    /// KilometerPostFlag of the AccountsPayableKimbDetail
    /// KilometerPostFlag الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? KilometerPostFlag { get; private set; }

    /// <summary>
    /// ValueJournalVoucherType of the AccountsPayableKimbDetail
    /// ValueJournalVoucherType الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? ValueJournalVoucherType { get; private set; }

    /// <summary>
    /// ValueJournalDocumentNumber of the AccountsPayableKimbDetail
    /// ValueJournalDocumentNumber الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? ValueJournalDocumentNumber { get; private set; }

    /// <summary>
    /// ValueJournalSerial of the AccountsPayableKimbDetail
    /// ValueJournalSerial الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? ValueJournalSerial { get; private set; }

    /// <summary>
    /// ComAmount of the AccountsPayableKimbDetail
    /// ComAmount الخاص بـ AccountsPayableKimbDetail
    /// </summary>
    public decimal? ComAmount { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public AccountsPayableKimbMaster AccountsPayableKimbMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

