using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Entities
{
/// <summary>
/// AnswerQuestionnaireDetail Entity
/// </summary>
public class AnswerQuestionnaireDetail : Entity<AnswerQuestionnaireDetailId>
{
    private AnswerQuestionnaireDetail() { }

    /// <summary>
    /// The unique identifier for the AnswerQuestionnaireDetail
    /// المعرف الفريد لـ AnswerQuestionnaireDetail
    /// </summary>
    public AnswerQuestionnaireDetailId Id { get; private set; }

    /// <summary>
    /// RecordNumber of the AnswerQuestionnaireDetail
    /// RecordNumber الخاص بـ AnswerQuestionnaireDetail
    /// </summary>
    public decimal? RecordNumber { get; private set; }

    /// <summary>
    /// ModelNumber of the AnswerQuestionnaireDetail
    /// ModelNumber الخاص بـ AnswerQuestionnaireDetail
    /// </summary>
    public decimal? ModelNumber { get; private set; }

    /// <summary>
    /// AnswerNumber of the AnswerQuestionnaireDetail
    /// AnswerNumber الخاص بـ AnswerQuestionnaireDetail
    /// </summary>
    public decimal? AnswerNumber { get; private set; }

    /// <summary>
    /// AnswerLastName of the AnswerQuestionnaireDetail
    /// AnswerLastName الخاص بـ AnswerQuestionnaireDetail
    /// </summary>
    public string AnswerLastName { get; private set; }

    /// <summary>
    /// AnswerFirstName of the AnswerQuestionnaireDetail
    /// AnswerFirstName الخاص بـ AnswerQuestionnaireDetail
    /// </summary>
    public string AnswerFirstName { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// ManyToOne relationship to AnswerQuestionnaireMaster
    /// </summary>
    public AnswerQuestionnaireMaster AnswerQuestionnaireMaster { get; private set; }
    /// <summary>
    /// One-to-many relationship: AnswerQuestionnaireDetail to QuestionnaireSubDetail
    /// </summary>
    public IReadOnlyCollection<QuestionnaireSubDetail> QuestionnaireSubDetails { get; private set; }
    #endregion
}
}
