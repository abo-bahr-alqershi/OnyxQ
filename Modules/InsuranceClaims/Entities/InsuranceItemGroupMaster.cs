using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceItemGroupMaster Entity
/// </summary>
public class InsuranceItemGroupMaster : Entity<InsuranceItemGroupMasterId>
{
    private InsuranceItemGroupMaster() { }

    /// <summary>
    /// The unique identifier for the InsuranceItemGroupMaster
    /// المعرف الفريد لـ InsuranceItemGroupMaster
    /// </summary>
    public InsuranceItemGroupMasterId Id { get; private set; }

    /// <summary>
    /// InsuranceGroupNumber of the InsuranceItemGroupMaster
    /// InsuranceGroupNumber الخاص بـ InsuranceItemGroupMaster
    /// </summary>
    public decimal? InsuranceGroupNumber { get; private set; }

    /// <summary>
    /// InsuranceGroupLastName of the InsuranceItemGroupMaster
    /// InsuranceGroupLastName الخاص بـ InsuranceItemGroupMaster
    /// </summary>
    public string InsuranceGroupLastName { get; private set; }

    /// <summary>
    /// InsuranceGroupFirstName of the InsuranceItemGroupMaster
    /// InsuranceGroupFirstName الخاص بـ InsuranceItemGroupMaster
    /// </summary>
    public string InsuranceGroupFirstName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: InsuranceItemGroupMaster to InsuranceClassGroupItemOut
    /// </summary>
    public IReadOnlyCollection<InsuranceClassGroupItemOut> InsuranceClassGroupItemOuts { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceItemGroupMaster to InsuranceClassItemType
    /// </summary>
    public IReadOnlyCollection<InsuranceClassItemType> InsuranceClassItemTypes { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceItemGroupMaster to InsuranceClassLimitMonth
    /// </summary>
    public IReadOnlyCollection<InsuranceClassLimitMonth> InsuranceClassLimitMonths { get; private set; }
    /// <summary>
    /// One-to-many relationship: InsuranceItemGroupMaster to InsuranceItemGroupDetail
    /// </summary>
    public IReadOnlyCollection<InsuranceItemGroupDetail> InsuranceItemGroupDetails { get; private set; }
    #endregion
}
}
