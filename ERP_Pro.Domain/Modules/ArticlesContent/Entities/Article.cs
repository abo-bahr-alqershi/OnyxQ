using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;
using ERP_Pro.Domain.ERP.UsersPermissions.Entities;

using ERP_Pro.Domain.ERP.ArticlesContent.ValueObjects;
namespace ERP_Pro.Domain.ERP.ArticlesContent.Entities
{
/// <summary>
/// Article Entity
/// </summary>
public class Article : AggregateRoot<ArticleId>
{

    private Article() { }

    public Article(ArticleId id, decimal? articleNumber)
    {
        Id = id;
        ArticleNumber = articleNumber;
    }

    /// <summary>
    /// The unique identifier for the Article
    /// المعرف الفريد لـ Article
    /// </summary>
    public ArticleId Id { get; private set; }

    /// <summary>
    /// ArticleNumber of the Article
    /// ArticleNumber الخاص بـ Article
    /// </summary>
    public decimal? ArticleNumber { get; private set; }

    /// <summary>
    /// ArticleLastName of the Article
    /// ArticleLastName الخاص بـ Article
    /// </summary>
    public string ArticleLastName { get; private set; }

    /// <summary>
    /// ArticleFirstName of the Article
    /// ArticleFirstName الخاص بـ Article
    /// </summary>
    public string ArticleFirstName { get; private set; }

    /// <summary>
    /// ArticleType of the Article
    /// ArticleType الخاص بـ Article
    /// </summary>
    public decimal? ArticleType { get; private set; }

    /// <summary>
    /// ArticleFrequency of the Article
    /// ArticleFrequency الخاص بـ Article
    /// </summary>
    public decimal? ArticleFrequency { get; private set; }

    /// <summary>
    /// ArticleValueType of the Article
    /// ArticleValueType الخاص بـ Article
    /// </summary>
    public decimal? ArticleValueType { get; private set; }

    /// <summary>
    /// ArticleValue of the Article
    /// ArticleValue الخاص بـ Article
    /// </summary>
    public decimal? ArticleValue { get; private set; }

    /// <summary>
    /// ArticleMaxValue of the Article
    /// ArticleMaxValue الخاص بـ Article
    /// </summary>
    public decimal? ArticleMaxValue { get; private set; }

    /// <summary>
    /// ArticlePayOutSalary of the Article
    /// ArticlePayOutSalary الخاص بـ Article
    /// </summary>
    public decimal? ArticlePayOutSalary { get; private set; }

    /// <summary>
    /// NetRelatedFlag of the Article
    /// NetRelatedFlag الخاص بـ Article
    /// </summary>
    public decimal? NetRelatedFlag { get; private set; }

    /// <summary>
    /// ArticleReservedNumber of the Article
    /// ArticleReservedNumber الخاص بـ Article
    /// </summary>
    public decimal? ArticleReservedNumber { get; private set; }

    /// <summary>
    /// WorkStartDateEffect of the Article
    /// WorkStartDateEffect الخاص بـ Article
    /// </summary>
    public decimal? WorkStartDateEffect { get; private set; }

    /// <summary>
    /// UseInEmployeeEvaluation of the Article
    /// UseInEmployeeEvaluation الخاص بـ Article
    /// </summary>
    public decimal? UseInEmployeeEvaluation { get; private set; }

    /// <summary>
    /// ArticleStopFlag of the Article
    /// ArticleStopFlag الخاص بـ Article
    /// </summary>
    public decimal? ArticleStopFlag { get; private set; }

    /// <summary>
    /// AbsenceEffect of the Article
    /// AbsenceEffect الخاص بـ Article
    /// </summary>
    public decimal? AbsenceEffect { get; private set; }

    /// <summary>
    /// ArticleOrder of the Article
    /// ArticleOrder الخاص بـ Article
    /// </summary>
    public decimal? ArticleOrder { get; private set; }

    /// <summary>
    /// DayHourDpndnt of the Article
    /// DayHourDpndnt الخاص بـ Article
    /// </summary>
    public decimal? DayHourDpndnt { get; private set; }

    /// <summary>
    /// LawFlag of the Article
    /// LawFlag الخاص بـ Article
    /// </summary>
    public decimal? LawFlag { get; private set; }

    /// <summary>
    /// ArticleEntryMethod of the Article
    /// ArticleEntryMethod الخاص بـ Article
    /// </summary>
    public decimal? ArticleEntryMethod { get; private set; }

    /// <summary>
    /// ConnectionAccountMethod of the Article
    /// ConnectionAccountMethod الخاص بـ Article
    /// </summary>
    public decimal? ConnectionAccountMethod { get; private set; }

    /// <summary>
    /// FingerFlag of the Article
    /// FingerFlag الخاص بـ Article
    /// </summary>
    public decimal? FingerFlag { get; private set; }

    /// <summary>
    /// FingerTypeFlag of the Article
    /// FingerTypeFlag الخاص بـ Article
    /// </summary>
    public decimal? FingerTypeFlag { get; private set; }

    /// <summary>
    /// ArticleFormula of the Article
    /// ArticleFormula الخاص بـ Article
    /// </summary>
    public string ArticleFormula { get; private set; }

    /// <summary>
    /// InactiveFlag of the Article
    /// InactiveFlag الخاص بـ Article
    /// </summary>
    public decimal? InactiveFlag { get; private set; }

    /// <summary>
    /// InactiveDate of the Article
    /// InactiveDate الخاص بـ Article
    /// </summary>
    public DateTime? InactiveDate { get; private set; }

    /// <summary>
    /// InactiveReason of the Article
    /// InactiveReason الخاص بـ Article
    /// </summary>
    public string InactiveReason { get; private set; }

    /// <summary>
    /// InactivatedByUserId of the Article
    /// InactivatedByUserId الخاص بـ Article
    /// </summary>
    public decimal? InactivatedByUserId { get; private set; }

    /// <summary>
    /// AccountCode of the Article
    /// AccountCode الخاص بـ Article
    /// </summary>
    public string AccountCode { get; private set; }

    /// <summary>
    /// AccountDetailType of the Article
    /// AccountDetailType الخاص بـ Article
    /// </summary>
    public decimal? AccountDetailType { get; private set; }

    /// <summary>
    /// DistrbtTyp of the Article
    /// DistrbtTyp الخاص بـ Article
    /// </summary>
    public decimal? DistrbtTyp { get; private set; }

    /// <summary>
    /// CurCode of the Article
    /// CurCode الخاص بـ Article
    /// </summary>
    public string CurCode { get; private set; }

    /// <summary>
    /// ArticleClass of the Article
    /// ArticleClass الخاص بـ Article
    /// </summary>
    public decimal? ArticleClass { get; private set; }

    /// <summary>
    /// ApplyArticleOnHolidayDays of the Article
    /// ApplyArticleOnHolidayDays الخاص بـ Article
    /// </summary>
    public decimal? ApplyArticleOnHolidayDays { get; private set; }

    /// <summary>
    /// ApplyArticleOnNonEmployeeDays of the Article
    /// ApplyArticleOnNonEmployeeDays الخاص بـ Article
    /// </summary>
    public decimal? ApplyArticleOnNonEmployeeDays { get; private set; }

    /// <summary>
    /// CostCenterCode of the Article
    /// CostCenterCode الخاص بـ Article
    /// </summary>
    public string CostCenterCode { get; private set; }

    /// <summary>
    /// ProjectNumber of the Article
    /// ProjectNumber الخاص بـ Article
    /// </summary>
    public string ProjectNumber { get; private set; }

    /// <summary>
    /// ActivityNumber of the Article
    /// ActivityNumber الخاص بـ Article
    /// </summary>
    public string ActivityNumber { get; private set; }

    /// <summary>
    /// ArticlePercentCalculation of the Article
    /// ArticlePercentCalculation الخاص بـ Article
    /// </summary>
    public decimal? ArticlePercentCalculation { get; private set; }

    /// <summary>
    /// DvdDayHours of the Article
    /// DvdDayHours الخاص بـ Article
    /// </summary>
    public decimal? DvdDayHours { get; private set; }

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

