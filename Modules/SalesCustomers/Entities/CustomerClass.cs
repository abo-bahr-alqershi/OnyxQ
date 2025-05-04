using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerClass Entity
/// </summary>
public class CustomerClass : Entity<CustomerClassId>
{
    private CustomerClass() { }

    /// <summary>
    /// The unique identifier for the CustomerClass
    /// المعرف الفريد لـ CustomerClass
    /// </summary>
    public CustomerClassId Id { get; private set; }

    /// <summary>
    /// CClass of the CustomerClass
    /// CClass الخاص بـ CustomerClass
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// CClassName of the CustomerClass
    /// CClassName الخاص بـ CustomerClass
    /// </summary>
    public string CClassName { get; private set; }

    /// <summary>
    /// CClassEName of the CustomerClass
    /// CClassEName الخاص بـ CustomerClass
    /// </summary>
    public string CClassEName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CustomerClass to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to CustomerRequest
    /// </summary>
    public IReadOnlyCollection<CustomerRequest> CustomerRequests { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to SalesDiscount
    /// </summary>
    public IReadOnlyCollection<SalesDiscount> SalesDiscounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to SalesFreeQuantity
    /// </summary>
    public IReadOnlyCollection<SalesFreeQuantity> SalesFreeQuantities { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to CustomerCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CustomerCommissionSetupDetail> CustomerCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to SalesmanCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCommissionSetupDetail> SalesmanCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to PromotionCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<PromotionCommissionSetupDetail> PromotionCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to CollectorCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CollectorCommissionSetupDetail> CollectorCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to EmployeeCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<EmployeeCommissionSetupDetail> EmployeeCommissionSetupDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to ItemDetail
    /// </summary>
    public IReadOnlyCollection<ItemDetail> ItemDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to Warehouse
    /// </summary>
    public IReadOnlyCollection<Warehouse> Warehouses { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to WarehouseGroup
    /// </summary>
    public IReadOnlyCollection<WarehouseGroup> WarehouseGroups { get; private set; }
    /// <summary>
    /// One-to-many relationship: CustomerClass to GroupDetail
    /// </summary>
    public IReadOnlyCollection<GroupDetail> GroupDetails { get; private set; }
    #endregion
}
}
