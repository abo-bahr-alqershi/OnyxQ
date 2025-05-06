using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// AccountsPayableExpense Entity
/// </summary>
public class AccountsPayableExpense : Entity<AccountsPayableExpenseId>
{

    private AccountsPayableExpense() { }

    public AccountsPayableExpense(AccountsPayableExpenseId id, decimal? expenseNumber)
    {
        Id = id;
        ExpenseNumber = expenseNumber;
    }

    /// <summary>
    /// The unique identifier for the AccountsPayableExpense
    /// المعرف الفريد لـ AccountsPayableExpense
    /// </summary>
    public AccountsPayableExpenseId Id { get; private set; }

    /// <summary>
    /// ExpenseNumber of the AccountsPayableExpense
    /// ExpenseNumber الخاص بـ AccountsPayableExpense
    /// </summary>
    public decimal? ExpenseNumber { get; private set; }

    /// <summary>
    /// ExpenseLastName of the AccountsPayableExpense
    /// ExpenseLastName الخاص بـ AccountsPayableExpense
    /// </summary>
    public string ExpenseLastName { get; private set; }

    /// <summary>
    /// ExpenseFirstName of the AccountsPayableExpense
    /// ExpenseFirstName الخاص بـ AccountsPayableExpense
    /// </summary>
    public string ExpenseFirstName { get; private set; }

    /// <summary>
    /// AccountEntryInTransactionFlag of the AccountsPayableExpense
    /// AccountEntryInTransactionFlag الخاص بـ AccountsPayableExpense
    /// </summary>
    public decimal? AccountEntryInTransactionFlag { get; private set; }

    /// <summary>
    /// AccountCode of the AccountsPayableExpense
    /// AccountCode الخاص بـ AccountsPayableExpense
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AmountType of the AccountsPayableExpense
    /// AmountType الخاص بـ AccountsPayableExpense
    /// </summary>
    public decimal? AmountType { get; private set; }

    /// <summary>
    /// Amount of the AccountsPayableExpense
    /// Amount الخاص بـ AccountsPayableExpense
    /// </summary>
    public decimal? Amount { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

