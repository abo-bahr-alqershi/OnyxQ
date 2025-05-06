using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PerformaInvoiceItemExpense Entity
/// </summary>
public class PerformaInvoiceItemExpense : Entity<PerformaInvoiceItemExpenseId>
{

    private PerformaInvoiceItemExpense() { }

    public PerformaInvoiceItemExpense(PerformaInvoiceItemExpenseId id, string accountCode, string accountCurrency, string itemCode, string itemUnit)
    {
        Id = id;
        AccountCode = accountCode;
        AccountCurrency = accountCurrency;
        ItemCode = itemCode;
        ItemUnit = itemUnit;
    }

    /// <summary>
    /// The unique identifier for the PerformaInvoiceItemExpense
    /// المعرف الفريد لـ PerformaInvoiceItemExpense
    /// </summary>
    public PerformaInvoiceItemExpenseId Id { get; private set; }

    /// <summary>
    /// AccountCode of the PerformaInvoiceItemExpense
    /// AccountCode الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountCurrency of the PerformaInvoiceItemExpense
    /// AccountCurrency الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// ItemCode of the PerformaInvoiceItemExpense
    /// ItemCode الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the PerformaInvoiceItemExpense
    /// ItemUnit الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemPrice of the PerformaInvoiceItemExpense
    /// ItemPrice الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public decimal? ItemPrice { get; private set; }

    /// <summary>
    /// ItemExpensePercent of the PerformaInvoiceItemExpense
    /// ItemExpensePercent الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public decimal? ItemExpensePercent { get; private set; }

    /// <summary>
    /// ItemExpenseAmount of the PerformaInvoiceItemExpense
    /// ItemExpenseAmount الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public decimal? ItemExpenseAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the PerformaInvoiceItemExpense
    /// RecordNumber الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// PSize of the PerformaInvoiceItemExpense
    /// PSize الخاص بـ PerformaInvoiceItemExpense
    /// </summary>
    public decimal? PSize { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

