using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to AnswerQuestionnaireDetail entity
/// </summary>
public sealed class AnswerQuestionnaireDetailCreatedEvent : DomainEvent
{
    public AnswerQuestionnaireDetailId AnswerQuestionnaireDetailId { get; }

    public AnswerQuestionnaireDetailCreatedEvent(AnswerQuestionnaireDetailId answerquestionnairedetailId)
    {
        AnswerQuestionnaireDetailId = answerquestionnairedetailId;
    }
}

public sealed class AnswerQuestionnaireDetailUpdatedEvent : DomainEvent
{
    public AnswerQuestionnaireDetailId AnswerQuestionnaireDetailId { get; }

    public AnswerQuestionnaireDetailUpdatedEvent(AnswerQuestionnaireDetailId answerquestionnairedetailId)
    {
        AnswerQuestionnaireDetailId = answerquestionnairedetailId;
    }
}

public sealed class AnswerQuestionnaireDetailDeletedEvent : DomainEvent
{
    public AnswerQuestionnaireDetailId AnswerQuestionnaireDetailId { get; }

    public AnswerQuestionnaireDetailDeletedEvent(AnswerQuestionnaireDetailId answerquestionnairedetailId)
    {
        AnswerQuestionnaireDetailId = answerquestionnairedetailId;
    }
}
}
