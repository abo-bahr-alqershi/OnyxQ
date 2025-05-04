using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// DefaultPriceLevel Entity
/// </summary>
public class DefaultPriceLevel : Entity<DefaultPriceLevelId>
{

    private DefaultPriceLevel() { }

    public DefaultPriceLevel(DefaultPriceLevelId id, decimal? levelNumber, decimal? fieldCode)
    {
        Id = id;
        LevelNumber = levelNumber;
        FieldCode = fieldCode;
    }

    /// <summary>
    /// The unique identifier for the DefaultPriceLevel
    /// المعرف الفريد لـ DefaultPriceLevel
    /// </summary>
    public DefaultPriceLevelId Id { get; private set; }

    /// <summary>
    /// LevelNumber of the DefaultPriceLevel
    /// LevelNumber الخاص بـ DefaultPriceLevel
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// FieldType of the DefaultPriceLevel
    /// FieldType الخاص بـ DefaultPriceLevel
    /// </summary>
    public decimal? FieldType { get; private set; }

    /// <summary>
    /// FieldCode of the DefaultPriceLevel
    /// FieldCode الخاص بـ DefaultPriceLevel
    /// </summary>
    public decimal? FieldCode { get; private set; }

    /// <summary>
    /// LevelDefault of the DefaultPriceLevel
    /// LevelDefault الخاص بـ DefaultPriceLevel
    /// </summary>
    public decimal? LevelDefault { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
