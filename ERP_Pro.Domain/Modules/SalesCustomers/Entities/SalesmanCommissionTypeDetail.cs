using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionTypeDetail Entity
/// </summary>
public class SalesmanCommissionTypeDetail : Entity<SalesmanCommissionTypeDetailId>
{

    private SalesmanCommissionTypeDetail() { }

    public SalesmanCommissionTypeDetail(SalesmanCommissionTypeDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionTypeDetail
    /// المعرف الفريد لـ SalesmanCommissionTypeDetail
    /// </summary>
    public SalesmanCommissionTypeDetailId Id { get; private set; }

    /// <summary>
    /// CommissionSliceNumber of the SalesmanCommissionTypeDetail
    /// CommissionSliceNumber الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public decimal? CommissionSliceNumber { get; private set; }

    /// <summary>
    /// CommissionSliceType of the SalesmanCommissionTypeDetail
    /// CommissionSliceType الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public decimal? CommissionSliceType { get; private set; }

    /// <summary>
    /// FAmountPercent of the SalesmanCommissionTypeDetail
    /// FAmountPercent الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public decimal? FAmountPercent { get; private set; }

    /// <summary>
    /// TAmountPercent of the SalesmanCommissionTypeDetail
    /// TAmountPercent الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public decimal? TAmountPercent { get; private set; }

    /// <summary>
    /// CommissionAmountType of the SalesmanCommissionTypeDetail
    /// CommissionAmountType الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public decimal? CommissionAmountType { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCommissionTypeDetail
    /// CommissionAmount الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// CommissionDescription of the SalesmanCommissionTypeDetail
    /// CommissionDescription الخاص بـ SalesmanCommissionTypeDetail
    /// </summary>
    public string CommissionDescription { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SalesmanCommissionTypeMaster SalesmanCommissionTypeMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

