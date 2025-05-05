using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InsuranceClaims.ValueObjects;
namespace ERP_Pro.Domain.ERP.InsuranceClaims.Entities
{
/// <summary>
/// InsuranceCard Entity
/// </summary>
public class InsuranceCard : Entity<InsuranceCardId>
{

    private InsuranceCard() { }

    public InsuranceCard(InsuranceCardId id, decimal? insuranceCompanyNumberAlt, decimal? beneficiaryNumber, string personCardNumber)
    {
        Id = id;
        InsuranceCompanyNumberAlt = insuranceCompanyNumberAlt;
        BeneficiaryNumber = beneficiaryNumber;
        PersonCardNumber = personCardNumber;
    }

    /// <summary>
    /// The unique identifier for the InsuranceCard
    /// المعرف الفريد لـ InsuranceCard
    /// </summary>
    public InsuranceCardId Id { get; private set; }

    /// <summary>
    /// InsuranceCompanyNumberAlt of the InsuranceCard
    /// InsuranceCompanyNumberAlt الخاص بـ InsuranceCard
    /// </summary>
    public decimal? InsuranceCompanyNumberAlt { get; private set; }

    /// <summary>
    /// BeneficiaryNumber of the InsuranceCard
    /// BeneficiaryNumber الخاص بـ InsuranceCard
    /// </summary>
    public decimal? BeneficiaryNumber { get; private set; }

    /// <summary>
    /// PersonNumberAlt of the InsuranceCard
    /// PersonNumberAlt الخاص بـ InsuranceCard
    /// </summary>
    public decimal? PersonNumberAlt { get; private set; }

    /// <summary>
    /// PersonSerial of the InsuranceCard
    /// PersonSerial الخاص بـ InsuranceCard
    /// </summary>
    public decimal? PersonSerial { get; private set; }

    /// <summary>
    /// PersonCardNumber of the InsuranceCard
    /// PersonCardNumber الخاص بـ InsuranceCard
    /// </summary>
    public string PersonCardNumber { get; private set; }

    /// <summary>
    /// RelationType of the InsuranceCard
    /// RelationType الخاص بـ InsuranceCard
    /// </summary>
    public decimal? RelationType { get; private set; }

    /// <summary>
    /// PersonCardNumberFamily of the InsuranceCard
    /// PersonCardNumberFamily الخاص بـ InsuranceCard
    /// </summary>
    public string PersonCardNumberFamily { get; private set; }

    /// <summary>
    /// PersonLastNameAlt of the InsuranceCard
    /// PersonLastNameAlt الخاص بـ InsuranceCard
    /// </summary>
    public string PersonLastNameAlt { get; private set; }

    /// <summary>
    /// PersonFirstNameAlt of the InsuranceCard
    /// PersonFirstNameAlt الخاص بـ InsuranceCard
    /// </summary>
    public string PersonFirstNameAlt { get; private set; }

    /// <summary>
    /// PersonSex of the InsuranceCard
    /// PersonSex الخاص بـ InsuranceCard
    /// </summary>
    public decimal? PersonSex { get; private set; }

    /// <summary>
    /// CardIssueDate of the InsuranceCard
    /// CardIssueDate الخاص بـ InsuranceCard
    /// </summary>
    public DateTime? CardIssueDate { get; private set; }

    /// <summary>
    /// CardExpireDate of the InsuranceCard
    /// CardExpireDate الخاص بـ InsuranceCard
    /// </summary>
    public DateTime? CardExpireDate { get; private set; }

    /// <summary>
    /// RegionCode of the InsuranceCard
    /// RegionCode الخاص بـ InsuranceCard
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CardNumber of the InsuranceCard
    /// CardNumber الخاص بـ InsuranceCard
    /// </summary>
    public decimal? CardNumber { get; private set; }

    /// <summary>
    /// CardNumberType of the InsuranceCard
    /// CardNumberType الخاص بـ InsuranceCard
    /// </summary>
    public decimal? CardNumberType { get; private set; }

    /// <summary>
    /// PersonTelephone of the InsuranceCard
    /// PersonTelephone الخاص بـ InsuranceCard
    /// </summary>
    public string PersonTelephone { get; private set; }

    /// <summary>
    /// PersonAddress of the InsuranceCard
    /// PersonAddress الخاص بـ InsuranceCard
    /// </summary>
    public string PersonAddress { get; private set; }

    /// <summary>
    /// ClassNumber of the InsuranceCard
    /// ClassNumber الخاص بـ InsuranceCard
    /// </summary>
    public string ClassNumber { get; private set; }

    /// <summary>
    /// LoadPercent of the InsuranceCard
    /// LoadPercent الخاص بـ InsuranceCard
    /// </summary>
    public decimal? LoadPercent { get; private set; }

    /// <summary>
    /// LimitAmountLocalNetDocument of the InsuranceCard
    /// LimitAmountLocalNetDocument الخاص بـ InsuranceCard
    /// </summary>
    public decimal? LimitAmountLocalNetDocument { get; private set; }

    /// <summary>
    /// LimitAmountLocalOutNetDocument of the InsuranceCard
    /// LimitAmountLocalOutNetDocument الخاص بـ InsuranceCard
    /// </summary>
    public decimal? LimitAmountLocalOutNetDocument { get; private set; }

    /// <summary>
    /// PersonEmail of the InsuranceCard
    /// PersonEmail الخاص بـ InsuranceCard
    /// </summary>
    public string PersonEmail { get; private set; }

    /// <summary>
    /// SendMessageFlag of the InsuranceCard
    /// SendMessageFlag الخاص بـ InsuranceCard
    /// </summary>
    public decimal? SendMessageFlag { get; private set; }

    /// <summary>
    /// BirthDate of the InsuranceCard
    /// BirthDate الخاص بـ InsuranceCard
    /// </summary>
    public DateTime? BirthDate { get; private set; }

    /// <summary>
    /// InsuranceCardImage of the InsuranceCard
    /// InsuranceCardImage الخاص بـ InsuranceCard
    /// </summary>
    public string InsuranceCardImage { get; private set; }

    /// <summary>
    /// InactiveFlag of the InsuranceCard
    /// InactiveFlag الخاص بـ InsuranceCard
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the InsuranceCard
    /// InactiveDate الخاص بـ InsuranceCard
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the InsuranceCard
    /// InactiveReason الخاص بـ InsuranceCard
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the InsuranceCard
    /// InactivatedByUserId الخاص بـ InsuranceCard
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

