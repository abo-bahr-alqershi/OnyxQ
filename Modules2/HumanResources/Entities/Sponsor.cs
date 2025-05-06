using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// Sponsor Entity
/// </summary>
public class Sponsor : Entity<SponsorId>
{

    private Sponsor() { }

    public Sponsor(SponsorId id, decimal? sponsorNumber)
    {
        Id = id;
        SponsorNumber = sponsorNumber;
    }

    /// <summary>
    /// The unique identifier for the Sponsor
    /// المعرف الفريد لـ Sponsor
    /// </summary>
    public SponsorId Id { get; private set; }

    /// <summary>
    /// SponsorNumber of the Sponsor
    /// SponsorNumber الخاص بـ Sponsor
    /// </summary>
    public decimal? SponsorNumber { get; private set; }

    /// <summary>
    /// SponsorLastName of the Sponsor
    /// SponsorLastName الخاص بـ Sponsor
    /// </summary>
    public string SponsorLastName { get; private set; }

    /// <summary>
    /// SponsorFirstName of the Sponsor
    /// SponsorFirstName الخاص بـ Sponsor
    /// </summary>
    public string SponsorFirstName { get; private set; }

    /// <summary>
    /// CardJobNumber of the Sponsor
    /// CardJobNumber الخاص بـ Sponsor
    /// </summary>
    public string CardJobNumber { get; private set; }

    /// <summary>
    /// WorkOfficeNumber of the Sponsor
    /// WorkOfficeNumber الخاص بـ Sponsor
    /// </summary>
    public string WorkOfficeNumber { get; private set; }

    /// <summary>
    /// AddressShort of the Sponsor
    /// AddressShort الخاص بـ Sponsor
    /// </summary>
    public string AddressShort { get; private set; }

    /// <summary>
    /// CardIdGuarantor of the Sponsor
    /// CardIdGuarantor الخاص بـ Sponsor
    /// </summary>
    public string CardIdGuarantor { get; private set; }

    /// <summary>
    /// CardIssueDateAlt of the Sponsor
    /// CardIssueDateAlt الخاص بـ Sponsor
    /// </summary>
    public DateTime? CardIssueDateAlt { get; private set; }

    /// <summary>
    /// CardIssuePlace of the Sponsor
    /// CardIssuePlace الخاص بـ Sponsor
    /// </summary>
    public string CardIssuePlace { get; private set; }

    /// <summary>
    /// CardEndDate of the Sponsor
    /// CardEndDate الخاص بـ Sponsor
    /// </summary>
    public DateTime? CardEndDate { get; private set; }

    /// <summary>
    /// CommercialNumber of the Sponsor
    /// CommercialNumber الخاص بـ Sponsor
    /// </summary>
    public string CommercialNumber { get; private set; }

    /// <summary>
    /// SocialInsuranceNumber of the Sponsor
    /// SocialInsuranceNumber الخاص بـ Sponsor
    /// </summary>
    public string SocialInsuranceNumber { get; private set; }

    /// <summary>
    /// GuarantorCompanyName of the Sponsor
    /// GuarantorCompanyName الخاص بـ Sponsor
    /// </summary>
    public string GuarantorCompanyName { get; private set; }

    /// <summary>
    /// CommerceDate of the Sponsor
    /// CommerceDate الخاص بـ Sponsor
    /// </summary>
    public string CommerceDate { get; private set; }

    /// <summary>
    /// Field1 of the Sponsor
    /// Field1 الخاص بـ Sponsor
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Sponsor
    /// Field2 الخاص بـ Sponsor
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Sponsor
    /// Field3 الخاص بـ Sponsor
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Sponsor
    /// Field4 الخاص بـ Sponsor
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Sponsor
    /// Field5 الخاص بـ Sponsor
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Sponsor
    /// Field6 الخاص بـ Sponsor
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Sponsor
    /// Field7 الخاص بـ Sponsor
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Sponsor
    /// Field8 الخاص بـ Sponsor
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Sponsor
    /// Field9 الخاص بـ Sponsor
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Sponsor
    /// Field10 الخاص بـ Sponsor
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlag of the Sponsor
    /// InactiveFlag الخاص بـ Sponsor
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Sponsor
    /// InactivatedByUserId الخاص بـ Sponsor
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the Sponsor
    /// InactiveDate الخاص بـ Sponsor
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Sponsor
    /// InactiveReason الخاص بـ Sponsor
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

