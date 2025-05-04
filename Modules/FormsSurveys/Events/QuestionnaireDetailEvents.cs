using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.FormsSurveys.Events
{
/// <summary>
/// Events related to QuestionnaireDetail entity
/// </summary>
public sealed class QuestionnaireDetailCreatedEvent : DomainEvent
{
    public QuestionnaireDetailId QuestionnaireDetailId { get; }

    public QuestionnaireDetailCreatedEvent(QuestionnaireDetailId questionnairedetailId)
    {
        QuestionnaireDetailId = questionnairedetailId;
    }
}

public sealed class QuestionnaireDetailUpdatedEvent : DomainEvent
{
    public QuestionnaireDetailId QuestionnaireDetailId { get; }

    public QuestionnaireDetailUpdatedEvent(QuestionnaireDetailId questionnairedetailId)
    {
        QuestionnaireDetailId = questionnairedetailId;
    }
}

public sealed class QuestionnaireDetailDeletedEvent : DomainEvent
{
    public QuestionnaireDetailId QuestionnaireDetailId { get; }

    public QuestionnaireDetailDeletedEvent(QuestionnaireDetailId questionnairedetailId)
    {
        QuestionnaireDetailId = questionnairedetailId;
    }
}
}
