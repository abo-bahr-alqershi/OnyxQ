using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillJournal Entity
/// </summary>
public class PerformaInvoiceBillJournal : Entity<PerformaInvoiceBillJournalId>
{
    private readonly List<AccountCurrency> _accountCurrency = new List<AccountCurrency>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private PerformaInvoiceBillJournal() { }

    public PerformaInvoiceBillJournal(PerformaInvoiceBillJournalId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillJournal
    /// المعرف الفريد لـ PerformaInvoiceBillJournal
    /// </summary>
    public PerformaInvoiceBillJournalId Id { get; private set; }

    /// <summary>
    /// BillNumber of the PerformaInvoiceBillJournal
    /// BillNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the PerformaInvoiceBillJournal
    /// BillSerial الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PerformaInvoiceBillJournal
    /// AccountDetailCode الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PerformaInvoiceBillJournal
    /// AccountDetailType الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// CashBankNumber of the PerformaInvoiceBillJournal
    /// CashBankNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? CashBankNumber { get; private set; }

    /// <summary>
    /// VendorCode of the PerformaInvoiceBillJournal
    /// VendorCode الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// CCode of the PerformaInvoiceBillJournal
    /// CCode الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// Amount of the PerformaInvoiceBillJournal
    /// Amount الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? Amount { get; private set; }

    /// <summary>
    /// AmountType of the PerformaInvoiceBillJournal
    /// AmountType الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// AccountRate of the PerformaInvoiceBillJournal
    /// AccountRate الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? AccountRate { get; private set; }

    /// <summary>
    /// DocDesc of the PerformaInvoiceBillJournal
    /// DocDesc الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string DocDesc { get; private set; }

    /// <summary>
    /// ProjectNumber of the PerformaInvoiceBillJournal
    /// ProjectNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PerformaInvoiceBillJournal
    /// ActivityNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// DocType of the PerformaInvoiceBillJournal
    /// DocType الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// RecordNumber of the PerformaInvoiceBillJournal
    /// RecordNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the PerformaInvoiceBillJournal
    /// LetterCreditNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// BranchNumber of the PerformaInvoiceBillJournal
    /// BranchNumber الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PerformaInvoiceBillJournal
    /// BranchYear الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PerformaInvoiceBillJournal
    /// BranchUser الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PerformaInvoiceBillJournal
    /// CompanyNumberShort الخاص بـ PerformaInvoiceBillJournal
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<AccountCurrency> AccountCurrency => _accountCurrency;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CostCenter> CostCenter => _costCenter;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

