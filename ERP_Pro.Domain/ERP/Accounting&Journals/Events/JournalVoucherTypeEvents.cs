using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record JournalVoucherTypeCreatedEvent : IDomainEvent
    {
        public JournalVoucherType VoucherType { get; }
        public DateTime OccurredOn { get; }

        public JournalVoucherTypeCreatedEvent(JournalVoucherType voucherType)
        {
            VoucherType = voucherType;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalVoucherTypeUpdatedEvent : IDomainEvent
    {
        public JournalVoucherType VoucherType { get; }
        public object OldState { get; }
        public DateTime OccurredOn { get; }

        public JournalVoucherTypeUpdatedEvent(JournalVoucherType voucherType, object oldState)
        {
            VoucherType = voucherType;
            OldState = oldState;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 