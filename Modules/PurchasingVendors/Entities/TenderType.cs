using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// TenderType Entity
/// </summary>
public class TenderType : Entity<TenderTypeId>
{
    private TenderType() { }

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

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: TenderType to TenderMaster
    /// </summary>
    public IReadOnlyCollection<TenderMaster> TenderMasters { get; private set; }
    #endregion
}
}
