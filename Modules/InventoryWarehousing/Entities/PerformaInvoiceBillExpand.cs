using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.Activities.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceBillExpand Entity
/// </summary>
public class PerformaInvoiceBillExpand : Entity<PerformaInvoiceBillExpandId>
{
    private PerformaInvoiceBillExpand() { }

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
    /// BillSerial of the PerformaInvoiceBillExpand
    /// BillSerial الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// ExpenseAccountCode of the PerformaInvoiceBillExpand
    /// ExpenseAccountCode الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string ExpenseAccountCode { get; private set; }

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
    /// CostCenterCode of the PerformaInvoiceBillExpand
    /// CostCenterCode الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the PerformaInvoiceBillExpand
    /// ProjectNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the PerformaInvoiceBillExpand
    /// ActivityNumber الخاص بـ PerformaInvoiceBillExpand
    /// </summary>
    public string ActivityNumber { get; private set; }

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
    /// ManyToOne relationship to Activity
    /// </summary>
    public Activity Activity { get; private set; }
    /// <summary>
    /// ManyToOne relationship to PerformaInvoiceBillMaster
    /// </summary>
    public PerformaInvoiceBillMaster PerformaInvoiceBillMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Project
    /// </summary>
    public Project Project { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CostCenter
    /// </summary>
    public CostCenter CostCenter { get; private set; }
    #endregion
}
}
