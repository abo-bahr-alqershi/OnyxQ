using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// TenderType Entity
/// </summary>
public class TenderType : Entity<TenderTypeId>
{

    private TenderType() { }

    public TenderType(TenderTypeId id, decimal? tdType)
    {
        Id = id;
        TdType = tdType;
    }

    /// <summary>
    /// The unique identifier for the TenderType
    /// المعرف الفريد لـ TenderType
    /// </summary>
    public TenderTypeId Id { get; private set; }

    /// <summary>
    /// TdType of the TenderType
    /// TdType الخاص بـ TenderType
    /// </summary>
    public decimal? TdType { get; private set; }

    /// <summary>
    /// TdNameArabic of the TenderType
    /// TdNameArabic الخاص بـ TenderType
    /// </summary>
    public string TdNameArabic { get; private set; }

    /// <summary>
    /// TdNameEnglish of the TenderType
    /// TdNameEnglish الخاص بـ TenderType
    /// </summary>
    public string TdNameEnglish { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

