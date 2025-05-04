using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// Beneficiaries Entity
/// </summary>
public class Beneficiaries : Entity<BeneficiariesId>
{

    private Beneficiaries() { }

    public Beneficiaries(BeneficiariesId id, decimal? beneficiaryNumber)
    {
        Id = id;
        BeneficiaryNumber = beneficiaryNumber;
    }

    /// <summary>
    /// The unique identifier for the Beneficiaries
    /// المعرف الفريد لـ Beneficiaries
    /// </summary>
    public BeneficiariesId Id { get; private set; }

    /// <summary>
    /// BeneficiaryNumber of the Beneficiaries
    /// BeneficiaryNumber الخاص بـ Beneficiaries
    /// </summary>
    public decimal? BeneficiaryNumber { get; private set; }

    /// <summary>
    /// BeneficiaryLastName of the Beneficiaries
    /// BeneficiaryLastName الخاص بـ Beneficiaries
    /// </summary>
    public string BeneficiaryLastName { get; private set; }

    /// <summary>
    /// BeneficiaryFirstName of the Beneficiaries
    /// BeneficiaryFirstName الخاص بـ Beneficiaries
    /// </summary>
    public string BeneficiaryFirstName { get; private set; }

    /// <summary>
    /// BeneficiaryTelephone of the Beneficiaries
    /// BeneficiaryTelephone الخاص بـ Beneficiaries
    /// </summary>
    public string BeneficiaryTelephone { get; private set; }

    /// <summary>
    /// BeneficiaryAddress of the Beneficiaries
    /// BeneficiaryAddress الخاص بـ Beneficiaries
    /// </summary>
    public string BeneficiaryAddress { get; private set; }

    /// <summary>
    /// Website of the Beneficiaries
    /// Website الخاص بـ Beneficiaries
    /// </summary>
    public string Website { get; private set; }

    /// <summary>
    /// InactiveFlag of the Beneficiaries
    /// InactiveFlag الخاص بـ Beneficiaries
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the Beneficiaries
    /// InactiveDate الخاص بـ Beneficiaries
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Beneficiaries
    /// InactiveReason الخاص بـ Beneficiaries
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Beneficiaries
    /// InactivatedByUserId الخاص بـ Beneficiaries
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
