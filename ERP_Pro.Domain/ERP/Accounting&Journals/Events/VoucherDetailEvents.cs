using System;
using ERP_Pro.Domain.Common.Events;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public record VoucherDetailCreatedEvent : IDomainEvent
    {
        public VoucherDetail Detail { get; }
        public DateTime OccurredOn { get; }

        public VoucherDetailCreatedEvent(VoucherDetail detail)
        {
            Detail = detail;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record VoucherDetailAmountUpdatedEvent : IDomainEvent
    {
        public VoucherDetail Detail { get; }
        public VoucherAmount OldAmount { get; }
        public DateTime OccurredOn { get; }

        public VoucherDetailAmountUpdatedEvent(VoucherDetail detail, VoucherAmount oldAmount)
        {
            Detail = detail;
            OldAmount = oldAmount;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record VoucherDetailReferencesUpdatedEvent : IDomainEvent
    {
        public VoucherDetail Detail { get; }
        public ReferenceInfo OldReference { get; }
        public DateTime OccurredOn { get; }

        public VoucherDetailReferencesUpdatedEvent(VoucherDetail detail, ReferenceInfo oldReference)
        {
            Detail = detail;
            OldReference = oldReference;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record VoucherDetailChequeUpdatedEvent : IDomainEvent
    {
        public VoucherDetail Detail { get; }
        public ChequeInfo OldCheque { get; }
        public DateTime OccurredOn { get; }

        public VoucherDetailChequeUpdatedEvent(VoucherDetail detail, ChequeInfo oldCheque)
        {
            Detail = detail;
            OldCheque = oldCheque;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record VoucherDetailNoteUpdatedEvent : IDomainEvent
    {
        public VoucherDetail Detail { get; }
        public string OldNote { get; }
        public DateTime OccurredOn { get; }

        public VoucherDetailNoteUpdatedEvent(VoucherDetail detail, string oldNote)
        {
            Detail = detail;
            OldNote = oldNote;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 