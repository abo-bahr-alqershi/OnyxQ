using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FormsSurveys.ValueObjects;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to QuestionnaireMaster entity
/// </summary>
public sealed class QuestionnaireMasterCreatedEvent : DomainEvent
{
    public QuestionnaireMasterId QuestionnaireMasterId { get; }

    public QuestionnaireMasterCreatedEvent(QuestionnaireMasterId questionnairemasterId)
    {
        QuestionnaireMasterId = questionnairemasterId;
    }
}

public sealed class QuestionnaireMasterUpdatedEvent : DomainEvent
{
    public QuestionnaireMasterId QuestionnaireMasterId { get; }

    public QuestionnaireMasterUpdatedEvent(QuestionnaireMasterId questionnairemasterId)
    {
        QuestionnaireMasterId = questionnairemasterId;
    }
}

public sealed class QuestionnaireMasterDeletedEvent : DomainEvent
{
    public QuestionnaireMasterId QuestionnaireMasterId { get; }

    public QuestionnaireMasterDeletedEvent(QuestionnaireMasterId questionnairemasterId)
    {
        QuestionnaireMasterId = questionnairemasterId;
    }
}
}
