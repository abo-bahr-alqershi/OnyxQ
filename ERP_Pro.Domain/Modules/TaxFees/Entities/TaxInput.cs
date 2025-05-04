using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.TaxFees.Entities
{
/// <summary>
/// TaxInput Entity
/// </summary>
public class TaxInput : Entity<TaxInputId>
{

    private TaxInput() { }

    public TaxInput(TaxInputId id, decimal? inputType, string inputCode)
    {
        Id = id;
        InputType = inputType;
        InputCode = inputCode;
    }

    /// <summary>
    /// The unique identifier for the TaxInput
    /// المعرف الفريد لـ TaxInput
    /// </summary>
    public TaxInputId Id { get; private set; }

    /// <summary>
    /// InputType of the TaxInput
    /// InputType الخاص بـ TaxInput
    /// </summary>
    public decimal? InputType { get; private set; }

    /// <summary>
    /// InputCode of the TaxInput
    /// InputCode الخاص بـ TaxInput
    /// </summary>
    public string InputCode { get; private set; }

    /// <summary>
    /// TaxPercent of the TaxInput
    /// TaxPercent الخاص بـ TaxInput
    /// </summary>
    public decimal? TaxPercent { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public TaxCodeDetail TaxCodeDetail { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
