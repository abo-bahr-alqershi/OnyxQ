using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceClassMedicalNetwork Entity
/// </summary>
public class InsuranceClassMedicalNetwork : Entity<InsuranceClassMedicalNetworkId>
{

    private InsuranceClassMedicalNetwork() { }

    public InsuranceClassMedicalNetwork(InsuranceClassMedicalNetworkId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InsuranceClassMedicalNetwork
    /// المعرف الفريد لـ InsuranceClassMedicalNetwork
    /// </summary>
    public InsuranceClassMedicalNetworkId Id { get; private set; }

    /// <summary>
    /// MedicalNumber of the InsuranceClassMedicalNetwork
    /// MedicalNumber الخاص بـ InsuranceClassMedicalNetwork
    /// </summary>
    public decimal? MedicalNumber { get; private set; }

    /// <summary>
    /// InactiveFlag of the InsuranceClassMedicalNetwork
    /// InactiveFlag الخاص بـ InsuranceClassMedicalNetwork
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the InsuranceClassMedicalNetwork
    /// InactiveDate الخاص بـ InsuranceClassMedicalNetwork
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the InsuranceClassMedicalNetwork
    /// InactiveReason الخاص بـ InsuranceClassMedicalNetwork
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the InsuranceClassMedicalNetwork
    /// InactivatedByUserId الخاص بـ InsuranceClassMedicalNetwork
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InsuranceCompanyClass InsuranceCompanyClass { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

