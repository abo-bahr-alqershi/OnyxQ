using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.FinanceAccounting.Entities
{
/// <summary>
/// الكلاس يمثل حساب العميل ويحتوي على جميع خصائص حسابات العملاء
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
    /// معرف فريد لحساب العميل
    /// </summary>
    public CustomerAccountId Id { get; private set; }

    /// <summary>
    /// رقم السجل
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// نوع الحساب المختصر
    /// </summary>
    public decimal? AccountTypeShort { get; private set; }

    /// <summary>
    /// حالة التعطيل
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// تاريخ التعطيل
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// سبب التعطيل
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// رقم المستخدم الذي قام بالتعطيل
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// علاقة تجميعية مع الحسابات (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Account> Account => _account;
    /// <summary>
    /// علاقة تجميعية مع العملاء (متعدد إلى متعدد)
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    #endregion

    #region Methods
    // توضع هنا دوال منطق الدومين
    #endregion
}
}
