using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// KimbAdjustment Entity
/// </summary>
public class KimbAdjustment : Entity<KimbAdjustmentId>
{
    private KimbAdjustment() { }

    /// <summary>
    /// The unique identifier for the KimbAdjustment
    /// المعرف الفريد لـ KimbAdjustment
    /// </summary>
    public KimbAdjustmentId Id { get; private set; }

    /// <summary>
    /// AdjustmentNumber of the KimbAdjustment
    /// AdjustmentNumber الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? AdjustmentNumber { get; private set; }

    /// <summary>
    /// DocType of the KimbAdjustment
    /// DocType الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// KNumber of the KimbAdjustment
    /// KNumber الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? KNumber { get; private set; }

    /// <summary>
    /// AdjustmentAmount of the KimbAdjustment
    /// AdjustmentAmount الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? AdjustmentAmount { get; private set; }

    /// <summary>
    /// AdjustmentDate of the KimbAdjustment
    /// AdjustmentDate الخاص بـ KimbAdjustment
    /// </summary>
    public DateTime? AdjustmentDate { get; private set; }

    /// <summary>
    /// DocSer of the KimbAdjustment
    /// DocSer الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// AdjustmentSerial of the KimbAdjustment
    /// AdjustmentSerial الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? AdjustmentSerial { get; private set; }

    /// <summary>
    /// DocNo of the KimbAdjustment
    /// DocNo الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// CCode of the KimbAdjustment
    /// CCode الخاص بـ KimbAdjustment
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// DocAmt of the KimbAdjustment
    /// DocAmt الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? DocAmt { get; private set; }

    /// <summary>
    /// DocDate of the KimbAdjustment
    /// DocDate الخاص بـ KimbAdjustment
    /// </summary>
    public DateTime? DocDate { get; private set; }

    /// <summary>
    /// DocACy of the KimbAdjustment
    /// DocACy الخاص بـ KimbAdjustment
    /// </summary>
    public string DocACy { get; private set; }

    /// <summary>
    /// CostCenterCode of the KimbAdjustment
    /// CostCenterCode الخاص بـ KimbAdjustment
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// KSerial of the KimbAdjustment
    /// KSerial الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? KSerial { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the KimbAdjustment
    /// CompanyNumberShort الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the KimbAdjustment
    /// BranchNumber الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the KimbAdjustment
    /// BranchYear الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the KimbAdjustment
    /// BranchUser الخاص بـ KimbAdjustment
    /// </summary>
    public decimal? BranchUser { get; private set; }
}
}
