using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// MedicalNetwork Entity
/// </summary>
public class MedicalNetwork : Entity<MedicalNetworkId>
{
    private MedicalNetwork() { }

    /// <summary>
    /// The unique identifier for the MedicalNetwork
    /// المعرف الفريد لـ MedicalNetwork
    /// </summary>
    public MedicalNetworkId Id { get; private set; }

    /// <summary>
    /// MedicalNumber of the MedicalNetwork
    /// MedicalNumber الخاص بـ MedicalNetwork
    /// </summary>
    public decimal? MedicalNumber { get; private set; }

    /// <summary>
    /// MedicalLastName of the MedicalNetwork
    /// MedicalLastName الخاص بـ MedicalNetwork
    /// </summary>
    public string MedicalLastName { get; private set; }

    /// <summary>
    /// MedicalFirstName of the MedicalNetwork
    /// MedicalFirstName الخاص بـ MedicalNetwork
    /// </summary>
    public string MedicalFirstName { get; private set; }

    /// <summary>
    /// MedicalTelephone of the MedicalNetwork
    /// MedicalTelephone الخاص بـ MedicalNetwork
    /// </summary>
    public string MedicalTelephone { get; private set; }

    /// <summary>
    /// MedicalAddress of the MedicalNetwork
    /// MedicalAddress الخاص بـ MedicalNetwork
    /// </summary>
    public string MedicalAddress { get; private set; }

    /// <summary>
    /// InactiveFlag of the MedicalNetwork
    /// InactiveFlag الخاص بـ MedicalNetwork
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the MedicalNetwork
    /// InactiveDate الخاص بـ MedicalNetwork
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the MedicalNetwork
    /// InactiveReason الخاص بـ MedicalNetwork
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the MedicalNetwork
    /// InactivatedByUserId الخاص بـ MedicalNetwork
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }
}
}
