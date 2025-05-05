using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectorCommissionCalculationDetail Entity
/// </summary>
public class CollectorCommissionCalculationDetail : Entity<CollectorCommissionCalculationDetailId>
{

    private CollectorCommissionCalculationDetail() { }

    public CollectorCommissionCalculationDetail(CollectorCommissionCalculationDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CollectorCommissionCalculationDetail
    /// المعرف الفريد لـ CollectorCommissionCalculationDetail
    /// </summary>
    public CollectorCommissionCalculationDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the CollectorCommissionCalculationDetail
    /// DocNo الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CollectorCommissionCalculationDetail
    /// ColumnNumberShort الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CGroupCode of the CollectorCommissionCalculationDetail
    /// CGroupCode الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the CollectorCommissionCalculationDetail
    /// CClass الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// RegionCode of the CollectorCommissionCalculationDetail
    /// RegionCode الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CommissionPercent of the CollectorCommissionCalculationDetail
    /// CommissionPercent الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmount of the CollectorCommissionCalculationDetail
    /// CommissionAmount الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the CollectorCommissionCalculationDetail
    /// CommissionDescriptionShort الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    /// <summary>
    /// ColumnAmount of the CollectorCommissionCalculationDetail
    /// ColumnAmount الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? ColumnAmount { get; private set; }

    /// <summary>
    /// RecordNumber of the CollectorCommissionCalculationDetail
    /// RecordNumber الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CollectorCommissionCalculationDetail
    /// CompanyNumberShort الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the CollectorCommissionCalculationDetail
    /// BranchNumber الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the CollectorCommissionCalculationDetail
    /// BranchYear الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the CollectorCommissionCalculationDetail
    /// BranchUser الخاص بـ CollectorCommissionCalculationDetail
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public CollectorCommissionCalculationMaster CollectorCommissionCalculationMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

