using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxSlice Entity
/// </summary>
public class TaxSlice : Entity<TaxSliceId>
{

    private TaxSlice() { }

    public TaxSlice(TaxSliceId id, decimal? sliceNumberShort)
    {
        Id = id;
        SliceNumberShort = sliceNumberShort;
    }

    /// <summary>
    /// The unique identifier for the TaxSlice
    /// المعرف الفريد لـ TaxSlice
    /// </summary>
    public TaxSliceId Id { get; private set; }

    /// <summary>
    /// SliceNumberShort of the TaxSlice
    /// SliceNumberShort الخاص بـ TaxSlice
    /// </summary>
    public decimal? SliceNumberShort { get; private set; }

    /// <summary>
    /// SliceLastName of the TaxSlice
    /// SliceLastName الخاص بـ TaxSlice
    /// </summary>
    public string SliceLastName { get; private set; }

    /// <summary>
    /// SliceFirstName of the TaxSlice
    /// SliceFirstName الخاص بـ TaxSlice
    /// </summary>
    public string SliceFirstName { get; private set; }

    /// <summary>
    /// SlicePercent of the TaxSlice
    /// SlicePercent الخاص بـ TaxSlice
    /// </summary>
    public decimal? SlicePercent { get; private set; }

    /// <summary>
    /// DfltFlg of the TaxSlice
    /// DfltFlg الخاص بـ TaxSlice
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    /// <summary>
    /// InactiveFlag of the TaxSlice
    /// InactiveFlag الخاص بـ TaxSlice
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the TaxSlice
    /// InactivatedByUserId الخاص بـ TaxSlice
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the TaxSlice
    /// InactiveDate الخاص بـ TaxSlice
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the TaxSlice
    /// InactiveReason الخاص بـ TaxSlice
    /// </summary>
    public string InactiveReason { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
