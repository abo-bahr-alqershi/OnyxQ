using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.GuaranteesWarranties.Entities
{
/// <summary>
/// GuaranteeType Entity
/// </summary>
public class GuaranteeType : Entity<GuaranteeTypeId>
{
    private GuaranteeType() { }

    /// <summary>
    /// The unique identifier for the GuaranteeType
    /// المعرف الفريد لـ GuaranteeType
    /// </summary>
    public GuaranteeTypeId Id { get; private set; }

    /// <summary>
    /// GroupTypeNumber of the GuaranteeType
    /// GroupTypeNumber الخاص بـ GuaranteeType
    /// </summary>
    public decimal? GroupTypeNumber { get; private set; }

    /// <summary>
    /// GroupTypeNameArabic of the GuaranteeType
    /// GroupTypeNameArabic الخاص بـ GuaranteeType
    /// </summary>
    public string GroupTypeNameArabic { get; private set; }

    /// <summary>
    /// GroupTypeNameEnglish of the GuaranteeType
    /// GroupTypeNameEnglish الخاص بـ GuaranteeType
    /// </summary>
    public string GroupTypeNameEnglish { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// One-to-many relationship: GuaranteeType to GuaranteeIssue
    /// </summary>
    public IReadOnlyCollection<GuaranteeIssue> GuaranteeIssues { get; private set; }
    #endregion
}
}
