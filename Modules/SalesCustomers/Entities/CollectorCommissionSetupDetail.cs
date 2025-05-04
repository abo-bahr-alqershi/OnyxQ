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
    private CollectorCommissionSetupDetail() { }

    /// <summary>
    /// The unique identifier for the CollectorCommissionSetupDetail
    /// المعرف الفريد لـ CollectorCommissionSetupDetail
    /// </summary>
    public CollectorCommissionSetupDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CollectorCommissionSetupDetail
    /// CommissionTypeShort الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CollectorCommissionSetupDetail
    /// ColumnNumberShort الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CGroupCode of the CollectorCommissionSetupDetail
    /// CGroupCode الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the CollectorCommissionSetupDetail
    /// CClass الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// RegionCode of the CollectorCommissionSetupDetail
    /// RegionCode الخاص بـ CollectorCommissionSetupDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

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
    /// ManyToOne relationship to CollectorCommissionSetupMaster
    /// </summary>
    public CollectorCommissionSetupMaster CollectorCommissionSetupMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerClass
    /// </summary>
    public CustomerClass CustomerClass { get; private set; }
    /// <summary>
    /// ManyToOne relationship to CustomerGroup
    /// </summary>
    public CustomerGroup CustomerGroup { get; private set; }
    #endregion
}
}
