using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// CompensationQuantitySetupMaster Entity
/// </summary>
public class CompensationQuantitySetupMaster : Entity<CompensationQuantitySetupMasterId>
{
    private CompensationQuantitySetupMaster() { }

    /// <summary>
    /// The unique identifier for the CompensationQuantitySetupMaster
    /// المعرف الفريد لـ CompensationQuantitySetupMaster
    /// </summary>
    public CompensationQuantitySetupMasterId Id { get; private set; }

    /// <summary>
    /// CompensationType of the CompensationQuantitySetupMaster
    /// CompensationType الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? CompensationType { get; private set; }

    /// <summary>
    /// CommissionTypeLastName of the CompensationQuantitySetupMaster
    /// CommissionTypeLastName الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public string CommissionTypeLastName { get; private set; }

    /// <summary>
    /// CommissionTypeFirstName of the CompensationQuantitySetupMaster
    /// CommissionTypeFirstName الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public string CommissionTypeFirstName { get; private set; }

    /// <summary>
    /// CompensationItemType of the CompensationQuantitySetupMaster
    /// CompensationItemType الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? CompensationItemType { get; private set; }

    /// <summary>
    /// CompensationSalaryType of the CompensationQuantitySetupMaster
    /// CompensationSalaryType الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? CompensationSalaryType { get; private set; }

    /// <summary>
    /// CompensationFunctionType of the CompensationQuantitySetupMaster
    /// CompensationFunctionType الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? CompensationFunctionType { get; private set; }

    /// <summary>
    /// CompensationAmountType of the CompensationQuantitySetupMaster
    /// CompensationAmountType الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? CompensationAmountType { get; private set; }

    /// <summary>
    /// InactiveFlag of the CompensationQuantitySetupMaster
    /// InactiveFlag الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CompensationQuantitySetupMaster
    /// InactiveReason الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CompensationQuantitySetupMaster
    /// InactiveDate الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CompensationQuantitySetupMaster
    /// InactivatedByUserId الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// CommissionDescriptionShort of the CompensationQuantitySetupMaster
    /// CommissionDescriptionShort الخاص بـ CompensationQuantitySetupMaster
    /// </summary>
    public string CommissionDescriptionShort { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: CompensationQuantitySetupMaster to CompensationQuantitySetupDetail
    /// </summary>
    public IReadOnlyCollection<CompensationQuantitySetupDetail> CompensationQuantitySetupDetails { get; private set; }
    #endregion
}
}
