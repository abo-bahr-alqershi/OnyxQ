using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.ProjectsRegions.Entities;
using ERP_Pro.Domain.ERP.CoreSystem.Entities;
using ERP_Pro.Domain.ERP.GeneralLedger.Entities;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities;
using ERP_Pro.Domain.ERP.StationsFuel.Entities;
using ERP_Pro.Domain.ERP.FormsSurveys.Entities;

namespace ERP_Pro.Domain.ERP.SalesCustomers.Entities
{
/// <summary>
/// Collector Entity
/// </summary>
public class Collector : Entity<CollectorId>
{

    private Collector() { }

    public Collector(CollectorId id, decimal? columnNumberShort)
    {
        Id = id;
        ColumnNumberShort = columnNumberShort;
    }

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
    /// Reference relationship: ManyToOne
    /// </summary>
    public Region Region { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
