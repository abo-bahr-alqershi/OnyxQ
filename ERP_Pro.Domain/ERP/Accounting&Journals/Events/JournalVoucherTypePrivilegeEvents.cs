using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record JournalVoucherTypePrivilegeCreatedEvent : IDomainEvent
    {
        public JournalVoucherTypePrivilege Privilege { get; }
        public DateTime OccurredOn { get; }

        public JournalVoucherTypePrivilegeCreatedEvent(JournalVoucherTypePrivilege privilege)
        {
            Privilege = privilege;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalVoucherTypePrivilegeUpdatedEvent : IDomainEvent
    {
        public JournalVoucherTypePrivilege Privilege { get; }
        public PrivilegeInfo OldPrivileges { get; }
        public DateTime OccurredOn { get; }

        public JournalVoucherTypePrivilegeUpdatedEvent(
            JournalVoucherTypePrivilege privilege,
            PrivilegeInfo oldPrivileges)
        {
            Privilege = privilege;
            OldPrivileges = oldPrivileges;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 