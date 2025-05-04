using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CustomerCommissionSetupDetail Entity
/// </summary>
public class CustomerCommissionSetupDetail : Entity<CustomerCommissionSetupDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<CustomerCommissionSetupMaster> _customerCommissionSetupMaster = new List<CustomerCommissionSetupMaster>();
    private readonly List<Region> _region = new List<Region>();
    private readonly List<Customer> _customer = new List<Customer>();
    private readonly List<CustomerClass> _customerClass = new List<CustomerClass>();
    private readonly List<CustomerDegree> _customerDegree = new List<CustomerDegree>();
    private readonly List<CustomerGroup> _customerGroup = new List<CustomerGroup>();
    private readonly List<GroupDetail> _groupDetail = new List<GroupDetail>();
    private readonly List<ItemType> _itemType = new List<ItemType>();

    private CustomerCommissionSetupDetail() { }

    public CustomerCommissionSetupDetail(CustomerCommissionSetupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CustomerCommissionSetupDetail
    /// المعرف الفريد لـ CustomerCommissionSetupDetail
    /// </summary>
    public CustomerCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// BillDocumentType of the CustomerCommissionSetupDetail
    /// BillDocumentType الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// FValue of the CustomerCommissionSetupDetail
    /// FValue الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the CustomerCommissionSetupDetail
    /// TValue الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the CustomerCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the CustomerCommissionSetupDetail
    /// CommissionAmount الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the CustomerCommissionSetupDetail
    /// SliceDescription الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the CustomerCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// ItemUnit of the CustomerCommissionSetupDetail
    /// ItemUnit الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// PSize of the CustomerCommissionSetupDetail
    /// PSize الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// NetSalesQuantity of the CustomerCommissionSetupDetail
    /// NetSalesQuantity الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? NetSalesQuantity { get; private set; }

    /// <summary>
    /// FPayPercentShort of the CustomerCommissionSetupDetail
    /// FPayPercentShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? FPayPercentShort { get; private set; }

    /// <summary>
    /// TPayPercentShort of the CustomerCommissionSetupDetail
    /// TPayPercentShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? TPayPercentShort { get; private set; }

    /// <summary>
    /// PaymentAmount of the CustomerCommissionSetupDetail
    /// PaymentAmount الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? PaymentAmount { get; private set; }

    /// <summary>
    /// GroupNumber of the CustomerCommissionSetupDetail
    /// GroupNumber الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// CClassTyp of the CustomerCommissionSetupDetail
    /// CClassTyp الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? CClassTyp { get; private set; }

    /// <summary>
    /// PaymentPercentShort of the CustomerCommissionSetupDetail
    /// PaymentPercentShort الخاص بـ CustomerCommissionSetupDetail
    /// </summary>
    public decimal? PaymentPercentShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerCommissionSetupMaster> CustomerCommissionSetupMaster => _customerCommissionSetupMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Region> Region => _region;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Customer> Customer => _customer;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerClass> CustomerClass => _customerClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerDegree> CustomerDegree => _customerDegree;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerGroup> CustomerGroup => _customerGroup;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<GroupDetail> GroupDetail => _groupDetail;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemType> ItemType => _itemType;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
