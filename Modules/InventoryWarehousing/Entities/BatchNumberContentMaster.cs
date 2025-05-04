using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BatchNumberContentMaster Entity
/// </summary>
public class BatchNumberContentMaster : Entity<BatchNumberContentMasterId>
{
    private BatchNumberContentMaster() { }

    /// <summary>
    /// The unique identifier for the BatchNumberContentMaster
    /// المعرف الفريد لـ BatchNumberContentMaster
    /// </summary>
    public BatchNumberContentMasterId Id { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BatchNumberContentMaster
    /// ColumnNumberShort الخاص بـ BatchNumberContentMaster
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// SizeColumn of the BatchNumberContentMaster
    /// SizeColumn الخاص بـ BatchNumberContentMaster
    /// </summary>
    public decimal? SizeColumn { get; private set; }

    /// <summary>
    /// SpecialColorByItem of the BatchNumberContentMaster
    /// SpecialColorByItem الخاص بـ BatchNumberContentMaster
    /// </summary>
    public decimal? SpecialColorByItem { get; private set; }

    /// <summary>
    /// ShowBatchColumnInScreen of the BatchNumberContentMaster
    /// ShowBatchColumnInScreen الخاص بـ BatchNumberContentMaster
    /// </summary>
    public decimal? ShowBatchColumnInScreen { get; private set; }

    /// <summary>
    /// ColorSizeFlag of the BatchNumberContentMaster
    /// ColorSizeFlag الخاص بـ BatchNumberContentMaster
    /// </summary>
    public decimal? ColorSizeFlag { get; private set; }
}
}
