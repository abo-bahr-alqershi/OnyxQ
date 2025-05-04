using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// MeasureDiscountItemDetail Entity
/// </summary>
public class MeasureDiscountItemDetail : Entity<MeasureDiscountItemDetailId>
{
    private MeasureDiscountItemDetail() { }

    /// <summary>
    /// The unique identifier for the MeasureDiscountItemDetail
    /// المعرف الفريد لـ MeasureDiscountItemDetail
    /// </summary>
    public MeasureDiscountItemDetailId Id { get; private set; }

    /// <summary>
    /// ItemCode of the MeasureDiscountItemDetail
    /// ItemCode الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// MeasureNumber of the MeasureDiscountItemDetail
    /// MeasureNumber الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public decimal? MeasureNumber { get; private set; }

    /// <summary>
    /// MeasureLastName of the MeasureDiscountItemDetail
    /// MeasureLastName الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public string MeasureLastName { get; private set; }

    /// <summary>
    /// MeasureFirstNameFull of the MeasureDiscountItemDetail
    /// MeasureFirstNameFull الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public string MeasureFirstNameFull { get; private set; }

    /// <summary>
    /// DocSeq of the MeasureDiscountItemDetail
    /// DocSeq الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// MeasureNumberReference of the MeasureDiscountItemDetail
    /// MeasureNumberReference الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public decimal? MeasureNumberReference { get; private set; }

    /// <summary>
    /// MeasureImage of the MeasureDiscountItemDetail
    /// MeasureImage الخاص بـ MeasureDiscountItemDetail
    /// </summary>
    public string MeasureImage { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to MeasureDiscountItemMaster
    /// </summary>
    public MeasureDiscountItemMaster MeasureDiscountItemMaster { get; private set; }
    #endregion
}
}
