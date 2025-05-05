using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillExpand Entity
/// </summary>
public class PerformaInvoiceBillExpand : Entity<PerformaInvoiceBillExpandId>
{
    private readonly List<Activity> _activity = new List<Activity>();
    private readonly List<PerformaInvoiceBillMaster> _performaInvoiceBillMaster = new List<PerformaInvoiceBillMaster>();
    private readonly List<Account> _account = new List<Account>();
    private readonly List<Project> _project = new List<Project>();
    private readonly List<CostCenter> _costCenter = new List<CostCenter>();

    private PerformaInvoiceBillExpand() { }

    public PerformaInvoiceBillExpand(PerformaInvoiceBillExpandId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceBillExpand
    /// المعرف الفريد لـ PerformaInvoiceBillExpand
    /// </summary>
    public PerformaInvoiceBillExpandId Id { get; private set; }

    /// <summary>
    /// BillNumber of the PerformaInvoiceBillExpand
    /// BillNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// AccountDetailCode of the PerformaInvoiceBillExpand
    /// AccountDetailCode الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the PerformaInvoiceBillExpand
    /// AccountDetailType الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// ExpenseAccountCurrency of the PerformaInvoiceBillExpand
    /// ExpenseAccountCurrency الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string ExpenseAccountCurrency { get; private set; }

    /// <summary>
    /// ExpenseCashBankNumber of the PerformaInvoiceBillExpand
    /// ExpenseCashBankNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? ExpenseCashBankNumber { get; private set; }

    /// <summary>
    /// VendorCode of the PerformaInvoiceBillExpand
    /// VendorCode الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string VendorCode { get; private set; }

    /// <summary>
    /// ExpenseAmount of the PerformaInvoiceBillExpand
    /// ExpenseAmount الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? ExpenseAmount { get; private set; }

    /// <summary>
    /// ExpenseInvoiceAmount of the PerformaInvoiceBillExpand
    /// ExpenseInvoiceAmount الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? ExpenseInvoiceAmount { get; private set; }

    /// <summary>
    /// ExpenseRate of the PerformaInvoiceBillExpand
    /// ExpenseRate الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? ExpenseRate { get; private set; }

    /// <summary>
    /// RecordNumber of the PerformaInvoiceBillExpand
    /// RecordNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// LetterCreditNumber of the PerformaInvoiceBillExpand
    /// LetterCreditNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string LetterCreditNumber { get; private set; }

    /// <summary>
    /// ExpenseDescription of the PerformaInvoiceBillExpand
    /// ExpenseDescription الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string ExpenseDescription { get; private set; }

    /// <summary>
    /// VatPercent of the PerformaInvoiceBillExpand
    /// VatPercent الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// VatAmount of the PerformaInvoiceBillExpand
    /// VatAmount الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? VatAmount { get; private set; }

    /// <summary>
    /// BranchNumber of the PerformaInvoiceBillExpand
    /// BranchNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the PerformaInvoiceBillExpand
    /// BranchYear الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the PerformaInvoiceBillExpand
    /// BranchUser الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? BranchUser { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the PerformaInvoiceBillExpand
    /// CompanyNumberShort الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// CalcTypeNumberTax of the PerformaInvoiceBillExpand
    /// CalcTypeNumberTax الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? CalcTypeNumberTax { get; private set; }

    /// <summary>
    /// ExpenseNumber of the PerformaInvoiceBillExpand
    /// ExpenseNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? ExpenseNumber { get; private set; }

    /// <summary>
    /// BillNumberVoucherCode of the PerformaInvoiceBillExpand
    /// BillNumberVoucherCode الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string BillNumberVoucherCode { get; private set; }

    /// <summary>
    /// BillDateVoucherCode of the PerformaInvoiceBillExpand
    /// BillDateVoucherCode الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public DateTime? BillDateVoucherCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Activity> Activity => _activity;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<PerformaInvoiceBillMaster> PerformaInvoiceBillMaster => _performaInvoiceBillMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Account> Account => _account;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Project> Project => _project;
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

