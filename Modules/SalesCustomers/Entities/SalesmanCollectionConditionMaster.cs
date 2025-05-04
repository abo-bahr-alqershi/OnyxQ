using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCollectionConditionMaster Entity
/// </summary>
public class SalesmanCollectionConditionMaster : Entity<SalesmanCollectionConditionMasterId>
{
    private SalesmanCollectionConditionMaster() { }

    /// <summary>
    /// The unique identifier for the SalesmanCollectionConditionMaster
    /// المعرف الفريد لـ SalesmanCollectionConditionMaster
    /// </summary>
    public SalesmanCollectionConditionMasterId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the SalesmanCollectionConditionMaster
    /// CommissionTypeShort الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the SalesmanCollectionConditionMaster
    /// CommissionTypeLastName الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the SalesmanCollectionConditionMaster
    /// CommissionTypeFirstName الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// SalesmanCommissionType of the SalesmanCollectionConditionMaster
    /// SalesmanCommissionType الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? SalesmanCommissionType { get; private set; }

    /// <summary>
    /// SalesmanRegionCommissionType of the SalesmanCollectionConditionMaster
    /// SalesmanRegionCommissionType الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? SalesmanRegionCommissionType { get; private set; }

    /// <summary>
    /// SalesmanCustomerCommissionType of the SalesmanCollectionConditionMaster
    /// SalesmanCustomerCommissionType الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? SalesmanCustomerCommissionType { get; private set; }

    /// <summary>
    /// CommissionSlicesType of the SalesmanCollectionConditionMaster
    /// CommissionSlicesType الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? CommissionSlicesType { get; private set; }

    /// <summary>
    /// CalcPaidMethod of the SalesmanCollectionConditionMaster
    /// CalcPaidMethod الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? CalcPaidMethod { get; private set; }

    /// <summary>
    /// CommissionMethodGuarantee of the SalesmanCollectionConditionMaster
    /// CommissionMethodGuarantee الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? CommissionMethodGuarantee { get; private set; }

    /// <summary>
    /// ColumnDistributionType of the SalesmanCollectionConditionMaster
    /// ColumnDistributionType الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? ColumnDistributionType { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the SalesmanCollectionConditionMaster
    /// CommissionAmountTypeShort الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCollectionConditionMaster
    /// CommissionAmount الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the SalesmanCollectionConditionMaster
    /// InactiveFlag الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the SalesmanCollectionConditionMaster
    /// InactiveReason الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the SalesmanCollectionConditionMaster
    /// InactiveDate الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the SalesmanCollectionConditionMaster
    /// InactivatedByUserId الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the SalesmanCollectionConditionMaster
    /// CommissionDescriptionShort الخاص بـ SalesmanCollectionConditionMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: SalesmanCollectionConditionMaster to SalesmanCollectionConditionDetail
    /// </summary>
    public IReadOnlyCollection<SalesmanCollectionConditionDetail> SalesmanCollectionConditionDetails { get; private set; }
    #endregion
}
}
