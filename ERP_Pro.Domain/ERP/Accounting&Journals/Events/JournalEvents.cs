using System;
using ERP_Pro.Domain.Common;
using ERP_Pro.Domain.ERP.Accounting&Journals.Entities;
using ERP_Pro.Domain.ERP.Accounting&Journals.ValueObjects;

namespace ERP_Pro.Domain.ERP.Accounting&Journals.Events
{
    public class JournalCreatedEvent : DomainEvent
    {
        public Journal Journal { get; }

        public JournalCreatedEvent(Journal journal)
        {
            Journal = journal;
        }
    }

    public class JournalPostedEvent : DomainEvent
    {
        public Journal Journal { get; }
        public int PostedByUserId { get; }
        public DateTime PostedDate { get; }

        public JournalPostedEvent(Journal journal)
        {
            Journal = journal;
            PostedByUserId = journal.PostedByUserId ?? throw new InvalidOperationException("Journal not posted");
            PostedDate = journal.PostedDate ?? throw new InvalidOperationException("Journal not posted");
        }
    }

    public class JournalUnpostedEvent : DomainEvent
    {
        public Journal Journal { get; }
        public int UnpostedByUserId { get; }
        public DateTime UnpostedDate { get; }

        public JournalUnpostedEvent(Journal journal)
        {
            Journal = journal;
            UnpostedByUserId = journal.UnpostedByUserId ?? throw new InvalidOperationException("Journal not unposted");
            UnpostedDate = journal.UnpostedDate ?? throw new InvalidOperationException("Journal not unposted");
        }
    }

    public class JournalDetailAddedEvent : DomainEvent
    {
        public Journal Journal { get; }
        public JournalDetail Detail { get; }

        public JournalDetailAddedEvent(Journal journal, JournalDetail detail)
        {
            Journal = journal;
            Detail = detail;
        }
    }

    public class JournalDetailRemovedEvent : DomainEvent
    {
        public Journal Journal { get; }
        public JournalDetail Detail { get; }

        public JournalDetailRemovedEvent(Journal journal, JournalDetail detail)
        {
            Journal = journal;
            Detail = detail;
        }
    }

    public class JournalDetailUpdatedEvent : DomainEvent
    {
        public JournalDetail Detail { get; }

        public JournalDetailUpdatedEvent(JournalDetail detail)
        {
            Detail = detail;
        }
    }

    public class JournalAuditReferenceUpdatedEvent : DomainEvent
    {
        public Journal Journal { get; }
        public string OldDescription { get; }
        public int OldUserId { get; }

        public JournalAuditReferenceUpdatedEvent(Journal journal, string oldDescription, int oldUserId)
        {
            Journal = journal;
            OldDescription = oldDescription;
            OldUserId = oldUserId;
        }
    }

    public class JournalAuditReferenceClearedEvent : DomainEvent
    {
        public Journal Journal { get; }

        public JournalAuditReferenceClearedEvent(Journal journal)
        {
            Journal = journal;
        }
    }

    public record JournalBranchDetailAddedEvent : IDomainEvent
    {
        public MasterJournal Journal { get; }
        public JournalDetailBranch Detail { get; }
        public DateTime OccurredOn { get; }

        public JournalBranchDetailAddedEvent(MasterJournal journal, JournalDetailBranch detail)
        {
            Journal = journal;
            Detail = detail;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalDescriptionUpdatedEvent : IDomainEvent
    {
        public MasterJournal Journal { get; }
        public string OldBeneficiaryName { get; }
        public string OldReceiverName { get; }
        public string OldDescription { get; }
        public DateTime OccurredOn { get; }

        public JournalDescriptionUpdatedEvent(
            MasterJournal journal,
            string oldBeneficiaryName,
            string oldReceiverName,
            string oldDescription)
        {
            Journal = journal;
            OldBeneficiaryName = oldBeneficiaryName;
            OldReceiverName = oldReceiverName;
            OldDescription = oldDescription;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public record JournalAuditedEvent : IDomainEvent
    {
        public MasterJournal Journal { get; }
        public DateTime OccurredOn { get; }

        public JournalAuditedEvent(MasterJournal journal)
        {
            Journal = journal;
            OccurredOn = DateTime.UtcNow;
        }
    }
} 