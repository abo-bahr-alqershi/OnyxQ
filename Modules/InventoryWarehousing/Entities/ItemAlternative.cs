using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// ItemAlternative Entity
/// </summary>
public class ItemAlternative : Entity<ItemAlternativeId>
{
    private ItemAlternative() { }

    /// <summary>
    /// The unique identifier for the ItemAlternative
    /// المعرف الفريد لـ ItemAlternative
    /// </summary>
    public ItemAlternativeId Id { get; private set; }

    /// <summary>
    /// ItemCode of the ItemAlternative
    /// ItemCode الخاص بـ ItemAlternative
    /// </summary>
    public string ItemCode { get; private set; }

    /// <summary>
    /// ItemUnit of the ItemAlternative
    /// ItemUnit الخاص بـ ItemAlternative
    /// </summary>
    public string ItemUnit { get; private set; }

    /// <summary>
    /// ItemCodeAlternative of the ItemAlternative
    /// ItemCodeAlternative الخاص بـ ItemAlternative
    /// </summary>
    public string ItemCodeAlternative { get; private set; }

    /// <summary>
    /// ItemUnitAlternative of the ItemAlternative
    /// ItemUnitAlternative الخاص بـ ItemAlternative
    /// </summary>
    public string ItemUnitAlternative { get; private set; }

    /// <summary>
    /// EquationValue of the ItemAlternative
    /// EquationValue الخاص بـ ItemAlternative
    /// </summary>
    public decimal? EquationValue { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ItemAlternative
    /// OrderNumberShort الخاص بـ ItemAlternative
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }
}
}
