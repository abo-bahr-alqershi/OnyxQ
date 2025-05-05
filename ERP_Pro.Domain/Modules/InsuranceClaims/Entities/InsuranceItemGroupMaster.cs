using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceItemGroupMaster Entity
/// </summary>
public class InsuranceItemGroupMaster : Entity<InsuranceItemGroupMasterId>
{

    private InsuranceItemGroupMaster() { }

    public InsuranceItemGroupMaster(InsuranceItemGroupMasterId id, decimal? insuranceGroupNumber)
    {
        Id = id;
        InsuranceGroupNumber = insuranceGroupNumber;
    }

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

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

