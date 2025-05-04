using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// BatchNumberContent Entity
/// </summary>
public class BatchNumberContent : Entity<BatchNumberContentId>
{

    private BatchNumberContent() { }

    public BatchNumberContent(BatchNumberContentId id, decimal? columnNumberShort, string batchDescriptionNumber)
    {
        Id = id;
        ColumnNumberShort = columnNumberShort;
        BatchDescriptionNumber = batchDescriptionNumber;
    }

    /// <summary>
    /// The unique identifier for the BatchNumberContent
    /// المعرف الفريد لـ BatchNumberContent
    /// </summary>
    public BatchNumberContentId Id { get; private set; }

    /// <summary>
    /// ColumnNumberShort of the BatchNumberContent
    /// ColumnNumberShort الخاص بـ BatchNumberContent
    /// </summary>
    public decimal? ColumnNumberShort { get; private set; }

    /// <summary>
    /// BatchDescriptionNumber of the BatchNumberContent
    /// BatchDescriptionNumber الخاص بـ BatchNumberContent
    /// </summary>
    public string BatchDescriptionNumber { get; private set; }

    /// <summary>
    /// BatchDescriptionNameArabic of the BatchNumberContent
    /// BatchDescriptionNameArabic الخاص بـ BatchNumberContent
    /// </summary>
    public string BatchDescriptionNameArabic { get; private set; }

    /// <summary>
    /// BatchDescriptionNameEnglish of the BatchNumberContent
    /// BatchDescriptionNameEnglish الخاص بـ BatchNumberContent
    /// </summary>
    public string BatchDescriptionNameEnglish { get; private set; }

    /// <summary>
    /// ColorCode of the BatchNumberContent
    /// ColorCode الخاص بـ BatchNumberContent
    /// </summary>
    public string ColorCode { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
