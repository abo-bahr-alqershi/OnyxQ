using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// QuestionQuestionnaire Entity
/// </summary>
public class QuestionQuestionnaire : Entity<QuestionQuestionnaireId>
{
    private QuestionQuestionnaire() { }

    /// <summary>
    /// The unique identifier for the QuestionQuestionnaire
    /// المعرف الفريد لـ QuestionQuestionnaire
    /// </summary>
    public QuestionQuestionnaireId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the QuestionQuestionnaire
    /// RecordNumber الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// QuestionnaireNumber of the QuestionQuestionnaire
    /// QuestionnaireNumber الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? QuestionnaireNumber { get; private set; }

    /// <summary>
    /// QuestionNumber of the QuestionQuestionnaire
    /// QuestionNumber الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? QuestionNumber { get; private set; }

    /// <summary>
    /// QuestionLastName of the QuestionQuestionnaire
    /// QuestionLastName الخاص بـ QuestionQuestionnaire
    /// </summary>
    public string QuestionLastName { get; private set; }

    /// <summary>
    /// QuestionFirstName of the QuestionQuestionnaire
    /// QuestionFirstName الخاص بـ QuestionQuestionnaire
    /// </summary>
    public string QuestionFirstName { get; private set; }

    /// <summary>
    /// OrderNumberShort of the QuestionQuestionnaire
    /// OrderNumberShort الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? OrderNumberShort { get; private set; }

    /// <summary>
    /// ModelNumber of the QuestionQuestionnaire
    /// ModelNumber الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? ModelNumber { get; private set; }

    /// <summary>
    /// InactiveFlagAlt of the QuestionQuestionnaire
    /// InactiveFlagAlt الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? InactiveFlagAlt { get; private set; }

    /// <summary>
    /// InactiveReasonAlt of the QuestionQuestionnaire
    /// InactiveReasonAlt الخاص بـ QuestionQuestionnaire
    /// </summary>
    public string InactiveReasonAlt { get; private set; }

    /// <summary>
    /// InactiveDateAlt of the QuestionQuestionnaire
    /// InactiveDateAlt الخاص بـ QuestionQuestionnaire
    /// </summary>
    public DateTime? InactiveDateAlt { get; private set; }

    /// <summary>
    /// InactiveUserId of the QuestionQuestionnaire
    /// InactiveUserId الخاص بـ QuestionQuestionnaire
    /// </summary>
    public decimal? InactiveUserId { get; private set; }
}
}
