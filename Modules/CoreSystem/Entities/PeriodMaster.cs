using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// PeriodMaster Entity
/// </summary>
public class PeriodMaster : Entity<PeriodMasterId>
{
    private PeriodMaster() { }

    /// <summary>
    /// The unique identifier for the PeriodMaster
    /// المعرف الفريد لـ PeriodMaster
    /// </summary>
    public PeriodMasterId Id { get; private set; }

    /// <summary>
    /// PeriodCount of the PeriodMaster
    /// PeriodCount الخاص بـ PeriodMaster
    /// </summary>
    public decimal? PeriodCount { get; private set; }

    /// <summary>
    /// PeriodTypeShort of the PeriodMaster
    /// PeriodTypeShort الخاص بـ PeriodMaster
    /// </summary>
    public decimal? PeriodTypeShort { get; private set; }

    /// <summary>
    /// FPeriodNumber of the PeriodMaster
    /// FPeriodNumber الخاص بـ PeriodMaster
    /// </summary>
    public decimal? FPeriodNumber { get; private set; }

    /// <summary>
    /// TPeriodNumber of the PeriodMaster
    /// TPeriodNumber الخاص بـ PeriodMaster
    /// </summary>
    public decimal? TPeriodNumber { get; private set; }

    /// <summary>
    /// FYearNumber of the PeriodMaster
    /// FYearNumber الخاص بـ PeriodMaster
    /// </summary>
    public decimal? FYearNumber { get; private set; }

    /// <summary>
    /// TYearNumber of the PeriodMaster
    /// TYearNumber الخاص بـ PeriodMaster
    /// </summary>
    public decimal? TYearNumber { get; private set; }

    /// <summary>
    /// PlaceClass of the PeriodMaster
    /// PlaceClass الخاص بـ PeriodMaster
    /// </summary>
    public decimal? PlaceClass { get; private set; }

    /// <summary>
    /// PlaceClassUserId of the PeriodMaster
    /// PlaceClassUserId الخاص بـ PeriodMaster
    /// </summary>
    public decimal? PlaceClassUserId { get; private set; }

    /// <summary>
    /// PlaceClassDate of the PeriodMaster
    /// PlaceClassDate الخاص بـ PeriodMaster
    /// </summary>
    public DateTime? PlaceClassDate { get; private set; }

    /// <summary>
    /// InvoiceClass of the PeriodMaster
    /// InvoiceClass الخاص بـ PeriodMaster
    /// </summary>
    public decimal? InvoiceClass { get; private set; }

    /// <summary>
    /// InvoiceClassUserId of the PeriodMaster
    /// InvoiceClassUserId الخاص بـ PeriodMaster
    /// </summary>
    public decimal? InvoiceClassUserId { get; private set; }

    /// <summary>
    /// InvoiceClassDate of the PeriodMaster
    /// InvoiceClassDate الخاص بـ PeriodMaster
    /// </summary>
    public DateTime? InvoiceClassDate { get; private set; }

    /// <summary>
    /// YearClose of the PeriodMaster
    /// YearClose الخاص بـ PeriodMaster
    /// </summary>
    public decimal? YearClose { get; private set; }

    /// <summary>
    /// YearCloseUserId of the PeriodMaster
    /// YearCloseUserId الخاص بـ PeriodMaster
    /// </summary>
    public decimal? YearCloseUserId { get; private set; }

    /// <summary>
    /// YearCloseDate of the PeriodMaster
    /// YearCloseDate الخاص بـ PeriodMaster
    /// </summary>
    public DateTime? YearCloseDate { get; private set; }

    /// <summary>
    /// FixedAssetClass of the PeriodMaster
    /// FixedAssetClass الخاص بـ PeriodMaster
    /// </summary>
    public decimal? FixedAssetClass { get; private set; }

    /// <summary>
    /// FixedAssetClassUserId of the PeriodMaster
    /// FixedAssetClassUserId الخاص بـ PeriodMaster
    /// </summary>
    public decimal? FixedAssetClassUserId { get; private set; }

    /// <summary>
    /// FixedAssetClassDate of the PeriodMaster
    /// FixedAssetClassDate الخاص بـ PeriodMaster
    /// </summary>
    public DateTime? FixedAssetClassDate { get; private set; }

    /// <summary>
    /// OpenNewYearFlag of the PeriodMaster
    /// OpenNewYearFlag الخاص بـ PeriodMaster
    /// </summary>
    public decimal? OpenNewYearFlag { get; private set; }

    /// <summary>
    /// OpenNewYearUserId of the PeriodMaster
    /// OpenNewYearUserId الخاص بـ PeriodMaster
    /// </summary>
    public decimal? OpenNewYearUserId { get; private set; }

    /// <summary>
    /// OpenNewYearDate of the PeriodMaster
    /// OpenNewYearDate الخاص بـ PeriodMaster
    /// </summary>
    public DateTime? OpenNewYearDate { get; private set; }

    /// <summary>
    /// InvoiceStartWork of the PeriodMaster
    /// InvoiceStartWork الخاص بـ PeriodMaster
    /// </summary>
    public decimal? InvoiceStartWork { get; private set; }

    /// <summary>
    /// InvoiceStartWorkUserId of the PeriodMaster
    /// InvoiceStartWorkUserId الخاص بـ PeriodMaster
    /// </summary>
    public decimal? InvoiceStartWorkUserId { get; private set; }

    /// <summary>
    /// InvoiceStartWorkDate of the PeriodMaster
    /// InvoiceStartWorkDate الخاص بـ PeriodMaster
    /// </summary>
    public DateTime? InvoiceStartWorkDate { get; private set; }

    /// <summary>
    /// InvoiceClassMethod of the PeriodMaster
    /// InvoiceClassMethod الخاص بـ PeriodMaster
    /// </summary>
    public decimal? InvoiceClassMethod { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: PeriodMaster to PeriodBranchClose
    /// </summary>
    public IReadOnlyCollection<PeriodBranchClose> PeriodBranchCloses { get; private set; }
    /// <summary>
    /// One-to-many relationship: PeriodMaster to PeriodDetail
    /// </summary>
    public IReadOnlyCollection<PeriodDetail> PeriodDetails { get; private set; }
    #endregion
}
}
