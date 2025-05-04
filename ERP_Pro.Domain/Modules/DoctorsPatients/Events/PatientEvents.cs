using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.DoctorsPatients.ValueObjects;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.Events
{
/// <summary>
/// Events related to Patient entity
/// </summary>
public sealed class PatientCreatedEvent : DomainEvent
{
    public PatientId PatientId { get; }

    public PatientCreatedEvent(PatientId patientId)
    {
        PatientId = patientId;
    }
}

public sealed class PatientUpdatedEvent : DomainEvent
{
    public PatientId PatientId { get; }

    public PatientUpdatedEvent(PatientId patientId)
    {
        PatientId = patientId;
    }
}

public sealed class PatientDeletedEvent : DomainEvent
{
    public PatientId PatientId { get; }

    public PatientDeletedEvent(PatientId patientId)
    {
        PatientId = patientId;
    }
}
}
