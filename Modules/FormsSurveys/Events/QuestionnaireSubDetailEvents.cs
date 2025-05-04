using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to QuestionnaireSubDetail entity
/// </summary>
public sealed class QuestionnaireSubDetailCreatedEvent : DomainEvent
{
    public QuestionnaireSubDetailId QuestionnaireSubDetailId { get; }

    public QuestionnaireSubDetailCreatedEvent(QuestionnaireSubDetailId questionnairesubdetailId)
    {
        QuestionnaireSubDetailId = questionnairesubdetailId;
    }
}

public sealed class QuestionnaireSubDetailUpdatedEvent : DomainEvent
{
    public QuestionnaireSubDetailId QuestionnaireSubDetailId { get; }

    public QuestionnaireSubDetailUpdatedEvent(QuestionnaireSubDetailId questionnairesubdetailId)
    {
        QuestionnaireSubDetailId = questionnairesubdetailId;
    }
}

public sealed class QuestionnaireSubDetailDeletedEvent : DomainEvent
{
    public QuestionnaireSubDetailId QuestionnaireSubDetailId { get; }

    public QuestionnaireSubDetailDeletedEvent(QuestionnaireSubDetailId questionnairesubdetailId)
    {
        QuestionnaireSubDetailId = questionnairesubdetailId;
    }
}
}
