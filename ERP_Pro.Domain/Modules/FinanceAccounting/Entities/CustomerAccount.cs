using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// CustomerAccount Entity
/// </summary>
public class CustomerAccount : Entity<CustomerAccountId>
{
    private readonly List<Account> _account = new List<Account>();
    private readonly List<Customer> _customer = new List<Customer>();

    private CustomerAccount() { }

    public CustomerAccount(CustomerAccountId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerAccount
    /// المعرف الفريد لـ CustomerAccount
    /// </summary>
    public CustomerAccountId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the CustomerAccount
    /// RecordNumber الخاص بـ CustomerAccount
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// AccountTypeShort of the CustomerAccount
    /// AccountTypeShort الخاص بـ CustomerAccount
    /// </summary>
    public decimal? AccountTypeShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the CustomerAccount
    /// InactiveFlag الخاص بـ CustomerAccount
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the CustomerAccount
    /// InactiveDate الخاص بـ CustomerAccount
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the CustomerAccount
    /// InactiveReason الخاص بـ CustomerAccount
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CustomerAccount
    /// InactivatedByUserId الخاص بـ CustomerAccount
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Account> Account => _account;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
