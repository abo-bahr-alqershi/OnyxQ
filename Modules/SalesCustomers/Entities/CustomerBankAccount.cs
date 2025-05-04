using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerBankAccount Entity
/// </summary>
public class CustomerBankAccount : Entity<CustomerBankAccountId>
{
    private CustomerBankAccount() { }

    /// <summary>
    /// The unique identifier for the CustomerBankAccount
    /// المعرف الفريد لـ CustomerBankAccount
    /// </summary>
    public CustomerBankAccountId Id { get; private set; }

    /// <summary>
    /// CCode of the CustomerBankAccount
    /// CCode الخاص بـ CustomerBankAccount
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// BankACode of the CustomerBankAccount
    /// BankACode الخاص بـ CustomerBankAccount
    /// </summary>
    public string BankACode { get; private set; }

    /// <summary>
    /// AccountCurrency of the CustomerBankAccount
    /// AccountCurrency الخاص بـ CustomerBankAccount
    /// </summary>
    public string AccountCurrency { get; private set; }

    /// <summary>
    /// DfltFlg of the CustomerBankAccount
    /// DfltFlg الخاص بـ CustomerBankAccount
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to Customer
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion
}
}
