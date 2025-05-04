using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerGroup Entity
/// </summary>
public class CustomerGroup : Entity<CustomerGroupId>
{
    private CustomerGroup() { }

    /// <summary>
    /// The unique identifier for the CustomerGroup
    /// المعرف الفريد لـ CustomerGroup
    /// </summary>
    public CustomerGroupId Id { get; private set; }

    /// <summary>
    /// CGroupCode of the CustomerGroup
    /// CGroupCode الخاص بـ CustomerGroup
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CGroupAName of the CustomerGroup
    /// CGroupAName الخاص بـ CustomerGroup
    /// </summary>
    public string CGroupAName { get; private set; }

    /// <summary>
    /// CGroupEName of the CustomerGroup
    /// CGroupEName الخاص بـ CustomerGroup
    /// </summary>
    public string CGroupEName { get; private set; }

    /// <summary>
    /// CACode of the CustomerGroup
    /// CACode الخاص بـ CustomerGroup
    /// </summary>
    public string CACode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CustomerGroup to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Account
    /// </summary>
    public Account Account { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to CustomerCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CustomerCommissionSetupDetail> CustomerCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to SalesmanCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCommissionSetupDetail> SalesmanCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to PromotionCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<PromotionCommissionSetupDetail> PromotionCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to CollectorCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CollectorCommissionSetupDetail> CollectorCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerGroup to EmployeeCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<EmployeeCommissionSetupDetail> EmployeeCommissionSetupDetails { get; private set; }
    #endregion
}
}
