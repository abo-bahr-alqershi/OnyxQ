using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectorCommissionSetupDetail Entity
/// </summary>
public class CollectorCommissionSetupDetail : Entity<CollectorCommissionSetupDetailId>
{
    private readonly List<CollectorCommissionSetupMaster> _collectorCommissionSetupMaster = new List<CollectorCommissionSetupMaster>();
    private readonly List<Region> _region = new List<Region>();
    private readonly List<CustomerClass> _customerClass = new List<CustomerClass>();
    private readonly List<CustomerGroup> _customerGroup = new List<CustomerGroup>();

    private CollectorCommissionSetupDetail() { }

    public CollectorCommissionSetupDetail(CollectorCommissionSetupDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CollectorCommissionSetupDetail
    /// المعرف الفريد لـ CollectorCommissionSetupDetail
    /// </summary>
    public CollectorCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CollectorCommissionSetupDetail
    /// ColumnNumberShort الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// FValue of the CollectorCommissionSetupDetail
    /// FValue الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? FValue { get; private set; }

    /// <summary>
    /// TValue of the CollectorCommissionSetupDetail
    /// TValue الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? TValue { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the CollectorCommissionSetupDetail
    /// CommissionAmountTypeShort الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the CollectorCommissionSetupDetail
    /// CommissionAmount الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// SliceDescription of the CollectorCommissionSetupDetail
    /// SliceDescription الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public string SliceDescription { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the CollectorCommissionSetupDetail
    /// CommissionSliceNumber الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CollectorCommissionSetupMaster> CollectorCommissionSetupMaster => _collectorCommissionSetupMaster;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<Region> Region => _region;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerClass> CustomerClass => _customerClass;
    /// <summary>
    /// Collection relationship: ManyToMany
    /// </summary>
    public ICollection<CustomerGroup> CustomerGroup => _customerGroup;
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
