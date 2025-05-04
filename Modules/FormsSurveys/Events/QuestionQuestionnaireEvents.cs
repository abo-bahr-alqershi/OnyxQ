using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to QuestionQuestionnaire entity
/// </summary>
public sealed class QuestionQuestionnaireCreatedEvent : DomainEvent
{
    public QuestionQuestionnaireId QuestionQuestionnaireId { get; }

    public QuestionQuestionnaireCreatedEvent(QuestionQuestionnaireId questionquestionnaireId)
    {
        QuestionQuestionnaireId = questionquestionnaireId;
    }
}

public sealed class QuestionQuestionnaireUpdatedEvent : DomainEvent
{
    public QuestionQuestionnaireId QuestionQuestionnaireId { get; }

    public QuestionQuestionnaireUpdatedEvent(QuestionQuestionnaireId questionquestionnaireId)
    {
        QuestionQuestionnaireId = questionquestionnaireId;
    }
}

public sealed class QuestionQuestionnaireDeletedEvent : DomainEvent
{
    public QuestionQuestionnaireId QuestionQuestionnaireId { get; }

    public QuestionQuestionnaireDeletedEvent(QuestionQuestionnaireId questionquestionnaireId)
    {
        QuestionQuestionnaireId = questionquestionnaireId;
    }
}
}
