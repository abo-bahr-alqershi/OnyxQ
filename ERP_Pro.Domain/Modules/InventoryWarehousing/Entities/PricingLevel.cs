using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.FinanceAccounting.Entities;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;
using ERP_Pro.Domain.ERP.SalesCustomers.Entities;

namespace ERP_Pro.Domain.ERP.InventoryWarehousing.Entities
{
/// <summary>
/// PricingLevel Entity
/// </summary>
public class PricingLevel : Entity<PricingLevelId>
{

    private PricingLevel() { }

    public PricingLevel(PricingLevelId id, decimal? levelNumber)
    {
        Id = id;
        LevelNumber = levelNumber;
    }

    /// <summary>
    /// The unique identifier for the PricingLevel
    /// المعرف الفريد لـ PricingLevel
    /// </summary>
    public PricingLevelId Id { get; private set; }

    /// <summary>
    /// LevelNumber of the PricingLevel
    /// LevelNumber الخاص بـ PricingLevel
    /// </summary>
    public decimal? LevelNumber { get; private set; }

    /// <summary>
    /// LevelNameArabic of the PricingLevel
    /// LevelNameArabic الخاص بـ PricingLevel
    /// </summary>
    public string LevelNameArabic { get; private set; }

    /// <summary>
    /// LevelNameEnglish of the PricingLevel
    /// LevelNameEnglish الخاص بـ PricingLevel
    /// </summary>
    public string LevelNameEnglish { get; private set; }

    /// <summary>
    /// LevelLow of the PricingLevel
    /// LevelLow الخاص بـ PricingLevel
    /// </summary>
    public decimal? LevelLow { get; private set; }

    /// <summary>
    /// LevelHigh of the PricingLevel
    /// LevelHigh الخاص بـ PricingLevel
    /// </summary>
    public decimal? LevelHigh { get; private set; }

    /// <summary>
    /// LevelDefault of the PricingLevel
    /// LevelDefault الخاص بـ PricingLevel
    /// </summary>
    public decimal? LevelDefault { get; private set; }

    /// <summary>
    /// BillDocumentTypeFull of the PricingLevel
    /// BillDocumentTypeFull الخاص بـ PricingLevel
    /// </summary>
    public decimal? BillDocumentTypeFull { get; private set; }

    /// <summary>
    /// PercentPriceFromCost of the PricingLevel
    /// PercentPriceFromCost الخاص بـ PricingLevel
    /// </summary>
    public decimal? PercentPriceFromCost { get; private set; }

    /// <summary>
    /// DecNo of the PricingLevel
    /// DecNo الخاص بـ PricingLevel
    /// </summary>
    public decimal? DecNo { get; private set; }

    /// <summary>
    /// CstType of the PricingLevel
    /// CstType الخاص بـ PricingLevel
    /// </summary>
    public decimal? CstType { get; private set; }

    /// <summary>
    /// CustomerPercentShort of the PricingLevel
    /// CustomerPercentShort الخاص بـ PricingLevel
    /// </summary>
    public decimal? CustomerPercentShort { get; private set; }

    /// <summary>
    /// InactiveFlag of the PricingLevel
    /// InactiveFlag الخاص بـ PricingLevel
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the PricingLevel
    /// InactiveReason الخاص بـ PricingLevel
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the PricingLevel
    /// InactiveDate الخاص بـ PricingLevel
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the PricingLevel
    /// InactivatedByUserId الخاص بـ PricingLevel
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ExchangeRate ExchangeRate { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
