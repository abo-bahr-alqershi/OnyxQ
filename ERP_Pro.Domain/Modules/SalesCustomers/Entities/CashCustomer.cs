using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CashCustomer Entity
/// </summary>
public class CashCustomer : Entity<CashCustomerId>
{

    private CashCustomer() { }

    public CashCustomer(CashCustomerId id, string custCode)
    {
        Id = id;
        CustCode = custCode;
    }

    /// <summary>
    /// The unique identifier for the CashCustomer
    /// المعرف الفريد لـ CashCustomer
    /// </summary>
    public CashCustomerId Id { get; private set; }

    /// <summary>
    /// CustCode of the CashCustomer
    /// CustCode الخاص بـ CashCustomer
    /// </summary>
    public string CustCode { get; private set; }

    /// <summary>
    /// CustLNm of the CashCustomer
    /// CustLNm الخاص بـ CashCustomer
    /// </summary>
    public string CustLNm { get; private set; }

    /// <summary>
    /// CustFNm of the CashCustomer
    /// CustFNm الخاص بـ CashCustomer
    /// </summary>
    public string CustFNm { get; private set; }

    /// <summary>
    /// CustGrpCode of the CashCustomer
    /// CustGrpCode الخاص بـ CashCustomer
    /// </summary>
    public decimal? CustGrpCode { get; private set; }

    /// <summary>
    /// MobileNumber of the CashCustomer
    /// MobileNumber الخاص بـ CashCustomer
    /// </summary>
    public string MobileNumber { get; private set; }

    /// <summary>
    /// PointTypeNumber of the CashCustomer
    /// PointTypeNumber الخاص بـ CashCustomer
    /// </summary>
    public decimal? PointTypeNumber { get; private set; }

    /// <summary>
    /// PointTypeActiveDate of the CashCustomer
    /// PointTypeActiveDate الخاص بـ CashCustomer
    /// </summary>
    public DateTime? PointTypeActiveDate { get; private set; }

    /// <summary>
    /// TelephoneNumber of the CashCustomer
    /// TelephoneNumber الخاص بـ CashCustomer
    /// </summary>
    public string TelephoneNumber { get; private set; }

    /// <summary>
    /// FaxNumber of the CashCustomer
    /// FaxNumber الخاص بـ CashCustomer
    /// </summary>
    public string FaxNumber { get; private set; }

    /// <summary>
    /// PBox of the CashCustomer
    /// PBox الخاص بـ CashCustomer
    /// </summary>
    public string PBox { get; private set; }

    /// <summary>
    /// Email of the CashCustomer
    /// Email الخاص بـ CashCustomer
    /// </summary>
    public string Email { get; private set; }

    /// <summary>
    /// Website of the CashCustomer
    /// Website الخاص بـ CashCustomer
    /// </summary>
    public string Website { get; private set; }

    /// <summary>
    /// RegionCode of the CashCustomer
    /// RegionCode الخاص بـ CashCustomer
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CityNumber of the CashCustomer
    /// CityNumber الخاص بـ CashCustomer
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// RepCode of the CashCustomer
    /// RepCode الخاص بـ CashCustomer
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// Address of the CashCustomer
    /// Address الخاص بـ CashCustomer
    /// </summary>
    public string Address { get; private set; }

    /// <summary>
    /// BirthDate of the CashCustomer
    /// BirthDate الخاص بـ CashCustomer
    /// </summary>
    public DateTime? BirthDate { get; private set; }

    /// <summary>
    /// FirstDealDate of the CashCustomer
    /// FirstDealDate الخاص بـ CashCustomer
    /// </summary>
    public DateTime? FirstDealDate { get; private set; }

    /// <summary>
    /// ExternalPostFlag of the CashCustomer
    /// ExternalPostFlag الخاص بـ CashCustomer
    /// </summary>
    public decimal? ExternalPostFlag { get; private set; }

    /// <summary>
    /// CBoxCode of the CashCustomer
    /// CBoxCode الخاص بـ CashCustomer
    /// </summary>
    public string CBoxCode { get; private set; }

    /// <summary>
    /// Field1 of the CashCustomer
    /// Field1 الخاص بـ CashCustomer
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CashCustomer
    /// Field2 الخاص بـ CashCustomer
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CashCustomer
    /// Field3 الخاص بـ CashCustomer
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CashCustomer
    /// Field4 الخاص بـ CashCustomer
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CashCustomer
    /// Field5 الخاص بـ CashCustomer
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CashCustomer
    /// Field6 الخاص بـ CashCustomer
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CashCustomer
    /// Field7 الخاص بـ CashCustomer
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CashCustomer
    /// Field8 الخاص بـ CashCustomer
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CashCustomer
    /// Field9 الخاص بـ CashCustomer
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CashCustomer
    /// Field10 الخاص بـ CashCustomer
    /// </summary>
    public string Field10 { get; private set; }

    /// <summary>
    /// InactiveFlag of the CashCustomer
    /// InactiveFlag الخاص بـ CashCustomer
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the CashCustomer
    /// InactiveReason الخاص بـ CashCustomer
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the CashCustomer
    /// InactiveDate الخاص بـ CashCustomer
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// CreditNoDiscount of the CashCustomer
    /// CreditNoDiscount الخاص بـ CashCustomer
    /// </summary>
    public string CreditNoDiscount { get; private set; }

    /// <summary>
    /// BranchNumber of the CashCustomer
    /// BranchNumber الخاص بـ CashCustomer
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the CashCustomer
    /// CompanyNumberShort الخاص بـ CashCustomer
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// CCmpnyNm of the CashCustomer
    /// CCmpnyNm الخاص بـ CashCustomer
    /// </summary>
    public string CCmpnyNm { get; private set; }

    /// <summary>
    /// CActvtyTyp of the CashCustomer
    /// CActvtyTyp الخاص بـ CashCustomer
    /// </summary>
    public decimal? CActvtyTyp { get; private set; }

    /// <summary>
    /// CActvtnCode of the CashCustomer
    /// CActvtnCode الخاص بـ CashCustomer
    /// </summary>
    public decimal? CActvtnCode { get; private set; }

    /// <summary>
    /// CActvtnFlg of the CashCustomer
    /// CActvtnFlg الخاص بـ CashCustomer
    /// </summary>
    public decimal? CActvtnFlg { get; private set; }

    /// <summary>
    /// BlackListFlag of the CashCustomer
    /// BlackListFlag الخاص بـ CashCustomer
    /// </summary>
    public decimal? BlackListFlag { get; private set; }

    /// <summary>
    /// BlackListReason of the CashCustomer
    /// BlackListReason الخاص بـ CashCustomer
    /// </summary>
    public string BlackListReason { get; private set; }

    /// <summary>
    /// BlackListDate of the CashCustomer
    /// BlackListDate الخاص بـ CashCustomer
    /// </summary>
    public DateTime? BlackListDate { get; private set; }

    /// <summary>
    /// RegionNumber of the CashCustomer
    /// RegionNumber الخاص بـ CashCustomer
    /// </summary>
    public decimal? RegionNumber { get; private set; }

    /// <summary>
    /// CustomerBuildingNumber of the CashCustomer
    /// CustomerBuildingNumber الخاص بـ CashCustomer
    /// </summary>
    public string CustomerBuildingNumber { get; private set; }

    /// <summary>
    /// CustomerFloorNumber of the CashCustomer
    /// CustomerFloorNumber الخاص بـ CashCustomer
    /// </summary>
    public string CustomerFloorNumber { get; private set; }

    /// <summary>
    /// CustomerApartmentNumber of the CashCustomer
    /// CustomerApartmentNumber الخاص بـ CashCustomer
    /// </summary>
    public string CustomerApartmentNumber { get; private set; }

    /// <summary>
    /// CountryNumber of the CashCustomer
    /// CountryNumber الخاص بـ CashCustomer
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the CashCustomer
    /// ProvinceNumber الخاص بـ CashCustomer
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CPwd of the CashCustomer
    /// CPwd الخاص بـ CashCustomer
    /// </summary>
    public string CPwd { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
