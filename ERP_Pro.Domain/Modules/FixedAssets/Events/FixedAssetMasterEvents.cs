using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.FixedAssets.ValueObjects;

namespace ERP_Pro.Domain.ERP.FixedAssets.Events
{
/// <summary>
/// Events related to FixedAssetMaster entity
/// </summary>
public sealed class FixedAssetMasterCreatedEvent : DomainEvent
{
    public FixedAssetMasterId FixedAssetMasterId { get; }

    public FixedAssetMasterCreatedEvent(FixedAssetMasterId fixedassetmasterId)
    {
        FixedAssetMasterId = fixedassetmasterId;
    }
}

public sealed class FixedAssetMasterUpdatedEvent : DomainEvent
{
    public FixedAssetMasterId FixedAssetMasterId { get; }

    public FixedAssetMasterUpdatedEvent(FixedAssetMasterId fixedassetmasterId)
    {
        FixedAssetMasterId = fixedassetmasterId;
    }
}

public sealed class FixedAssetMasterDeletedEvent : DomainEvent
{
    public FixedAssetMasterId FixedAssetMasterId { get; }

    public FixedAssetMasterDeletedEvent(FixedAssetMasterId fixedassetmasterId)
    {
        FixedAssetMasterId = fixedassetmasterId;
    }
}
}
