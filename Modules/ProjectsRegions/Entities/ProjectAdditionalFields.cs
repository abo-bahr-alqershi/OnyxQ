using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.ProjectsRegions.Entities
{
/// <summary>
/// ProjectAdditionalFields Entity
/// </summary>
public class ProjectAdditionalFields : Entity<ProjectAdditionalFieldsId>
{
    private ProjectAdditionalFields() { }

    /// <summary>
    /// The unique identifier for the ProjectAdditionalFields
    /// المعرف الفريد لـ ProjectAdditionalFields
    /// </summary>
    public ProjectAdditionalFieldsId Id { get; private set; }

    /// <summary>
    /// GroupNumber of the ProjectAdditionalFields
    /// GroupNumber الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? GroupNumber { get; private set; }

    /// <summary>
    /// FiledNumber of the ProjectAdditionalFields
    /// FiledNumber الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? FiledNumber { get; private set; }

    /// <summary>
    /// FiledType of the ProjectAdditionalFields
    /// FiledType الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? FiledType { get; private set; }

    /// <summary>
    /// LanguageNumber of the ProjectAdditionalFields
    /// LanguageNumber الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? LanguageNumber { get; private set; }

    /// <summary>
    /// CaptionDetail of the ProjectAdditionalFields
    /// CaptionDetail الخاص بـ ProjectAdditionalFields
    /// </summary>
    public string CaptionDetail { get; private set; }

    /// <summary>
    /// TransactionFlag of the ProjectAdditionalFields
    /// TransactionFlag الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? TransactionFlag { get; private set; }

    /// <summary>
    /// InactiveFlag of the ProjectAdditionalFields
    /// InactiveFlag الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the ProjectAdditionalFields
    /// InactiveReason الخاص بـ ProjectAdditionalFields
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactiveDate of the ProjectAdditionalFields
    /// InactiveDate الخاص بـ ProjectAdditionalFields
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ProjectAdditionalFields
    /// InactivatedByUserId الخاص بـ ProjectAdditionalFields
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to ProjectGroup
    /// </summary>
    public ProjectGroup ProjectGroup { get; private set; }
    #endregion
}
}
