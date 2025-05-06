using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.SalesCustomers.ValueObjects;
namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// SalesmanCommissionCalculationSubDetail Entity
/// </summary>
public class SalesmanCommissionCalculationSubDetail : Entity<SalesmanCommissionCalculationSubDetailId>
{

    private SalesmanCommissionCalculationSubDetail() { }

    public SalesmanCommissionCalculationSubDetail(SalesmanCommissionCalculationSubDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the SalesmanCommissionCalculationSubDetail
    /// المعرف الفريد لـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public SalesmanCommissionCalculationSubDetailId Id { get; private set; }

    /// <summary>
    /// DocNo of the SalesmanCommissionCalculationSubDetail
    /// DocNo الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the SalesmanCommissionCalculationSubDetail
    /// CommissionTypeShort الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// RepCode of the SalesmanCommissionCalculationSubDetail
    /// RepCode الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public string RepCode { get; private set; }

    /// <summary>
    /// FDate of the SalesmanCommissionCalculationSubDetail
    /// FDate الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the SalesmanCommissionCalculationSubDetail
    /// TDate الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CGroupCode of the SalesmanCommissionCalculationSubDetail
    /// CGroupCode الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the SalesmanCommissionCalculationSubDetail
    /// CClass الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// RegionCode of the SalesmanCommissionCalculationSubDetail
    /// RegionCode الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CCode of the SalesmanCommissionCalculationSubDetail
    /// CCode الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// BillNumber of the SalesmanCommissionCalculationSubDetail
    /// BillNumber الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the SalesmanCommissionCalculationSubDetail
    /// BillSerial الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the SalesmanCommissionCalculationSubDetail
    /// BillDate الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// VoucherNumber of the SalesmanCommissionCalculationSubDetail
    /// VoucherNumber الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// VendorSerialShort of the SalesmanCommissionCalculationSubDetail
    /// VendorSerialShort الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// VoucherDate of the SalesmanCommissionCalculationSubDetail
    /// VoucherDate الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// CashNumber of the SalesmanCommissionCalculationSubDetail
    /// CashNumber الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// FPercent of the SalesmanCommissionCalculationSubDetail
    /// FPercent الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? FPercent { get; private set; }

    /// <summary>
    /// TPercent of the SalesmanCommissionCalculationSubDetail
    /// TPercent الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? TPercent { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the SalesmanCommissionCalculationSubDetail
    /// CommissionAmountTypeShort الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionAmount of the SalesmanCommissionCalculationSubDetail
    /// CommissionAmount الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// PaidPercent of the SalesmanCommissionCalculationSubDetail
    /// PaidPercent الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? PaidPercent { get; private set; }

    /// <summary>
    /// ColumnAmount of the SalesmanCommissionCalculationSubDetail
    /// ColumnAmount الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? ColumnAmount { get; private set; }

    /// <summary>
    /// CommissionPercent of the SalesmanCommissionCalculationSubDetail
    /// CommissionPercent الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CustomerCreditPeriod of the SalesmanCommissionCalculationSubDetail
    /// CustomerCreditPeriod الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CustomerCreditPeriod { get; private set; }

    /// <summary>
    /// CreditPeriodPercent of the SalesmanCommissionCalculationSubDetail
    /// CreditPeriodPercent الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CreditPeriodPercent { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the SalesmanCommissionCalculationSubDetail
    /// ColumnNumberShort الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// CountryNumber of the SalesmanCommissionCalculationSubDetail
    /// CountryNumber الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CountryNumber { get; private set; }

    /// <summary>
    /// ProvinceNumber of the SalesmanCommissionCalculationSubDetail
    /// ProvinceNumber الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? ProvinceNumber { get; private set; }

    /// <summary>
    /// CityNumber of the SalesmanCommissionCalculationSubDetail
    /// CityNumber الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? CityNumber { get; private set; }

    /// <summary>
    /// GuarantorCode of the SalesmanCommissionCalculationSubDetail
    /// GuarantorCode الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public string GuarantorCode { get; private set; }

    /// <summary>
    /// DocType of the SalesmanCommissionCalculationSubDetail
    /// DocType الخاص بـ SalesmanCommissionCalculationSubDetail
    /// </summary>
    public decimal? DocType { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public SalesmanCommissionCalculationMaster SalesmanCommissionCalculationMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

