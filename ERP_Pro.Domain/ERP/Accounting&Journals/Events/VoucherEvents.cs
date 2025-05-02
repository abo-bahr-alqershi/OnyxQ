using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public class VoucherCreatedEvent : DomainEvent
    {
        public Voucher Voucher { get; }

        public VoucherCreatedEvent(Voucher voucher)
        {
            Voucher = voucher;
        }
    }

    public class VoucherPostedEvent : DomainEvent
    {
        public Voucher Voucher { get; }
        public int PostedByUserId { get; }
        public DateTime PostedDate { get; }

        public VoucherPostedEvent(Voucher voucher)
        {
            Voucher = voucher;
            PostedByUserId = voucher.PostedByUserId ?? throw new InvalidOperationException("Voucher not posted");
            PostedDate = voucher.PostedDate ?? throw new InvalidOperationException("Voucher not posted");
        }
    }

    public class VoucherUnpostedEvent : DomainEvent
    {
        public Voucher Voucher { get; }
        public int UnpostedByUserId { get; }
        public DateTime UnpostedDate { get; }

        public VoucherUnpostedEvent(Voucher voucher)
        {
            Voucher = voucher;
            UnpostedByUserId = voucher.UnpostedByUserId ?? throw new InvalidOperationException("Voucher not unposted");
            UnpostedDate = voucher.UnpostedDate ?? throw new InvalidOperationException("Voucher not unposted");
        }
    }

    public class VoucherDetailAddedEvent : DomainEvent
    {
        public Voucher Voucher { get; }
        public VoucherDetail Detail { get; }

        public VoucherDetailAddedEvent(Voucher voucher, VoucherDetail detail)
        {
            Voucher = voucher;
            Detail = detail;
        }
    }

    public class VoucherDetailRemovedEvent : DomainEvent
    {
        public Voucher Voucher { get; }
        public VoucherDetail Detail { get; }

        public VoucherDetailRemovedEvent(Voucher voucher, VoucherDetail detail)
        {
            Voucher = voucher;
            Detail = detail;
        }
    }

    public class VoucherDetailUpdatedEvent : DomainEvent
    {
        public VoucherDetail Detail { get; }

        public VoucherDetailUpdatedEvent(VoucherDetail detail)
        {
            Detail = detail;
        }
    }

    public class VoucherAuditReferenceUpdatedEvent : DomainEvent
    {
        public Voucher Voucher { get; }
        public string OldDescription { get; }
        public int OldUserId { get; }

        public VoucherAuditReferenceUpdatedEvent(Voucher voucher, string oldDescription, int oldUserId)
        {
            Voucher = voucher;
            OldDescription = oldDescription;
            OldUserId = oldUserId;
        }
    }

    public class VoucherAuditReferenceClearedEvent : DomainEvent
    {
        public Voucher Voucher { get; }

        public VoucherAuditReferenceClearedEvent(Voucher voucher)
        {
            Voucher = voucher;
        }
    }
} 