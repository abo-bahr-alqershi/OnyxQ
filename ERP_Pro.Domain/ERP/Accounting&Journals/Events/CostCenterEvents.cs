using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record CostCenterCreatedEvent : IDomainEvent
    {
        public CostCenter CostCenter { get; }
        public DateTime OccurredOn { get; }

        public CostCenterCreatedEvent(CostCenter costCenter)
        {
            CostCenter = costCenter;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record CostCenterNamesUpdatedEvent : IDomainEvent
    {
        public CostCenter CostCenter { get; }
        public string OldNameAr { get; }
        public string? OldNameEn { get; }
        public DateTime OccurredOn { get; }

        public CostCenterNamesUpdatedEvent(CostCenter costCenter, string oldNameAr, string? oldNameEn)
        {
            CostCenter = costCenter;
            OldNameAr = oldNameAr;
            OldNameEn = oldNameEn;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record CostCenterParentUpdatedEvent : IDomainEvent
    {
        public CostCenter CostCenter { get; }
        public string? OldParentCode { get; }
        public DateTime OccurredOn { get; }

        public CostCenterParentUpdatedEvent(CostCenter costCenter, string? oldParentCode)
        {
            CostCenter = costCenter;
            OldParentCode = oldParentCode;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record CostCenterActivatedEvent : IDomainEvent
    {
        public CostCenter CostCenter { get; }
        public DateTime OccurredOn { get; }

        public CostCenterActivatedEvent(CostCenter costCenter)
        {
            CostCenter = costCenter;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record CostCenterDeactivatedEvent : IDomainEvent
    {
        public CostCenter CostCenter { get; }
        public DateTime OccurredOn { get; }

        public CostCenterDeactivatedEvent(CostCenter costCenter)
        {
            CostCenter = costCenter;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 