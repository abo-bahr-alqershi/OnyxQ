using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.Entities
{
/// <summary>
/// Doctor Entity
/// </summary>
public class Doctor : Entity<DoctorId>
{

    private Doctor() { }

    public Doctor(DoctorId id, string dctrNo)
    {
        Id = id;
        DctrNo = dctrNo;
    }

    /// <summary>
    /// The unique identifier for the Doctor
    /// المعرف الفريد لـ Doctor
    /// </summary>
    public DoctorId Id { get; private set; }

    /// <summary>
    /// DctrNo of the Doctor
    /// DctrNo الخاص بـ Doctor
    /// </summary>
    public string DctrNo { get; private set; }

    /// <summary>
    /// DctrLNm of the Doctor
    /// DctrLNm الخاص بـ Doctor
    /// </summary>
    public string DctrLNm { get; private set; }

    /// <summary>
    /// DctrFNm of the Doctor
    /// DctrFNm الخاص بـ Doctor
    /// </summary>
    public string DctrFNm { get; private set; }

    /// <summary>
    /// DctrTyp of the Doctor
    /// DctrTyp الخاص بـ Doctor
    /// </summary>
    public decimal? DctrTyp { get; private set; }

    /// <summary>
    /// DctrGrp of the Doctor
    /// DctrGrp الخاص بـ Doctor
    /// </summary>
    public decimal? DctrGrp { get; private set; }

    /// <summary>
    /// DeptNo of the Doctor
    /// DeptNo الخاص بـ Doctor
    /// </summary>
    public decimal? DeptNo { get; private set; }

    /// <summary>
    /// ClinicNumber of the Doctor
    /// ClinicNumber الخاص بـ Doctor
    /// </summary>
    public decimal? ClinicNumber { get; private set; }

    /// <summary>
    /// AccountCode of the Doctor
    /// AccountCode الخاص بـ Doctor
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// Gender of the Doctor
    /// Gender الخاص بـ Doctor
    /// </summary>
    public decimal? Gender { get; private set; }

    /// <summary>
    /// NationalityNumber of the Doctor
    /// NationalityNumber الخاص بـ Doctor
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// SocialStatus of the Doctor
    /// SocialStatus الخاص بـ Doctor
    /// </summary>
    public decimal? SocialStatus { get; private set; }

    /// <summary>
    /// BuildingType of the Doctor
    /// BuildingType الخاص بـ Doctor
    /// </summary>
    public string BuildingType { get; private set; }

    /// <summary>
    /// BirthDate of the Doctor
    /// BirthDate الخاص بـ Doctor
    /// </summary>
    public string BirthDate { get; private set; }

    /// <summary>
    /// BirthPlace of the Doctor
    /// BirthPlace الخاص بـ Doctor
    /// </summary>
    public string BirthPlace { get; private set; }

    /// <summary>
    /// TelephoneNumber of the Doctor
    /// TelephoneNumber الخاص بـ Doctor
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// PurchaseOrderBoxNumber of the Doctor
    /// PurchaseOrderBoxNumber الخاص بـ Doctor
    /// </summary>
    public string PurchaseOrderBoxNumber { get; private set; }

    /// <summary>
    /// MobileNumber of the Doctor
    /// MobileNumber الخاص بـ Doctor
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// Email of the Doctor
    /// Email الخاص بـ Doctor
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// AddressShort of the Doctor
    /// AddressShort الخاص بـ Doctor
    /// </summary>
    public string AddressShort { get; private set; }

    /// <summary>
    /// Field1 of the Doctor
    /// Field1 الخاص بـ Doctor
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Doctor
    /// Field2 الخاص بـ Doctor
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Doctor
    /// Field3 الخاص بـ Doctor
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Doctor
    /// Field4 الخاص بـ Doctor
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Doctor
    /// Field5 الخاص بـ Doctor
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the Doctor
    /// Field6 الخاص بـ Doctor
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the Doctor
    /// Field7 الخاص بـ Doctor
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the Doctor
    /// Field8 الخاص بـ Doctor
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the Doctor
    /// Field9 الخاص بـ Doctor
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the Doctor
    /// Field10 الخاص بـ Doctor
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the Doctor
    /// InactiveFlagAlt الخاص بـ Doctor
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the Doctor
    /// InactiveReasonAlt الخاص بـ Doctor
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the Doctor
    /// InactiveDateAlt الخاص بـ Doctor
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserId of the Doctor
    /// InactiveUserId الخاص بـ Doctor
    /// </summary>
    public decimal? InactiveUserId { get; private set; }

    /// <summary>
    /// CardType of the Doctor
    /// CardType الخاص بـ Doctor
    /// </summary>
    public decimal? CardType { get; private set; }

    /// <summary>
    /// CardNumber of the Doctor
    /// CardNumber الخاص بـ Doctor
    /// </summary>
    public string CardNumber { get; private set; }

    /// <summary>
    /// CreditDate of the Doctor
    /// CreditDate الخاص بـ Doctor
    /// </summary>
    public DateTime? CreditDate { get; private set; }

    /// <summary>
    /// PlaceCardIssue of the Doctor
    /// PlaceCardIssue الخاص بـ Doctor
    /// </summary>
    public string PlaceCardIssue { get; private set; }

    /// <summary>
    /// Notes of the Doctor
    /// Notes الخاص بـ Doctor
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// ReligionNumber of the Doctor
    /// ReligionNumber الخاص بـ Doctor
    /// </summary>
    public decimal? ReligionNumber { get; private set; }

    /// <summary>
    /// ScientificDegrees of the Doctor
    /// ScientificDegrees الخاص بـ Doctor
    /// </summary>
    public decimal? ScientificDegrees { get; private set; }

    /// <summary>
    /// CostCenterCode of the Doctor
    /// CostCenterCode الخاص بـ Doctor
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// Specialization of the Doctor
    /// Specialization الخاص بـ Doctor
    /// </summary>
    public decimal? Specialization { get; private set; }

    /// <summary>
    /// DctrSer of the Doctor
    /// DctrSer الخاص بـ Doctor
    /// </summary>
    public decimal? DctrSer { get; private set; }

    /// <summary>
    /// AccountDetailCode of the Doctor
    /// AccountDetailCode الخاص بـ Doctor
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the Doctor
    /// AccountDetailType الخاص بـ Doctor
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
