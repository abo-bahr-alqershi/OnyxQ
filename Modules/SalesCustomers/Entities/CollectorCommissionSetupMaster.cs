using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectorCommissionSetupMaster Entity
/// </summary>
public class CollectorCommissionSetupMaster : Entity<CollectorCommissionSetupMasterId>
{
    private CollectorCommissionSetupMaster() { }

    /// <summary>
    /// The unique identifier for the CollectorCommissionSetupMaster
    /// المعرف الفريد لـ CollectorCommissionSetupMaster
    /// </summary>
    public CollectorCommissionSetupMasterId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CollectorCommissionSetupMaster
    /// CommissionTypeShort الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the CollectorCommissionSetupMaster
    /// CommissionTypeLastName الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the CollectorCommissionSetupMaster
    /// CommissionTypeFirstName الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// CustomerCommissionType of the CollectorCommissionSetupMaster
    /// CustomerCommissionType الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CustomerCommissionType { get; private set; }

    /// <summary>
    /// ColumnCommissionType of the CollectorCommissionSetupMaster
    /// ColumnCommissionType الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? ColumnCommissionType { get; private set; }

    /// <summary>
    /// PaidDistributionType of the CollectorCommissionSetupMaster
    /// PaidDistributionType الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? PaidDistributionType { get; private set; }

    /// <summary>
    /// CommissionSlicesType of the CollectorCommissionSetupMaster
    /// CommissionSlicesType الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CommissionSlicesType { get; private set; }

    /// <summary>
    /// SeparateTargetAddTargetShort of the CollectorCommissionSetupMaster
    /// SeparateTargetAddTargetShort الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? SeparateTargetAddTargetShort { get; private set; }

    /// <summary>
    /// CommissionCalcTargetMethodShort of the CollectorCommissionSetupMaster
    /// CommissionCalcTargetMethodShort الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionCalcAdditionalTargetMethodShort of the CollectorCommissionSetupMaster
    /// CommissionCalcAdditionalTargetMethodShort الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CommissionCalcAdditionalTargetMethodShort { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the CollectorCommissionSetupMaster
    /// CommissionAmountTypeShort الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the CollectorCommissionSetupMaster
    /// CommissionAmount الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// InactiveFlag of the CollectorCommissionSetupMaster
    /// InactiveFlag الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CollectorCommissionSetupMaster
    /// InactiveReason الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CollectorCommissionSetupMaster
    /// InactiveDate الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CollectorCommissionSetupMaster
    /// InactivatedByUserId الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the CollectorCommissionSetupMaster
    /// CommissionDescriptionShort الخاص بـ CollectorCommissionSetupMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CollectorCommissionSetupMaster to CollectorCommissionSetupDetail
    /// </summary>
    public IReadOnlyCollection<CollectorCommissionSetupDetail> CollectorCommissionSetupDetails { get; private set; }
    #endregion
}
}
