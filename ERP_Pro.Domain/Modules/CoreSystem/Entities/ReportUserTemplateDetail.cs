using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ReportUserTemplateDetail Entity
/// </summary>
public class ReportUserTemplateDetail : Entity<ReportUserTemplateDetailId>
{

    private ReportUserTemplateDetail() { }

    public ReportUserTemplateDetail(ReportUserTemplateDetailId id, decimal? sequenceQuantityNumber)
    {
        Id = id;
        SequenceQuantityNumber = sequenceQuantityNumber;
    }

    /// <summary>
    /// The unique identifier for the ReportUserTemplateDetail
    /// المعرف الفريد لـ ReportUserTemplateDetail
    /// </summary>
    public ReportUserTemplateDetailId Id { get; private set; }

    /// <summary>
    /// BlockName of the ReportUserTemplateDetail
    /// BlockName الخاص بـ ReportUserTemplateDetail
    /// </summary>
    public string BlockName { get; private set; }

    /// <summary>
    /// ItemName of the ReportUserTemplateDetail
    /// ItemName الخاص بـ ReportUserTemplateDetail
    /// </summary>
    public string ItemName { get; private set; }

    /// <summary>
    /// Value of the ReportUserTemplateDetail
    /// Value الخاص بـ ReportUserTemplateDetail
    /// </summary>
    public string Value { get; private set; }

    /// <summary>
    /// SequenceQuantityNumber of the ReportUserTemplateDetail
    /// SequenceQuantityNumber الخاص بـ ReportUserTemplateDetail
    /// </summary>
    public decimal? SequenceQuantityNumber { get; private set; }

    /// <summary>
    /// Notes of the ReportUserTemplateDetail
    /// Notes الخاص بـ ReportUserTemplateDetail
    /// </summary>
    public string Notes { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public ReportUserTemplateMaster ReportUserTemplateMaster { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
