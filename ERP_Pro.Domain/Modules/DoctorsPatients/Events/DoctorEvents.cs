using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.DoctorsPatients.ValueObjects;

namespace ERP_Pro.Domain.ERP.DoctorsPatients.Events
{
/// <summary>
/// Events related to Doctor entity
/// </summary>
public sealed class DoctorCreatedEvent : DomainEvent
{
    public DoctorId DoctorId { get; }

    public DoctorCreatedEvent(DoctorId doctorId)
    {
        DoctorId = doctorId;
    }
}

public sealed class DoctorUpdatedEvent : DomainEvent
{
    public DoctorId DoctorId { get; }

    public DoctorUpdatedEvent(DoctorId doctorId)
    {
        DoctorId = doctorId;
    }
}

public sealed class DoctorDeletedEvent : DomainEvent
{
    public DoctorId DoctorId { get; }

    public DoctorDeletedEvent(DoctorId doctorId)
    {
        DoctorId = doctorId;
    }
}
}
