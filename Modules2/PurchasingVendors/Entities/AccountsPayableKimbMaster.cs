using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableKimbMaster Entity
/// </summary>
public class AccountsPayableKimbMaster : Entity<AccountsPayableKimbMasterId>
{

    private AccountsPayableKimbMaster() { }

    public AccountsPayableKimbMaster(AccountsPayableKimbMasterId id, decimal? docSer)
    {
        Id = id;
        DocSer = docSer;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableKimbMaster
    /// المعرف الفريد لـ AccountsPayableKimbMaster
    /// </summary>
    public AccountsPayableKimbMasterId Id { get; private set; }

    /// <summary>
    /// DocNo of the AccountsPayableKimbMaster
    /// DocNo الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the AccountsPayableKimbMaster
    /// DocSer الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// KilometerType of the AccountsPayableKimbMaster
    /// KilometerType الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? KilometerType { get; private set; }

    /// <summary>
    /// BillNumber of the AccountsPayableKimbMaster
    /// BillNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the AccountsPayableKimbMaster
    /// BillSerial الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the AccountsPayableKimbMaster
    /// LetterCreditNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// LetterCreditSerial of the AccountsPayableKimbMaster
    /// LetterCreditSerial الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? LetterCreditSerial { get; private set; }

    /// <summary>
    /// DocDate of the AccountsPayableKimbMaster
    /// DocDate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// AccountCode of the AccountsPayableKimbMaster
    /// AccountCode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// VendorCode of the AccountsPayableKimbMaster
    /// VendorCode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// AccountRate of the AccountsPayableKimbMaster
    /// AccountRate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// CostCenterCode of the AccountsPayableKimbMaster
    /// CostCenterCode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the AccountsPayableKimbMaster
    /// ProjectNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the AccountsPayableKimbMaster
    /// ActivityNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// BillAccountAmount of the AccountsPayableKimbMaster
    /// BillAccountAmount الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BillAccountAmount { get; private set; }

    /// <summary>
    /// BillAccountCurrency of the AccountsPayableKimbMaster
    /// BillAccountCurrency الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string BillAccountCurrency { get; private set; }

    /// <summary>
    /// BankNumber of the AccountsPayableKimbMaster
    /// BankNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BankNumber { get; private set; }

    /// <summary>
    /// CommissionACode of the AccountsPayableKimbMaster
    /// CommissionACode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string CommissionACode { get; private set; }

    /// <summary>
    /// CommissionAmount of the AccountsPayableKimbMaster
    /// CommissionAmount الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// BankExpenseAccountCode of the AccountsPayableKimbMaster
    /// BankExpenseAccountCode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string BankExpenseAccountCode { get; private set; }

    /// <summary>
    /// BankExpenseAmount of the AccountsPayableKimbMaster
    /// BankExpenseAmount الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BankExpenseAmount { get; private set; }

    /// <summary>
    /// BankExpenseCurrency of the AccountsPayableKimbMaster
    /// BankExpenseCurrency الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string BankExpenseCurrency { get; private set; }

    /// <summary>
    /// MarginAccountCode of the AccountsPayableKimbMaster
    /// MarginAccountCode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string MarginAccountCode { get; private set; }

    /// <summary>
    /// MarginAmount of the AccountsPayableKimbMaster
    /// MarginAmount الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? MarginAmount { get; private set; }

    /// <summary>
    /// MarginCurrency of the AccountsPayableKimbMaster
    /// MarginCurrency الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string MarginCurrency { get; private set; }

    /// <summary>
    /// MarginReceived of the AccountsPayableKimbMaster
    /// MarginReceived الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? MarginReceived { get; private set; }

    /// <summary>
    /// ExpenseAffectType of the AccountsPayableKimbMaster
    /// ExpenseAffectType الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? ExpenseAffectType { get; private set; }

    /// <summary>
    /// NoDays of the AccountsPayableKimbMaster
    /// NoDays الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? NoDays { get; private set; }

    /// <summary>
    /// KCount of the AccountsPayableKimbMaster
    /// KCount الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? KCount { get; private set; }

    /// <summary>
    /// BillDate of the AccountsPayableKimbMaster
    /// BillDate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// DocPost of the AccountsPayableKimbMaster
    /// DocPost الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? DocPost { get; private set; }

    /// <summary>
    /// PostUserId of the AccountsPayableKimbMaster
    /// PostUserId الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? PostUserId { get; private set; }

    /// <summary>
    /// PostDate of the AccountsPayableKimbMaster
    /// PostDate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public DateTime? PostDate { get; private set; }

    /// <summary>
    /// UnpostUserId of the AccountsPayableKimbMaster
    /// UnpostUserId الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? UnpostUserId { get; private set; }

    /// <summary>
    /// UnpostDate of the AccountsPayableKimbMaster
    /// UnpostDate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public DateTime? UnpostDate { get; private set; }

    /// <summary>
    /// MarginRate of the AccountsPayableKimbMaster
    /// MarginRate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? MarginRate { get; private set; }

    /// <summary>
    /// BankExpenseRate of the AccountsPayableKimbMaster
    /// BankExpenseRate الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BankExpenseRate { get; private set; }

    /// <summary>
    /// DocDesc of the AccountsPayableKimbMaster
    /// DocDesc الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ReferenceNumber of the AccountsPayableKimbMaster
    /// ReferenceNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string ReferenceNumber { get; private set; }

    /// <summary>
    /// JournalVoucherTypeFull of the AccountsPayableKimbMaster
    /// JournalVoucherTypeFull الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? JournalVoucherTypeFull { get; private set; }

    /// <summary>
    /// JournalDocumentNumber of the AccountsPayableKimbMaster
    /// JournalDocumentNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? JournalDocumentNumber { get; private set; }

    /// <summary>
    /// JournalSerial of the AccountsPayableKimbMaster
    /// JournalSerial الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? JournalSerial { get; private set; }

    /// <summary>
    /// KimbAccountCode of the AccountsPayableKimbMaster
    /// KimbAccountCode الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public string KimbAccountCode { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the AccountsPayableKimbMaster
    /// CompanyNumberShort الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the AccountsPayableKimbMaster
    /// BranchNumber الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the AccountsPayableKimbMaster
    /// BranchYear الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the AccountsPayableKimbMaster
    /// BranchUser الخاص بـ AccountsPayableKimbMaster
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

