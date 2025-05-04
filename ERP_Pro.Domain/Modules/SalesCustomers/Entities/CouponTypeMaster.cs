using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CouponTypeMaster Entity
/// </summary>
public class CouponTypeMaster : Entity<CouponTypeMasterId>
{

    private CouponTypeMaster() { }

    public CouponTypeMaster(CouponTypeMasterId id, decimal? couponTypeNumber)
    {
        Id = id;
        CouponTypeNumber = couponTypeNumber;
    }

    /// <summary>
    /// The unique identifier for the CouponTypeMaster
    /// المعرف الفريد لـ CouponTypeMaster
    /// </summary>
    public CouponTypeMasterId Id { get; private set; }

    /// <summary>
    /// CouponTypeNumber of the CouponTypeMaster
    /// CouponTypeNumber الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? CouponTypeNumber { get; private set; }

    /// <summary>
    /// CouponTypeLastName of the CouponTypeMaster
    /// CouponTypeLastName الخاص بـ CouponTypeMaster
    /// </summary>
    public string CouponTypeLastName { get; private set; }

    /// <summary>
    /// CouponTypeFirstName of the CouponTypeMaster
    /// CouponTypeFirstName الخاص بـ CouponTypeMaster
    /// </summary>
    public string CouponTypeFirstName { get; private set; }

    /// <summary>
    /// CouponClass of the CouponTypeMaster
    /// CouponClass الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? CouponClass { get; private set; }

    /// <summary>
    /// CouponUseMethod of the CouponTypeMaster
    /// CouponUseMethod الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? CouponUseMethod { get; private set; }

    /// <summary>
    /// CouponReplaceMethod of the CouponTypeMaster
    /// CouponReplaceMethod الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? CouponReplaceMethod { get; private set; }

    /// <summary>
    /// AccountCodeInterface of the CouponTypeMaster
    /// AccountCodeInterface الخاص بـ CouponTypeMaster
    /// </summary>
    public string AccountCodeInterface { get; private set; }

    /// <summary>
    /// UseBookNumber of the CouponTypeMaster
    /// UseBookNumber الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? UseBookNumber { get; private set; }

    /// <summary>
    /// BookCategoryCode of the CouponTypeMaster
    /// BookCategoryCode الخاص بـ CouponTypeMaster
    /// </summary>
    public string BookCategoryCode { get; private set; }

    /// <summary>
    /// BookCouponCount of the CouponTypeMaster
    /// BookCouponCount الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookCouponCount { get; private set; }

    /// <summary>
    /// BookSerialType of the CouponTypeMaster
    /// BookSerialType الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookSerialType { get; private set; }

    /// <summary>
    /// BookConnectedCustomer of the CouponTypeMaster
    /// BookConnectedCustomer الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookConnectedCustomer { get; private set; }

    /// <summary>
    /// BookSerialIncludeCategory of the CouponTypeMaster
    /// BookSerialIncludeCategory الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookSerialIncludeCategory { get; private set; }

    /// <summary>
    /// BookLimitCouponBeforeExpire of the CouponTypeMaster
    /// BookLimitCouponBeforeExpire الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookLimitCouponBeforeExpire { get; private set; }

    /// <summary>
    /// BookUpdateDefaultPrice of the CouponTypeMaster
    /// BookUpdateDefaultPrice الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookUpdateDefaultPrice { get; private set; }

    /// <summary>
    /// BookPriceType of the CouponTypeMaster
    /// BookPriceType الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookPriceType { get; private set; }

    /// <summary>
    /// BookDefaultPrice of the CouponTypeMaster
    /// BookDefaultPrice الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookDefaultPrice { get; private set; }

    /// <summary>
    /// BookMinPrice of the CouponTypeMaster
    /// BookMinPrice الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookMinPrice { get; private set; }

    /// <summary>
    /// BookMaxPrice of the CouponTypeMaster
    /// BookMaxPrice الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookMaxPrice { get; private set; }

    /// <summary>
    /// BookSerialDigitCount of the CouponTypeMaster
    /// BookSerialDigitCount الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? BookSerialDigitCount { get; private set; }

    /// <summary>
    /// CouponSerialDigitCount of the CouponTypeMaster
    /// CouponSerialDigitCount الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? CouponSerialDigitCount { get; private set; }

    /// <summary>
    /// CouponDescription of the CouponTypeMaster
    /// CouponDescription الخاص بـ CouponTypeMaster
    /// </summary>
    public string CouponDescription { get; private set; }

    /// <summary>
    /// VatPercent of the CouponTypeMaster
    /// VatPercent الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? VatPercent { get; private set; }

    /// <summary>
    /// AccountCodeDiscount of the CouponTypeMaster
    /// AccountCodeDiscount الخاص بـ CouponTypeMaster
    /// </summary>
    public string AccountCodeDiscount { get; private set; }

    /// <summary>
    /// InactiveReason of the CouponTypeMaster
    /// InactiveReason الخاص بـ CouponTypeMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveFlag of the CouponTypeMaster
    /// InactiveFlag الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the CouponTypeMaster
    /// InactiveDate الخاص بـ CouponTypeMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the CouponTypeMaster
    /// InactivatedByUserId الخاص بـ CouponTypeMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// Field1 of the CouponTypeMaster
    /// Field1 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the CouponTypeMaster
    /// Field2 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the CouponTypeMaster
    /// Field3 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the CouponTypeMaster
    /// Field4 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the CouponTypeMaster
    /// Field5 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field5 { get; private set; }

    /// <summary>
    /// Field6 of the CouponTypeMaster
    /// Field6 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field6 { get; private set; }

    /// <summary>
    /// Field7 of the CouponTypeMaster
    /// Field7 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field7 { get; private set; }

    /// <summary>
    /// Field8 of the CouponTypeMaster
    /// Field8 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field8 { get; private set; }

    /// <summary>
    /// Field9 of the CouponTypeMaster
    /// Field9 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field9 { get; private set; }

    /// <summary>
    /// Field10 of the CouponTypeMaster
    /// Field10 الخاص بـ CouponTypeMaster
    /// </summary>
    public string Field10 { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
