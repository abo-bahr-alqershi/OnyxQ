using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.InventoryWarehousing.Entities;
using ERP_Pro.Domain.ERP.SettingsParameters.Entities;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// EmployeeCommissionSetupDetail Entity
/// </summary>
public class EmployeeCommissionSetupDetail : Entity<EmployeeCommissionSetupDetailId>
{
    private readonly List<ItemMaster> _itemMaster = new List<ItemMaster>();
    private readonly List<CustomerClass> _customerClass = new List<CustomerClass>();
    private readonly List<CustomerGroup> _customerGroup = new List<CustomerGroup>();
    private readonly List<GroupDetail> _groupDetail = new List<GroupDetail>();
    private readonly List<ItemType> _itemType = new List<ItemType>();
    private readonly List<Measurement> _measurement = new List<Measurement>();
    private readonly List<EmployeeCommissionSetupMaster> _employeeCommissionSetupMaster = new List<EmployeeCommissionSetupMaster>();

    private EmployeeCommissionSetupDetail() { }

    public EmployeeCommissionSetupDetail(EmployeeCommissionSetupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the EmployeeCommissionSetupDetail
    /// المعرف الفريد لـ EmployeeCommissionSetupDetail
    /// </summary>
    public EmployeeCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// EmpNo of the EmployeeCommissionSetupDetail
    /// EmpNo الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? EmpNo { get; private set; }

    /// <summary>
    /// FValue of the EmployeeCommissionSetupDetail
    /// FValue الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the EmployeeCommissionSetupDetail
    /// TValue الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the EmployeeCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the EmployeeCommissionSetupDetail
    /// CommissionAmount الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the EmployeeCommissionSetupDetail
    /// SliceDescription الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the EmployeeCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// PSize of the EmployeeCommissionSetupDetail
    /// PSize الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? PSize { get; private set; }

    /// <summary>
    /// EmpType of the EmployeeCommissionSetupDetail
    /// EmpType الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? EmpType { get; private set; }

    /// <summary>
    /// BillDocumentType of the EmployeeCommissionSetupDetail
    /// BillDocumentType الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public decimal? BillDocumentType { get; private set; }

    /// <summary>
    /// GroupCode of the EmployeeCommissionSetupDetail
    /// GroupCode الخاص بـ EmployeeCommissionSetupDetail
    /// </summary>
    public string GroupCode { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<ItemMaster> ItemMaster => _itemMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerClass> CustomerClass => _customerClass;
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
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Measurement> Measurement => _measurement;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<EmployeeCommissionSetupMaster> EmployeeCommissionSetupMaster => _employeeCommissionSetupMaster;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

