using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.PurchasingVendors.ValueObjects;
namespace ERP_Pro.Domain.ERP.PurchasingVendors.Entities
{
/// <summary>
/// QuotationType Entity
/// </summary>
public class QuotationType : Entity<QuotationTypeId>
{

    private QuotationType() { }

    public QuotationType(QuotationTypeId id, decimal? quotationType)
    {
        Id = id;
        QuotationType = quotationType;
    }

    /// <summary>
    /// The unique identifier for the QuotationType
    /// المعرف الفريد لـ QuotationType
    /// </summary>
    public QuotationTypeId Id { get; private set; }

    /// <summary>
    /// QuotationType of the QuotationType
    /// QuotationType الخاص بـ QuotationType
    /// </summary>
    public decimal? QuotationType { get; private set; }

    /// <summary>
    /// QuotationNameArabic of the QuotationType
    /// QuotationNameArabic الخاص بـ QuotationType
    /// </summary>
    public string QuotationNameArabic { get; private set; }

    /// <summary>
    /// QuotationNameEnglish of the QuotationType
    /// QuotationNameEnglish الخاص بـ QuotationType
    /// </summary>
    public string QuotationNameEnglish { get; private set; }

    /// <summary>
    /// QuotationSerial of the QuotationType
    /// QuotationSerial الخاص بـ QuotationType
    /// </summary>
    public decimal? QuotationSerial { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

