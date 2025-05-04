using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Entities
{
/// <summary>
/// DateOption Entity
/// </summary>
public class DateOption : Entity<DateOptionId>
{

    private DateOption() { }

    public DateOption(DateOptionId id, decimal? optionNumber)
    {
        Id = id;
        OptionNumber = optionNumber;
    }

    /// <summary>
    /// The unique identifier for the DateOption
    /// المعرف الفريد لـ DateOption
    /// </summary>
    public DateOptionId Id { get; private set; }

    /// <summary>
    /// OptionNumber of the DateOption
    /// OptionNumber الخاص بـ DateOption
    /// </summary>
    public decimal? OptionNumber { get; private set; }

    /// <summary>
    /// OptionName of the DateOption
    /// OptionName الخاص بـ DateOption
    /// </summary>
    public string OptionName { get; private set; }

    /// <summary>
    /// LabelNumberShort of the DateOption
    /// LabelNumberShort الخاص بـ DateOption
    /// </summary>
    public decimal? LabelNumberShort { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
