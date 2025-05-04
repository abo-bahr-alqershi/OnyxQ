using System;
using ERP_Pro.Domain.Common.Events;

namespace ERP_Pro.Domain.ERP.ArchivingDocuments.Events
{
/// <summary>
/// Events related to LightDocumentBranch entity
/// </summary>
public sealed class LightDocumentBranchCreatedEvent : DomainEvent
{
    public LightDocumentBranchId LightDocumentBranchId { get; }

    public LightDocumentBranchCreatedEvent(LightDocumentBranchId lightdocumentbranchId)
    {
        LightDocumentBranchId = lightdocumentbranchId;
    }
}

public sealed class LightDocumentBranchUpdatedEvent : DomainEvent
{
    public LightDocumentBranchId LightDocumentBranchId { get; }

    public LightDocumentBranchUpdatedEvent(LightDocumentBranchId lightdocumentbranchId)
    {
        LightDocumentBranchId = lightdocumentbranchId;
    }
}

public sealed class LightDocumentBranchDeletedEvent : DomainEvent
{
    public LightDocumentBranchId LightDocumentBranchId { get; }

    public LightDocumentBranchDeletedEvent(LightDocumentBranchId lightdocumentbranchId)
    {
        LightDocumentBranchId = lightdocumentbranchId;
    }
}
}
