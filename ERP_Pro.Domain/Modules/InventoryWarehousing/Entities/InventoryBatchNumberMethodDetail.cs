using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// InventoryBatchNumberMethodDetail Entity
/// </summary>
public class InventoryBatchNumberMethodDetail : Entity<InventoryBatchNumberMethodDetailId>
{

    private InventoryBatchNumberMethodDetail() { }

    public InventoryBatchNumberMethodDetail(InventoryBatchNumberMethodDetailId id)
    {
        Id = id;
    }

    /// <summary>
    /// The unique identifier for the InventoryBatchNumberMethodDetail
    /// المعرف الفريد لـ InventoryBatchNumberMethodDetail
    /// </summary>
    public InventoryBatchNumberMethodDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the InventoryBatchNumberMethodDetail
    /// RecordNumber الخاص بـ InventoryBatchNumberMethodDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// FieldNameShort of the InventoryBatchNumberMethodDetail
    /// FieldNameShort الخاص بـ InventoryBatchNumberMethodDetail
    /// </summary>
    public decimal? FieldNameShort { get; private set; }

    /// <summary>
    /// FieldLength of the InventoryBatchNumberMethodDetail
    /// FieldLength الخاص بـ InventoryBatchNumberMethodDetail
    /// </summary>
    public decimal? FieldLength { get; private set; }

    /// <summary>
    /// FieldCode of the InventoryBatchNumberMethodDetail
    /// FieldCode الخاص بـ InventoryBatchNumberMethodDetail
    /// </summary>
    public string FieldCode { get; private set; }

    /// <summary>
    /// FieldFormat of the InventoryBatchNumberMethodDetail
    /// FieldFormat الخاص بـ InventoryBatchNumberMethodDetail
    /// </summary>
    public string FieldFormat { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public InventoryBatchNumberMethodMaster InventoryBatchNumberMethodMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
