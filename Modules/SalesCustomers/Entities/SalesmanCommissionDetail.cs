using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionDetail Entity
/// </summary>
public class SalesmanCommissionDetail : Entity<SalesmanCommissionDetailId>
{
    private SalesmanCommissionDetail() { }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionDetail
    /// المعرف الفريد لـ SalesmanCommissionDetail
    /// </summary>
    public SalesmanCommissionDetailId Id { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCommissionDetail
    /// RepCode الخاص بـ SalesmanCommissionDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// CommissionType of the SalesmanCommissionDetail
    /// CommissionType الخاص بـ SalesmanCommissionDetail
    /// </summary>
    public decimal? CommissionType { get; private set; }

    /// <summary>
    /// PlanNumber of the SalesmanCommissionDetail
    /// PlanNumber الخاص بـ SalesmanCommissionDetail
    /// </summary>
    public decimal? PlanNumber { get; private set; }

    /// <summary>
    /// PlanSerial of the SalesmanCommissionDetail
    /// PlanSerial الخاص بـ SalesmanCommissionDetail
    /// </summary>
    public decimal? PlanSerial { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to SalesPlanMaster
    /// </summary>
    public SalesPlanMaster SalesPlanMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to SalesmanCommissionTypeMaster
    /// </summary>
    public SalesmanCommissionTypeMaster SalesmanCommissionTypeMaster { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Salesman
    /// </summary>
    public Salesman Salesman { get; private set; }
    #endregion
}
}
