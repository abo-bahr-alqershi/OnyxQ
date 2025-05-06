using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// MeasureDiscountItemTransaction Entity
/// </summary>
public class MeasureDiscountItemTransaction : Entity<MeasureDiscountItemTransactionId>
{

    private MeasureDiscountItemTransaction() { }

    public MeasureDiscountItemTransaction(MeasureDiscountItemTransactionId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the MeasureDiscountItemTransaction
    /// المعرف الفريد لـ MeasureDiscountItemTransaction
    /// </summary>
    public MeasureDiscountItemTransactionId Id { get; private set; }

    /// <summary>
    /// DocNo of the MeasureDiscountItemTransaction
    /// DocNo الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public decimal? DocNo { get; private set; }

    /// <summary>
    /// DocSer of the MeasureDiscountItemTransaction
    /// DocSer الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public decimal? DocSer { get; private set; }

    /// <summary>
    /// MeasureNumber of the MeasureDiscountItemTransaction
    /// MeasureNumber الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public decimal? MeasureNumber { get; private set; }

    /// <summary>
    /// MeasureValue of the MeasureDiscountItemTransaction
    /// MeasureValue الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public string MeasureValue { get; private set; }

    /// <summary>
    /// MeasureDescription of the MeasureDiscountItemTransaction
    /// MeasureDescription الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public string MeasureDescription { get; private set; }

    /// <summary>
    /// DocSeq of the MeasureDiscountItemTransaction
    /// DocSeq الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public decimal? DocSeq { get; private set; }

    /// <summary>
    /// DocType of the MeasureDiscountItemTransaction
    /// DocType الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public decimal? DocType { get; private set; }

    /// <summary>
    /// CCode of the MeasureDiscountItemTransaction
    /// CCode الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public string CCode { get; private set; }

    /// <summary>
    /// CName of the MeasureDiscountItemTransaction
    /// CName الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public string CName { get; private set; }

    /// <summary>
    /// BranchNumber of the MeasureDiscountItemTransaction
    /// BranchNumber الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// DocDate of the MeasureDiscountItemTransaction
    /// DocDate الخاص بـ MeasureDiscountItemTransaction
    /// </summary>
    public DateTime? DocDate { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ItemMaster ItemMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

