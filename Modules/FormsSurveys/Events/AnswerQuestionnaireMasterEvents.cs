using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to AnswerQuestionnaireMaster entity
/// </summary>
public sealed class AnswerQuestionnaireMasterCreatedEvent : DomainEvent
{
    public AnswerQuestionnaireMasterId AnswerQuestionnaireMasterId { get; }

    public AnswerQuestionnaireMasterCreatedEvent(AnswerQuestionnaireMasterId answerquestionnairemasterId)
    {
        AnswerQuestionnaireMasterId = answerquestionnairemasterId;
    }
}

public sealed class AnswerQuestionnaireMasterUpdatedEvent : DomainEvent
{
    public AnswerQuestionnaireMasterId AnswerQuestionnaireMasterId { get; }

    public AnswerQuestionnaireMasterUpdatedEvent(AnswerQuestionnaireMasterId answerquestionnairemasterId)
    {
        AnswerQuestionnaireMasterId = answerquestionnairemasterId;
    }
}

public sealed class AnswerQuestionnaireMasterDeletedEvent : DomainEvent
{
    public AnswerQuestionnaireMasterId AnswerQuestionnaireMasterId { get; }

    public AnswerQuestionnaireMasterDeletedEvent(AnswerQuestionnaireMasterId answerquestionnairemasterId)
    {
        AnswerQuestionnaireMasterId = answerquestionnairemasterId;
    }
}
}
