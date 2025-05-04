using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// CollectorCommissionCalculationSubDetail Entity
/// </summary>
public class CollectorCommissionCalculationSubDetail : Entity<CollectorCommissionCalculationSubDetailId>
{

    private CollectorCommissionCalculationSubDetail() { }

    public CollectorCommissionCalculationSubDetail(CollectorCommissionCalculationSubDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the CollectorCommissionCalculationSubDetail
    /// المعرف الفريد لـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public CollectorCommissionCalculationSubDetailId Id { get; private set; }

    /// <summary>
    /// CommissionTypeShort of the CollectorCommissionCalculationSubDetail
    /// CommissionTypeShort الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionTypeShort { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the CollectorCommissionCalculationSubDetail
    /// ColumnNumberShort الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// FDate of the CollectorCommissionCalculationSubDetail
    /// FDate الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the CollectorCommissionCalculationSubDetail
    /// TDate الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// CGroupCode of the CollectorCommissionCalculationSubDetail
    /// CGroupCode الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CGroupCode { get; private set; }

    /// <summary>
    /// CClass of the CollectorCommissionCalculationSubDetail
    /// CClass الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CClass { get; private set; }

    /// <summary>
    /// RegionCode of the CollectorCommissionCalculationSubDetail
    /// RegionCode الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// CCode of the CollectorCommissionCalculationSubDetail
    /// CCode الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// BillNumber of the CollectorCommissionCalculationSubDetail
    /// BillNumber الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? BillNumber { get; private set; }

    /// <summary>
    /// BillSerial of the CollectorCommissionCalculationSubDetail
    /// BillSerial الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? BillSerial { get; private set; }

    /// <summary>
    /// BillDate of the CollectorCommissionCalculationSubDetail
    /// BillDate الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public DateTime? BillDate { get; private set; }

    /// <summary>
    /// VoucherNumber of the CollectorCommissionCalculationSubDetail
    /// VoucherNumber الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? VoucherNumber { get; private set; }

    /// <summary>
    /// VendorSerialShort of the CollectorCommissionCalculationSubDetail
    /// VendorSerialShort الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? VendorSerialShort { get; private set; }

    /// <summary>
    /// VoucherDate of the CollectorCommissionCalculationSubDetail
    /// VoucherDate الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public DateTime? VoucherDate { get; private set; }

    /// <summary>
    /// CashNumber of the CollectorCommissionCalculationSubDetail
    /// CashNumber الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ColumnAmount of the CollectorCommissionCalculationSubDetail
    /// ColumnAmount الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? ColumnAmount { get; private set; }

    /// <summary>
    /// FPercent of the CollectorCommissionCalculationSubDetail
    /// FPercent الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? FPercent { get; private set; }

    /// <summary>
    /// TPercent of the CollectorCommissionCalculationSubDetail
    /// TPercent الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? TPercent { get; private set; }

    /// <summary>
    /// Period of the CollectorCommissionCalculationSubDetail
    /// Period الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? Period { get; private set; }

    /// <summary>
    /// CommissionAmountTypeShort of the CollectorCommissionCalculationSubDetail
    /// CommissionAmountTypeShort الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionAmountTypeShort { get; private set; }

    /// <summary>
    /// CommissionPercent of the CollectorCommissionCalculationSubDetail
    /// CommissionPercent الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CommissionAmount of the CollectorCommissionCalculationSubDetail
    /// CommissionAmount الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? CommissionAmount { get; private set; }

    /// <summary>
    /// DocSeq of the CollectorCommissionCalculationSubDetail
    /// DocSeq الخاص بـ CollectorCommissionCalculationSubDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
