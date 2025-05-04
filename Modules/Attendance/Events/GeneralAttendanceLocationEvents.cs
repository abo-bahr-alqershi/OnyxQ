using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.Attendance.Events
{
/// <summary>
/// Events related to GeneralAttendanceLocation entity
/// </summary>
public sealed class GeneralAttendanceLocationCreatedEvent : DomainEvent
{
    public GeneralAttendanceLocationId GeneralAttendanceLocationId { get; }

    public GeneralAttendanceLocationCreatedEvent(GeneralAttendanceLocationId generalattendancelocationId)
    {
        GeneralAttendanceLocationId = generalattendancelocationId;
    }
}

public sealed class GeneralAttendanceLocationUpdatedEvent : DomainEvent
{
    public GeneralAttendanceLocationId GeneralAttendanceLocationId { get; }

    public GeneralAttendanceLocationUpdatedEvent(GeneralAttendanceLocationId generalattendancelocationId)
    {
        GeneralAttendanceLocationId = generalattendancelocationId;
    }
}

public sealed class GeneralAttendanceLocationDeletedEvent : DomainEvent
{
    public GeneralAttendanceLocationId GeneralAttendanceLocationId { get; }

    public GeneralAttendanceLocationDeletedEvent(GeneralAttendanceLocationId generalattendancelocationId)
    {
        GeneralAttendanceLocationId = generalattendancelocationId;
    }
}
}
