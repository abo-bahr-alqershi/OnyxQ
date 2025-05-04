using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// Collector Entity
/// </summary>
public class Collector : Entity<CollectorId>
{
    private Collector() { }

    /// <summary>
    /// The unique identifier for the Collector
    /// المعرف الفريد لـ Collector
    /// </summary>
    public CollectorId Id { get; private set; }

    /// <summary>
    /// ColumnSerial of the Collector
    /// ColumnSerial الخاص بـ Collector
    /// </summary>
    public decimal? ColumnSerial { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the Collector
    /// ColumnNumberShort الخاص بـ Collector
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// ColumnName of the Collector
    /// ColumnName الخاص بـ Collector
    /// </summary>
    public string ColumnName { get; private set; }

    /// <summary>
    /// ColumnNameEnglish of the Collector
    /// ColumnNameEnglish الخاص بـ Collector
    /// </summary>
    public string ColumnNameEnglish { get; private set; }

    /// <summary>
    /// RegionCode of the Collector
    /// RegionCode الخاص بـ Collector
    /// </summary>
    public decimal? RegionCode { get; private set; }

    /// <summary>
    /// InactiveFlag of the Collector
    /// InactiveFlag الخاص بـ Collector
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the Collector
    /// InactiveDate الخاص بـ Collector
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Collector
    /// InactiveReason الخاص بـ Collector
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// ColumnNotes of the Collector
    /// ColumnNotes الخاص بـ Collector
    /// </summary>
    public string ColumnNotes { get; private set; }

    /// <summary>
    /// ColumnTelephone of the Collector
    /// ColumnTelephone الخاص بـ Collector
    /// </summary>
    public string ColumnTelephone { get; private set; }

    /// <summary>
    /// ColumnMobile of the Collector
    /// ColumnMobile الخاص بـ Collector
    /// </summary>
    public string ColumnMobile { get; private set; }

    /// <summary>
    /// CollectorAddress of the Collector
    /// CollectorAddress الخاص بـ Collector
    /// </summary>
    public string CollectorAddress { get; private set; }

    /// <summary>
    /// ColumnEmail of the Collector
    /// ColumnEmail الخاص بـ Collector
    /// </summary>
    public string ColumnEmail { get; private set; }

    /// <summary>
    /// CommissionPercent of the Collector
    /// CommissionPercent الخاص بـ Collector
    /// </summary>
    public decimal? CommissionPercent { get; private set; }

    /// <summary>
    /// CashNumber of the Collector
    /// CashNumber الخاص بـ Collector
    /// </summary>
    public decimal? CashNumber { get; private set; }

    /// <summary>
    /// ColumnACode of the Collector
    /// ColumnACode الخاص بـ Collector
    /// </summary>
    public string ColumnACode { get; private set; }

    /// <summary>
    /// AccountDetailCode of the Collector
    /// AccountDetailCode الخاص بـ Collector
    /// </summary>
    public string AccountDetailCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the Collector
    /// AccountDetailType الخاص بـ Collector
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// Field1 of the Collector
    /// Field1 الخاص بـ Collector
    /// </summary>
    public string Field1 { get; private set; }

    /// <summary>
    /// Field2 of the Collector
    /// Field2 الخاص بـ Collector
    /// </summary>
    public string Field2 { get; private set; }

    /// <summary>
    /// Field3 of the Collector
    /// Field3 الخاص بـ Collector
    /// </summary>
    public string Field3 { get; private set; }

    /// <summary>
    /// Field4 of the Collector
    /// Field4 الخاص بـ Collector
    /// </summary>
    public string Field4 { get; private set; }

    /// <summary>
    /// Field5 of the Collector
    /// Field5 الخاص بـ Collector
    /// </summary>
    public string Field5 { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: Collector to JournalFileDetail
    /// </summary>
    public IReadOnlyCollection<JournalFileDetail> JournalFileDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to GeneralLedgerRequestExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestExchangeCurrencyDetail> GeneralLedgerRequestExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to GeneralLedgerRequestVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerRequestVoucherMasterAccount> GeneralLedgerRequestVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to GeneralLedgerVoucherMasterAccount
    /// </summary>
    public IReadOnlyCollection<GeneralLedgerVoucherMasterAccount> GeneralLedgerVoucherMasterAccounts { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to JournalVoucherDetail
    /// </summary>
    public IReadOnlyCollection<JournalVoucherDetail> JournalVoucherDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to Voucher
    /// </summary>
    public IReadOnlyCollection<Voucher> Vouchers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to ExchangeCurrencyDetail
    /// </summary>
    public IReadOnlyCollection<ExchangeCurrencyDetail> ExchangeCurrencyDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to Customer
    /// </summary>
    public IReadOnlyCollection<Customer> Customers { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to SalesOrder
    /// </summary>
    public IReadOnlyCollection<SalesOrder> SalesOrders { get; private set; }
    /// <summary>
    /// ManyToOne relationship to Region
    /// </summary>
    public Region Region { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to CustomerCollector
    /// </summary>
    public IReadOnlyCollection<CustomerCollector> CustomerCollectors { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to BillMaster
    /// </summary>
    public IReadOnlyCollection<BillMaster> BillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to CollectionPlan
    /// </summary>
    public IReadOnlyCollection<CollectionPlan> CollectionPlans { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to GuaranteeDetail
    /// </summary>
    public IReadOnlyCollection<GuaranteeDetail> GuaranteeDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to StationBillMaster
    /// </summary>
    public IReadOnlyCollection<StationBillMaster> StationBillMasters { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to RequestJournalDetail
    /// </summary>
    public IReadOnlyCollection<RequestJournalDetail> RequestJournalDetails { get; private set; }
    /// <summary>
    /// One-to-many relationship: Collector to RequestVoucherMaster
    /// </summary>
    public IReadOnlyCollection<RequestVoucherMaster> RequestVoucherMasters { get; private set; }
    #endregion
}
}
