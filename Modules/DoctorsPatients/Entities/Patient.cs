using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.Entities
{
/// <summary>
/// Patient Entity
/// </summary>
public class Patient : Entity<PatientId>
{
    private Patient() { }

    /// <summary>
    /// The unique identifier for the Patient
    /// المعرف الفريد لـ Patient
    /// </summary>
    public PatientId Id { get; private set; }

    /// <summary>
    /// PatientNumber of the Patient
    /// PatientNumber الخاص بـ Patient
    /// </summary>
    public string PatientNumber { get; private set; }

    /// <summary>
    /// PatientLastName of the Patient
    /// PatientLastName الخاص بـ Patient
    /// </summary>
    public string PatientLastName { get; private set; }

    /// <summary>
    /// PatientFirstName of the Patient
    /// PatientFirstName الخاص بـ Patient
    /// </summary>
    public string PatientFirstName { get; private set; }

    /// <summary>
    /// PatientImage of the Patient
    /// PatientImage الخاص بـ Patient
    /// </summary>
    public string PatientImage { get; private set; }

    /// <summary>
    /// FirstLastName of the Patient
    /// FirstLastName الخاص بـ Patient
    /// </summary>
    public string FirstLastName { get; private set; }

    /// <summary>
    /// FirstFirstName of the Patient
    /// FirstFirstName الخاص بـ Patient
    /// </summary>
    public string FirstFirstName { get; private set; }

    /// <summary>
    /// SecondLastName of the Patient
    /// SecondLastName الخاص بـ Patient
    /// </summary>
    public string SecondLastName { get; private set; }

    /// <summary>
    /// SecondFirstName of the Patient
    /// SecondFirstName الخاص بـ Patient
    /// </summary>
    public string SecondFirstName { get; private set; }

    /// <summary>
    /// ThirdLastName of the Patient
    /// ThirdLastName الخاص بـ Patient
    /// </summary>
    public string ThirdLastName { get; private set; }

    /// <summary>
    /// ThirdFirstName of the Patient
    /// ThirdFirstName الخاص بـ Patient
    /// </summary>
    public string ThirdFirstName { get; private set; }

    /// <summary>
    /// LastLastName of the Patient
    /// LastLastName الخاص بـ Patient
    /// </summary>
    public string LastLastName { get; private set; }

    /// <summary>
    /// LastFirstName of the Patient
    /// LastFirstName الخاص بـ Patient
    /// </summary>
    public string LastFirstName { get; private set; }

    /// <summary>
    /// Age of the Patient
    /// Age الخاص بـ Patient
    /// </summary>
    public string Age { get; private set; }

    /// <summary>
    /// Gender of the Patient
    /// Gender الخاص بـ Patient
    /// </summary>
    public decimal? Gender { get; private set; }

    /// <summary>
    /// NationalityNumber of the Patient
    /// NationalityNumber الخاص بـ Patient
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// SocialStatus of the Patient
    /// SocialStatus الخاص بـ Patient
    /// </summary>
    public decimal? SocialStatus { get; private set; }

    /// <summary>
    /// BuildingType of the Patient
    /// BuildingType الخاص بـ Patient
    /// </summary>
    public string BuildingType { get; private set; }

    /// <summary>
    /// BirthDate of the Patient
    /// BirthDate الخاص بـ Patient
    /// </summary>
    public DateTime? BirthDate { get; private set; }

    /// <summary>
    /// BirthPlace of the Patient
    /// BirthPlace الخاص بـ Patient
    /// </summary>
    public string BirthPlace { get; private set; }

    /// <summary>
    /// TelephoneNumber of the Patient
    /// TelephoneNumber الخاص بـ Patient
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderBoxNumber of the Patient
    /// PurchaseOrderBoxNumber الخاص بـ Patient
    /// </summary>
    public string PurchaseOrderBoxNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the Patient
    /// MobileNumber الخاص بـ Patient
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// Email of the Patient
    /// Email الخاص بـ Patient
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// AddressShort of the Patient
    /// AddressShort الخاص بـ Patient
    /// </summary>
    public string AddressShort { get; private set; }

    /// <summary>
    /// FileCreateDate of the Patient
    /// FileCreateDate الخاص بـ Patient
    /// </summary>
    public DateTime? FileCreateDate { get; private set; }

    /// <summary>
    /// FileNumber of the Patient
    /// FileNumber الخاص بـ Patient
    /// </summary>
    public string FileNumber { get; private set; }

    /// <summary>
    /// JobNameShort of the Patient
    /// JobNameShort الخاص بـ Patient
    /// </summary>
    public string JobNameShort { get; private set; }

    /// <summary>
    /// JobPlace of the Patient
    /// JobPlace الخاص بـ Patient
    /// </summary>
    public string JobPlace { get; private set; }

    /// <summary>
    /// CardType of the Patient
    /// CardType الخاص بـ Patient
    /// </summary>
    public decimal? CardType { get; private set; }

    /// <summary>
    /// CardNumber of the Patient
    /// CardNumber الخاص بـ Patient
    /// </summary>
    public string CardNumber { get; private set; }

    /// <summary>
    /// CreditDate of the Patient
    /// CreditDate الخاص بـ Patient
    /// </summary>
    public DateTime? CreditDate { get; private set; }

    /// <summary>
    /// PlaceCardIssue of the Patient
    /// PlaceCardIssue الخاص بـ Patient
    /// </summary>
    public string PlaceCardIssue { get; private set; }

    /// <summary>
    /// NationalNumber of the Patient
    /// NationalNumber الخاص بـ Patient
    /// </summary>
    public string NationalNumber { get; private set; }

    /// <summary>
    /// CountryNumber of the Patient
    /// CountryNumber الخاص بـ Patient
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the Patient
    /// ProvinceNumber الخاص بـ Patient
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the Patient
    /// CityNumber الخاص بـ Patient
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RegionCode of the Patient
    /// RegionCode الخاص بـ Patient
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// RelativeLastName of the Patient
    /// RelativeLastName الخاص بـ Patient
    /// </summary>
    public string RelativeLastName { get; private set; }

    /// <summary>
    /// RelativeFirstName of the Patient
    /// RelativeFirstName الخاص بـ Patient
    /// </summary>
    public string RelativeFirstName { get; private set; }

    /// <summary>
    /// RelativeType of the Patient
    /// RelativeType الخاص بـ Patient
    /// </summary>
    public string RelativeType { get; private set; }

    /// <summary>
    /// RelativeMobileNumber of the Patient
    /// RelativeMobileNumber الخاص بـ Patient
    /// </summary>
    public string RelativeMobileNumber { get; private set; }

    /// <summary>
    /// RelativeTelephoneNumber of the Patient
    /// RelativeTelephoneNumber الخاص بـ Patient
    /// </summary>
    public string RelativeTelephoneNumber { get; private set; }

    /// <summary>
    /// Note of the Patient
    /// Note الخاص بـ Patient
    /// </summary>
    public string Note { get; private set; }

    /// <summary>
    /// ReligionNumber of the Patient
    /// ReligionNumber الخاص بـ Patient
    /// </summary>
    public decimal? ReligionNumber { get; private set; }

    /// <summary>
    /// InsuranceFlagAlt of the Patient
    /// InsuranceFlagAlt الخاص بـ Patient
    /// </summary>
    public decimal? InsuranceFlagAlt { get; private set; }

    /// <summary>
    /// InsuranceNumberShort of the Patient
    /// InsuranceNumberShort الخاص بـ Patient
    /// </summary>
    public string InsuranceNumberShort { get; private set; }

    /// <summary>
    /// BeneficiaryNumber of the Patient
    /// BeneficiaryNumber الخاص بـ Patient
    /// </summary>
    public decimal? BeneficiaryNumber { get; private set; }

    /// <summary>
    /// BlackListFlagShort of the Patient
    /// BlackListFlagShort الخاص بـ Patient
    /// </summary>
    public decimal? BlackListFlagShort { get; private set; }

    /// <summary>
    /// BlackListDate of the Patient
    /// BlackListDate الخاص بـ Patient
    /// </summary>
    public DateTime? BlackListDate { get; private set; }

    /// <summary>
    /// BlackListUserId of the Patient
    /// BlackListUserId الخاص بـ Patient
    /// </summary>
    public decimal? BlackListUserId { get; private set; }

    /// <summary>
    /// BlackListReasonShort of the Patient
    /// BlackListReasonShort الخاص بـ Patient
    /// </summary>
    public string BlackListReasonShort { get; private set; }

    /// <summary>
    /// Field1 of the Patient
    /// Field1 الخاص بـ Patient
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Patient
    /// Field2 الخاص بـ Patient
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Patient
    /// Field3 الخاص بـ Patient
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Patient
    /// Field4 الخاص بـ Patient
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Patient
    /// Field5 الخاص بـ Patient
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Patient
    /// Field6 الخاص بـ Patient
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Patient
    /// Field7 الخاص بـ Patient
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Patient
    /// Field8 الخاص بـ Patient
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Patient
    /// Field9 الخاص بـ Patient
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Patient
    /// Field10 الخاص بـ Patient
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// Field11 of the Patient
    /// Field11 الخاص بـ Patient
    /// </summary>
    public string Field11 { get; private set; }

    /// <summary>
    /// Field12 of the Patient
    /// Field12 الخاص بـ Patient
    /// </summary>
    public string Field12 { get; private set; }

    /// <summary>
    /// Field13 of the Patient
    /// Field13 الخاص بـ Patient
    /// </summary>
    public string Field13 { get; private set; }

    /// <summary>
    /// Field14 of the Patient
    /// Field14 الخاص بـ Patient
    /// </summary>
    public string Field14 { get; private set; }

    /// <summary>
    /// Field15 of the Patient
    /// Field15 الخاص بـ Patient
    /// </summary>
    public string Field15 { get; private set; }

    /// <summary>
    /// Field16 of the Patient
    /// Field16 الخاص بـ Patient
    /// </summary>
    public string Field16 { get; private set; }

    /// <summary>
    /// Field17 of the Patient
    /// Field17 الخاص بـ Patient
    /// </summary>
    public string Field17 { get; private set; }

    /// <summary>
    /// Field18 of the Patient
    /// Field18 الخاص بـ Patient
    /// </summary>
    public string Field18 { get; private set; }

    /// <summary>
    /// Field19 of the Patient
    /// Field19 الخاص بـ Patient
    /// </summary>
    public string Field19 { get; private set; }

    /// <summary>
    /// Field20 of the Patient
    /// Field20 الخاص بـ Patient
    /// </summary>
    public string Field20 { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the Patient
    /// InactiveFlagAlt الخاص بـ Patient
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the Patient
    /// InactiveDateAlt الخاص بـ Patient
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the Patient
    /// InactiveReasonAlt الخاص بـ Patient
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveUserId of the Patient
    /// InactiveUserId الخاص بـ Patient
    /// </summary>
    public decimal? InactiveUserId { get; private set; }
}
}
