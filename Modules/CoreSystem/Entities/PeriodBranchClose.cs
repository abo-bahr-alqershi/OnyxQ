using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// PeriodBranchClose Entity
/// </summary>
public class PeriodBranchClose : Entity<PeriodBranchCloseId>
{
    private PeriodBranchClose() { }

    /// <summary>
    /// The unique identifier for the PeriodBranchClose
    /// المعرف الفريد لـ PeriodBranchClose
    /// </summary>
    public PeriodBranchCloseId Id { get; private set; }

    /// <summary>
    /// PeriodTypeShort of the PeriodBranchClose
    /// PeriodTypeShort الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PeriodTypeShort { get; private set; }

    /// <summary>
    /// PeriodNumberShort of the PeriodBranchClose
    /// PeriodNumberShort الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PeriodNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the PeriodBranchClose
    /// BranchNumber الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// FDate of the PeriodBranchClose
    /// FDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? FDate { get; private set; }

    /// <summary>
    /// TDate of the PeriodBranchClose
    /// TDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? TDate { get; private set; }

    /// <summary>
    /// YearNumber of the PeriodBranchClose
    /// YearNumber الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? YearNumber { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the PeriodBranchClose
    /// InactiveFlagAlt الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// PeriodClass of the PeriodBranchClose
    /// PeriodClass الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PeriodClass { get; private set; }

    /// <summary>
    /// PeriodClassUserId of the PeriodBranchClose
    /// PeriodClassUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PeriodClassUserId { get; private set; }

    /// <summary>
    /// PeriodClassDate of the PeriodBranchClose
    /// PeriodClassDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? PeriodClassDate { get; private set; }

    /// <summary>
    /// PeriodUncloseUserIdShort of the PeriodBranchClose
    /// PeriodUncloseUserIdShort الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PeriodUncloseUserIdShort { get; private set; }

    /// <summary>
    /// PeriodUncloseDateShort of the PeriodBranchClose
    /// PeriodUncloseDateShort الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? PeriodUncloseDateShort { get; private set; }

    /// <summary>
    /// PeriodClassCount of the PeriodBranchClose
    /// PeriodClassCount الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PeriodClassCount { get; private set; }

    /// <summary>
    /// PlaceClass of the PeriodBranchClose
    /// PlaceClass الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PlaceClass { get; private set; }

    /// <summary>
    /// PlaceClassCount of the PeriodBranchClose
    /// PlaceClassCount الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PlaceClassCount { get; private set; }

    /// <summary>
    /// PlaceClassUserId of the PeriodBranchClose
    /// PlaceClassUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PlaceClassUserId { get; private set; }

    /// <summary>
    /// PlaceClassDate of the PeriodBranchClose
    /// PlaceClassDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? PlaceClassDate { get; private set; }

    /// <summary>
    /// PlaceUncloseUserId of the PeriodBranchClose
    /// PlaceUncloseUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PlaceUncloseUserId { get; private set; }

    /// <summary>
    /// PlaceUncloseDate of the PeriodBranchClose
    /// PlaceUncloseDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? PlaceUncloseDate { get; private set; }

    /// <summary>
    /// InvoiceClass of the PeriodBranchClose
    /// InvoiceClass الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? InvoiceClass { get; private set; }

    /// <summary>
    /// InvoiceClassUserId of the PeriodBranchClose
    /// InvoiceClassUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? InvoiceClassUserId { get; private set; }

    /// <summary>
    /// InvoiceClassDate of the PeriodBranchClose
    /// InvoiceClassDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? InvoiceClassDate { get; private set; }

    /// <summary>
    /// InvoiceClassCount of the PeriodBranchClose
    /// InvoiceClassCount الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? InvoiceClassCount { get; private set; }

    /// <summary>
    /// InvoiceUncloseUserId of the PeriodBranchClose
    /// InvoiceUncloseUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? InvoiceUncloseUserId { get; private set; }

    /// <summary>
    /// InvoiceUncloseDate of the PeriodBranchClose
    /// InvoiceUncloseDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? InvoiceUncloseDate { get; private set; }

    /// <summary>
    /// DeprCls of the PeriodBranchClose
    /// DeprCls الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? DeprCls { get; private set; }

    /// <summary>
    /// DeprClsUId of the PeriodBranchClose
    /// DeprClsUId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? DeprClsUId { get; private set; }

    /// <summary>
    /// DeprClsDate of the PeriodBranchClose
    /// DeprClsDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? DeprClsDate { get; private set; }

    /// <summary>
    /// DeprClsCnt of the PeriodBranchClose
    /// DeprClsCnt الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? DeprClsCnt { get; private set; }

    /// <summary>
    /// DeprUnclsUId of the PeriodBranchClose
    /// DeprUnclsUId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? DeprUnclsUId { get; private set; }

    /// <summary>
    /// DeprUnclsDate of the PeriodBranchClose
    /// DeprUnclsDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? DeprUnclsDate { get; private set; }

    /// <summary>
    /// MrpClass of the PeriodBranchClose
    /// MrpClass الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? MrpClass { get; private set; }

    /// <summary>
    /// MrpClassCount of the PeriodBranchClose
    /// MrpClassCount الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? MrpClassCount { get; private set; }

    /// <summary>
    /// MrpClassUserId of the PeriodBranchClose
    /// MrpClassUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? MrpClassUserId { get; private set; }

    /// <summary>
    /// MrpClassDate of the PeriodBranchClose
    /// MrpClassDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? MrpClassDate { get; private set; }

    /// <summary>
    /// MrpUncloseUserId of the PeriodBranchClose
    /// MrpUncloseUserId الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? MrpUncloseUserId { get; private set; }

    /// <summary>
    /// MrpUncloseDate of the PeriodBranchClose
    /// MrpUncloseDate الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? MrpUncloseDate { get; private set; }

    /// <summary>
    /// FixedAssetPeriod of the PeriodBranchClose
    /// FixedAssetPeriod الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? FixedAssetPeriod { get; private set; }

    /// <summary>
    /// PlaceAccountCodeClass of the PeriodBranchClose
    /// PlaceAccountCodeClass الخاص بـ PeriodBranchClose
    /// </summary>
    public string PlaceAccountCodeClass { get; private set; }

    /// <summary>
    /// PlaceAmountClass of the PeriodBranchClose
    /// PlaceAmountClass الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? PlaceAmountClass { get; private set; }

    /// <summary>
    /// ReverseClose of the PeriodBranchClose
    /// ReverseClose الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? ReverseClose { get; private set; }

    /// <summary>
    /// ReverseFromDateClose of the PeriodBranchClose
    /// ReverseFromDateClose الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? ReverseFromDateClose { get; private set; }

    /// <summary>
    /// ReverseToDateClose of the PeriodBranchClose
    /// ReverseToDateClose الخاص بـ PeriodBranchClose
    /// </summary>
    public DateTime? ReverseToDateClose { get; private set; }

    /// <summary>
    /// CurDiffCls of the PeriodBranchClose
    /// CurDiffCls الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? CurDiffCls { get; private set; }

    /// <summary>
    /// CurDiffClsWthCc of the PeriodBranchClose
    /// CurDiffClsWthCc الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? CurDiffClsWthCc { get; private set; }

    /// <summary>
    /// CurDiffClsWthPj of the PeriodBranchClose
    /// CurDiffClsWthPj الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? CurDiffClsWthPj { get; private set; }

    /// <summary>
    /// CurDiffClsWthActv of the PeriodBranchClose
    /// CurDiffClsWthActv الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? CurDiffClsWthActv { get; private set; }

    /// <summary>
    /// CurRateFlgCls of the PeriodBranchClose
    /// CurRateFlgCls الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? CurRateFlgCls { get; private set; }

    /// <summary>
    /// CurRateTypFlgCls of the PeriodBranchClose
    /// CurRateTypFlgCls الخاص بـ PeriodBranchClose
    /// </summary>
    public decimal? CurRateTypFlgCls { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to PeriodMaster
    /// </summary>
    public PeriodMaster PeriodMaster { get; private set; }
    #endregion
}
}
