using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.TemporaryTables.ValueObjects;

namespace ERP_Pro.Domain.ERP.TemporaryTables.Events
{
/// <summary>
/// Events related to CollectorImportExcelTemplate entity
/// </summary>
public sealed class CollectorImportExcelTemplateCreatedEvent : DomainEvent
{
    public CollectorImportExcelTemplateId CollectorImportExcelTemplateId { get; }

    public CollectorImportExcelTemplateCreatedEvent(CollectorImportExcelTemplateId collectorimportexceltemplateId)
    {
        CollectorImportExcelTemplateId = collectorimportexceltemplateId;
    }
}

public sealed class CollectorImportExcelTemplateUpdatedEvent : DomainEvent
{
    public CollectorImportExcelTemplateId CollectorImportExcelTemplateId { get; }

    public CollectorImportExcelTemplateUpdatedEvent(CollectorImportExcelTemplateId collectorimportexceltemplateId)
    {
        CollectorImportExcelTemplateId = collectorimportexceltemplateId;
    }
}

public sealed class CollectorImportExcelTemplateDeletedEvent : DomainEvent
{
    public CollectorImportExcelTemplateId CollectorImportExcelTemplateId { get; }

    public CollectorImportExcelTemplateDeletedEvent(CollectorImportExcelTemplateId collectorimportexceltemplateId)
    {
        CollectorImportExcelTemplateId = collectorimportexceltemplateId;
    }
}
}
