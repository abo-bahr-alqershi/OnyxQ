using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerBankAccount Entity
/// </summary>
public class CustomerBankAccount : Entity<CustomerBankAccountId>
{

    private CustomerBankAccount() { }

    public CustomerBankAccount(CustomerBankAccountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerBankAccount
    /// المعرف الفريد لـ CustomerBankAccount
    /// </summary>
    public CustomerBankAccountId Id { get; private set; }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Customer Customer { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

