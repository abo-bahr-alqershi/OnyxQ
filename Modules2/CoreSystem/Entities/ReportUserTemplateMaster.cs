using System;
using System.Collections.Generic;

using ERP_Pro.Domain.Common.Entities;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.CoreSystem.ValueObjects;

namespace ERP_Pro.Domain.ERP.CoreSystem.Entities
{
/// <summary>
/// ReportUserTemplateMaster Entity
/// </summary>
public class ReportUserTemplateMaster : Entity<ReportUserTemplateMasterId>
{

    private ReportUserTemplateMaster() { }

    public ReportUserTemplateMaster(ReportUserTemplateMasterId id, decimal? formNumber, decimal? userId, decimal? templateNumber)
    {
        Id = id;
        FormNumber = formNumber;
        UserId = userId;
        TemplateNumber = templateNumber;
    }

    /// <summary>
    /// The unique identifier for the ReportUserTemplateMaster
    /// المعرف الفريد لـ ReportUserTemplateMaster
    /// </summary>
    public ReportUserTemplateMasterId Id { get; private set; }

    /// <summary>
    /// FormNumber of the ReportUserTemplateMaster
    /// FormNumber الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? FormNumber { get; private set; }

    /// <summary>
    /// UserId of the ReportUserTemplateMaster
    /// UserId الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? UserId { get; private set; }

    /// <summary>
    /// TemplateNumber of the ReportUserTemplateMaster
    /// TemplateNumber الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? TemplateNumber { get; private set; }

    /// <summary>
    /// OrderNumberShort of the ReportUserTemplateMaster
    /// OrderNumberShort الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// Notes of the ReportUserTemplateMaster
    /// Notes الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public string Notes { get; private set; }

    /// <summary>
    /// InactiveFlag of the ReportUserTemplateMaster
    /// InactiveFlag الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveReason of the ReportUserTemplateMaster
    /// InactiveReason الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the ReportUserTemplateMaster
    /// InactivatedByUserId الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// InactiveDate of the ReportUserTemplateMaster
    /// InactiveDate الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// TemplateName of the ReportUserTemplateMaster
    /// TemplateName الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public string TemplateName { get; private set; }

    /// <summary>
    /// DfltFlg of the ReportUserTemplateMaster
    /// DfltFlg الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? DfltFlg { get; private set; }

    /// <summary>
    /// GenerateForAllUsersFlag of the ReportUserTemplateMaster
    /// GenerateForAllUsersFlag الخاص بـ ReportUserTemplateMaster
    /// </summary>
    public decimal? GenerateForAllUsersFlag { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}
