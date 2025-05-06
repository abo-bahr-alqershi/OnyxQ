using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.InventoryWarehousing.ValueObjects;
namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BatchNumber Entity
/// </summary>
public class BatchNumber : Entity<BatchNumberId>
{

    private BatchNumber() { }

    public BatchNumber(BatchNumberId id, string batchNumber)
    {
        Id = id;
        BatchNumber = batchNumber;
    }

    /// <summary>
    /// The unique identifier for the BatchNumber
    /// المعرف الفريد لـ BatchNumber
    /// </summary>
    public BatchNumberId Id { get; private set; }

    /// <summary>
    /// BatchNumber of the BatchNumber
    /// BatchNumber الخاص بـ BatchNumber
    /// </summary>
    public string BatchNumber { get; private set; }

    /// <summary>
    /// Column1 of the BatchNumber
    /// Column1 الخاص بـ BatchNumber
    /// </summary>
    public string Column1 { get; private set; }

    /// <summary>
    /// Column2 of the BatchNumber
    /// Column2 الخاص بـ BatchNumber
    /// </summary>
    public string Column2 { get; private set; }

    /// <summary>
    /// Column3 of the BatchNumber
    /// Column3 الخاص بـ BatchNumber
    /// </summary>
    public string Column3 { get; private set; }

    /// <summary>
    /// Column4 of the BatchNumber
    /// Column4 الخاص بـ BatchNumber
    /// </summary>
    public string Column4 { get; private set; }

    /// <summary>
    /// Column5 of the BatchNumber
    /// Column5 الخاص بـ BatchNumber
    /// </summary>
    public string Column5 { get; private set; }

    /// <summary>
    /// CompanyNumberShort of the BatchNumber
    /// CompanyNumberShort الخاص بـ BatchNumber
    /// </summary>
    public decimal? CompanyNumberShort { get; private set; }

    /// <summary>
    /// BranchNumber of the BatchNumber
    /// BranchNumber الخاص بـ BatchNumber
    /// </summary>
    public decimal? BranchNumber { get; private set; }

    /// <summary>
    /// BranchYear of the BatchNumber
    /// BranchYear الخاص بـ BatchNumber
    /// </summary>
    public decimal? BranchYear { get; private set; }

    /// <summary>
    /// BranchUser of the BatchNumber
    /// BranchUser الخاص بـ BatchNumber
    /// </summary>
    public decimal? BranchUser { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

