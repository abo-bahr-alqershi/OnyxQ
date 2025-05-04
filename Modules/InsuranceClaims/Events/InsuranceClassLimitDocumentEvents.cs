using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.InsuranceClaims.Events
{
/// <summary>
/// Events related to InsuranceClassLimitDocument entity
/// </summary>
public sealed class InsuranceClassLimitDocumentCreatedEvent : DomainEvent
{
    public InsuranceClassLimitDocumentId InsuranceClassLimitDocumentId { get; }

    public InsuranceClassLimitDocumentCreatedEvent(InsuranceClassLimitDocumentId insuranceclasslimitdocumentId)
    {
        InsuranceClassLimitDocumentId = insuranceclasslimitdocumentId;
    }
}

public sealed class InsuranceClassLimitDocumentUpdatedEvent : DomainEvent
{
    public InsuranceClassLimitDocumentId InsuranceClassLimitDocumentId { get; }

    public InsuranceClassLimitDocumentUpdatedEvent(InsuranceClassLimitDocumentId insuranceclasslimitdocumentId)
    {
        InsuranceClassLimitDocumentId = insuranceclasslimitdocumentId;
    }
}

public sealed class InsuranceClassLimitDocumentDeletedEvent : DomainEvent
{
    public InsuranceClassLimitDocumentId InsuranceClassLimitDocumentId { get; }

    public InsuranceClassLimitDocumentDeletedEvent(InsuranceClassLimitDocumentId insuranceclasslimitdocumentId)
    {
        InsuranceClassLimitDocumentId = insuranceclasslimitdocumentId;
    }
}
}
